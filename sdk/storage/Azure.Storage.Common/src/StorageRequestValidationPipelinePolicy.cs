// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Threading.Tasks;
using Azure.Core.Http;
using Azure.Core.Pipeline;

namespace Azure.Storage.Common
{
    /// <summary>
    /// Pipeline policy to verify x-ms-client-request-id headers that are
    /// echoed back from a request.
    /// </summary>
    public class StorageRequestValidationPipelinePolicy : SynchronousHttpPipelinePolicy
    {
        /// <summary>
        /// Verify x-ms-client-request-id headers that are echoed back from a
        /// request.
        /// </summary>
        /// <param name="message">The message that was sent.</param>
        public override void OnReceivedResponse(HttpPipelineMessage message)
        {
            base.OnReceivedResponse(message);
            if (message.HasResponse &&
                message.Request.Headers.TryGetValue(HttpHeader.Names.XMsClientRequestId, out var original) &&
                message.Response.Headers.TryGetValue(HttpHeader.Names.XMsClientRequestId, out var echo) &&
                !String.Equals(original, echo, StringComparison.OrdinalIgnoreCase))
            {
                throw new StorageRequestFailedException(
                    message.Response,
                    $"Response x-ms-client-request-id '{echo}' does not match the expected '{original}'.");
            }
        }
    }
}
