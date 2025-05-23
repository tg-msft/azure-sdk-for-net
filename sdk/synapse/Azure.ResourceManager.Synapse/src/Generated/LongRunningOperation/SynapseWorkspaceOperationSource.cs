// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseWorkspaceOperationSource : IOperationSource<SynapseWorkspaceResource>
    {
        private readonly ArmClient _client;

        internal SynapseWorkspaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseWorkspaceResource IOperationSource<SynapseWorkspaceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseWorkspaceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSynapseContext.Default);
            return new SynapseWorkspaceResource(_client, data);
        }

        async ValueTask<SynapseWorkspaceResource> IOperationSource<SynapseWorkspaceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SynapseWorkspaceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSynapseContext.Default);
            return await Task.FromResult(new SynapseWorkspaceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
