using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core.Http;
using Azure.Core.Pipeline;

namespace Azure.Storage.Common
{
    /// <summary>
    /// Pipeline policy to verify x-ms-client-request-id and x-ms-client-return-request-id 
    /// headers that are echoed back from a request match.
    /// </summary>
    public class StorageRequestValidationPipelinePolicy : SynchronousHttpPipelinePolicy
    {
        /// <summary>
        /// Create a new StorageRequestValidationPipelinePolicy
        /// </summary>
        public StorageRequestValidationPipelinePolicy()
        {
        }

        /// <summary>
        /// Gets the StorageRequestValidationPipelinePolicy object
        /// </summary>
        public StorageRequestValidationPipelinePolicy GetStorageValidationPipelinePolicy { get; }

        /// <summary>
        /// Verify x-ms-client-request-id and x-ms-client-return-request-id headers matches as
        /// x-ms-client-return-request-id is an echo of x-mis-client-request-id.
        /// </summary>
        /// <param name="message">The message that was sent</param>
        public override void OnReceivedResponse(HttpPipelineMessage message)
        {
            if (message.HasResponse &&
                message.Request.Headers.TryGetValue(Constants.HeaderNames.ClientRequestId, out var original) &&
                message.Response.Headers.TryGetValue(Constants.HeaderNames.ClientRequestId, out var echo) &&
                !String.Equals(original, echo, StringComparison.OrdinalIgnoreCase))
            {
                throw new StorageRequestFailedException(
                    message.Response,
                    $"Response x-ms-client-return-request-id '{echo}' does not match the expected '{original}'.");
            }
        }
    }
}
