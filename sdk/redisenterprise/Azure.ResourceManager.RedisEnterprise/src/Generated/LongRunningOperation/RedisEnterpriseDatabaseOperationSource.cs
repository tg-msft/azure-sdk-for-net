// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise
{
    internal class RedisEnterpriseDatabaseOperationSource : IOperationSource<RedisEnterpriseDatabaseResource>
    {
        private readonly ArmClient _client;

        internal RedisEnterpriseDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        RedisEnterpriseDatabaseResource IOperationSource<RedisEnterpriseDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RedisEnterpriseDatabaseData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerRedisEnterpriseContext.Default);
            return new RedisEnterpriseDatabaseResource(_client, data);
        }

        async ValueTask<RedisEnterpriseDatabaseResource> IOperationSource<RedisEnterpriseDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<RedisEnterpriseDatabaseData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerRedisEnterpriseContext.Default);
            return await Task.FromResult(new RedisEnterpriseDatabaseResource(_client, data)).ConfigureAwait(false);
        }
    }
}
