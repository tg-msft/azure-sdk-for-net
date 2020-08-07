public partial class AppendBlobOpenWriteOptions
{
    public AppendBlobOpenWriteOptions() { }
    public long? BufferSize { get; set; }
    public AppendBlobRequestConditions Conditions { get; set; }
    public IProgress<long> ProgressHandler { get; set; }
}

public partial class AppendBlobClient : BlobBaseClient
{
    public virtual Stream OpenWrite(...) { }
    public virtual Task<Stream> OpenWriteAsync(
        AppendBlobOpenWriteOptions options = null,
        CancellationToken cancellationToken = default)
    {
        var props = GetProperties();
        long position = props.ContentLength;
        var writeConditions = new AppendBlobRequestConditions
        {
            IfMatch = props.ETag,
            LeaseId = options?.Conditions?.LeaseId,
            IfAppendPositionEqual = options?.Conditions?.IfAppendPositionEqual,
            IfMaxSizeLessThanOrEqual = options?.Conditions?.IfMaxSizeLessThanOrEqual
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
            _writeConditions.IfAppendPositionEqual = null;
            _writeConditions.IfMaxSizeLessThanOrEqual = null;
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
    public BlobRequestConditions Conditions { get; set; }
    public IProgress<long> ProgressHandler { get; set; }
}

public partial class BlockBlobClient : BlobBaseClient
{
    public virtual Stream OpenWrite(...) { }
    public virtual Task<Stream> OpenWriteAsync(
        BlockBlobOpenWriteOptions options = null,
        CancellationToken cancellationToken = default)
    {
        var response = Upload(content: new MemoryStream(Array.Empty<byte>()));
        var writeConditions = new BlobRequestConditions
        {
            IfMatch = response.ETag,
            LeaseId = options?.Conditions?.LeaseId
        };
        return new BlockBlobWriteStream(..., writeConditions, ...);
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
            client.CommitBlockList(..., _writeConditions, ...); 
        }
    }
}



public partial class PageBlobOpenWriteOptions
{
    public PageBlobOpenWriteOptions() { }
    public long? BufferSize { get; set; }
    public PageBlobRequestConditions Conditions { get; set; }
    public IProgress<long> ProgressHandler { get; set; }
    public long Size { get; set; }
}

public partial class PageBlobClient : BlobBaseClient
{
    public virtual Stream OpenWrite(...) { }
    public virtual Task<Stream> OpenWriteAsync(
        long position,
        PageBlobOpenWriteOptions options = null,
        CancellationToken cancellationToken = default)
    {
        var props = GetProperties();
        var writeConditions = new AppendBlobRequestConditions
        {
            IfMatch = props.ETag,
            LeaseId = options?.Conditions?.LeaseId,
            IfSequenceNumberEqual = options?.Conditions?.IfSequenceNumberEqual,
            IfSequenceNumberLessThan = options?.Conditions?.IfSequenceNumberLessThan,
            IfSequenceNumberLessThanOrEqual = options?.Conditions?.IfSequenceNumberLessThanOrEqual
        };
        return new PageBlobWriteStream(..., writeConditions, ...);
    }

    class PageBlobWriteStream : StorageWriteStream
    {
        protected override async Task AppendInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            var response = client.UploadPages(..., _writeConditions, );
            _writeConditions.IfMatch = response.ETag;
        }

        protected override async Task FlushInternal(
            bool async,
            CancellationToken cancellationToken) => AppendInternal(...);
    }
}