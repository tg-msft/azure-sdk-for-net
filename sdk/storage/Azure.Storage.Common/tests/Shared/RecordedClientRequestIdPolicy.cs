using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core.Http;
using Azure.Core.Pipeline;
using Azure.Core.Testing;

namespace Azure.Storage.Test.Shared
{
    /// <summary>
    /// Pipeline policy to verify x-ms-client-request-id and x-ms-client-return-request-id 
    /// headers that are echoed back from a request match.
    /// </summary>
    public class RecordedClientRequestIdPolicy : SynchronousHttpPipelinePolicy
    {
        private readonly TestRecording _testRecording;

        /// <summary>
        /// Create a new RecordedClientRequestIdPolicy
        /// </summary>
        public RecordedClientRequestIdPolicy(TestRecording testRecording)
        {
            _testRecording = testRecording;
        }

        /// <summary>
        /// Gets the RecordedClientRequestIdPolicy object
        /// </summary>
        public RecordedClientRequestIdPolicy GetStorageValidationPipelinePolicy { get; }

        /// <summary>
        /// Verify x-ms-client-request-id and x-ms-client-return-request-id headers matches as
        /// x-ms-client-return-request-id is an echo of x-mis-client-request-id.
        /// </summary>
        /// <param name="message">The message that was sent</param>
        public override void OnSendingRequest(HttpPipelineMessage message)
        {
            message.Request.ClientRequestId = _testRecording.Random.NewGuid().ToString();
        }
    }
}
