public partial class AppendBlobOpenWriteOptions
{
    public AppendBlobOpenWriteOptions() { }
    public long? BufferSize { get; set; }
    public AppendBlobRequestConditions InitialConditions { get; set; }
    public long? MaxSize { get; set; } // Could add in the future
    public IProgress<long> ProgressHandler { get; set; }
}

public partial class AppendBlobClient : BlobBaseClient
{
    public virtual Stream OpenWrite(...) { }
    public virtual Task<Stream> OpenWriteAsync(
        bool overwrite = false, // Match BlobClient.Upload
        AppendBlobOpenWriteOptions options = null,
        CancellationToken cancellationToken = default)
    {
        string etag = null;
        long position = 0;
        if (overwrite)
        {
            DeleteIfExists(..., options?.InitialConditions, ...); // so soft delete picks it up?
            var response = Create();
            etag = response.ETag;
        }
        else
        {
            var response = CreateIfNotExists(..., options?.InitialConditions, ...);
            if (response != null)
            {
                etag = response.ETag;
                position = 0;
            }
            else
            {
                var props = GetProperties(..., options?.InitialConditions, ...);
                etag = props.ETag;
                position = props.ContentLength;
            }
        }
        var writeConditions = new AppendBlobRequestConditions
        {
            IfMatch = eTag,
            LeaseId = options?.InitialConditions?.LeaseId,
            IfMaxSizeLessThanOrEqual = options?.MaxSize
        };
        return new AppendBlobWriteStream(..., writeConditions, ...);
    }

    class AppendBlobWriteStream : StorageWriteStream
    {
        protected override async Task AppendInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            var response = client.Append(..., _writeConditions, ...);
            _writeConditions.IfMatch = response.ETag;
        }

        protected override async Task FlushInternal(
            bool async,
            CancellationToken cancellationToken) => AppendInternal(...);
    }
}



public partial class BlockBlobOpenWriteOptions
{
    public BlockBlobOpenWriteOptions() { }
    public long? BufferSize { get; set; }
    public BlobRequestConditions InitialConditions { get; set; }
    public IProgress<long> ProgressHandler { get; set; }
}

public partial class BlockBlobClient : BlobBaseClient
{
    public virtual Stream OpenWrite(...) { }
    public virtual Task<Stream> OpenWriteAsync(
        bool overwrite = false, // Match BlobClient.Upload
        BlockBlobOpenWriteOptions options = null,
        CancellationToken cancellationToken = default)
    {
        string etag = null;
        IList<string> blockList = null;
        var conditions = options?.InitialConditions;
        if (overwrite)
        {
            Upload(
                content: new MemoryStream(Array.Empty<byte>()),
                conditions,
                ...);
            conditions = new BlobRequestConditions
            {
                LeaseId = options?.InitialConditions?.LeaseId
            };
        }
        try
        {
            var response = GetBlockList(..., conditions, ...);
            blockList = response.Blocks;
            if (blockList.Length == 0 && response.ContentLength > 0)
            {
                // Just fail for the one case overwrite=false doesn't work with block blobs
                throw new InvalidOperationException("Cannot update Block Blob without blocks!");
            }
            etag = response.ETag;
        }
        catch (RequestFailedException ex) when ex.ErrorCode == "BlobNotFound"
        {
            // Create if it doesn't already exist
            Upload(content: new MemoryStream(Array.Empty<byte>()));
            var response = GetBlockList(...);
            blockList = response.Blocks;
            etag = response.ETag;
        }
        var writeConditions = new BlobRequestConditions
        {
            IfMatch = etag,
            LeaseId = options?.InitialConditions?.LeaseId
        };
        return new BlockBlobWriteStream(..., writeConditions, blockList, ...);
    }

    class BlockBlobWriteStream : StorageWriteStream
    {
        protected override async Task AppendInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            client.StageBlock(..., _writeConditions, ...);
        }

        protected override async Task FlushInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            var response = client.CommitBlockList(..., _writeConditions, ...);
            _writeConditions.IfMatch = response.ETag;
        }
    }
}



public partial class PageBlobOpenWriteOptions
{
    public PageBlobOpenWriteOptions() { }
    public long? BufferSize { get; set; }
    public PageBlobRequestConditions InitialConditions { get; set; }
    public IProgress<long> ProgressHandler { get; set; }
    public long? MaxSequenceNumber { get; set; } // Could add in the future
    public long Size { get; set; }
}

public partial class PageBlobClient : BlobBaseClient
{
    public virtual Stream OpenWrite(...) { }
    public virtual Task<Stream> OpenWriteAsync(
        bool overwrite = false, // Match BlobClient.Upload
        long position = 0,
        PageBlobOpenWriteOptions options = null,
        CancellationToken cancellationToken = default)
    {
        string etag = null;
        if (overwrite)
        {
            DeleteIfExists(..., options?.InitialConditions, ...); // So soft delete picks it up?
            var response = Create();
            etag = response.ETag;
        }
        else
        {
            var response = CreateIfNotExists(..., options?.InitialConditions, ...);
            if (response != null)
            {
                etag = response.ETag;
            }
            else
            {
                var props = GetProperties(..., options?.InitialConditions, ...);
                etag = props.ETag;
            }
        }
        var writeConditions = new AppendBlobRequestConditions
        {
            IfMatch = props.ETag,
            LeaseId = options?.InitialConditions?.LeaseId,
            IfSequenceNumberLessThanOrEqual = options?.MaxSequenceNumber
        };
        return new PageBlobWriteStream(..., writeConditions, ...);
    }

    class PageBlobWriteStream : StorageWriteStream
    {
        protected override async Task AppendInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            var response = client.UploadPages(..., _writeConditions, ...);
            _writeConditions.IfMatch = response.ETag;
        }

        protected override async Task FlushInternal(
            bool async,
            CancellationToken cancellationToken) => AppendInternal(...);
    }
}