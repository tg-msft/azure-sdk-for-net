// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.OpenAI;

namespace Azure.AI.OpenAI.Chat
{
    internal partial class InternalElasticsearchChatDataSourceParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalElasticsearchChatDataSourceParameters(Uri endpoint, string indexName, DataSourceAuthentication authentication)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(indexName, nameof(indexName));
            Argument.AssertNotNull(authentication, nameof(authentication));

            Endpoint = endpoint;
            IndexName = indexName;
            InternalIncludeContexts = new ChangeTrackingList<string>();
            Authentication = authentication;
        }

        internal InternalElasticsearchChatDataSourceParameters(int? topNDocuments, bool? inScope, int? strictness, int? maxSearchQueries, bool? allowPartialResult, Uri endpoint, string indexName, IList<string> internalIncludeContexts, DataSourceAuthentication authentication, DataSourceFieldMappings fieldMappings, DataSourceQueryType? queryType, DataSourceVectorizer vectorizationSource, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            TopNDocuments = topNDocuments;
            InScope = inScope;
            Strictness = strictness;
            MaxSearchQueries = maxSearchQueries;
            AllowPartialResult = allowPartialResult;
            Endpoint = endpoint;
            IndexName = indexName;
            InternalIncludeContexts = internalIncludeContexts;
            Authentication = authentication;
            FieldMappings = fieldMappings;
            QueryType = queryType;
            VectorizationSource = vectorizationSource;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The configured number of documents to feature in the query. </summary>
        public int? TopNDocuments { get; set; }

        /// <summary> Whether queries should be restricted to use of the indexed data. </summary>
        public bool? InScope { get; set; }

        /// <summary>
        /// The configured strictness of the search relevance filtering.
        /// Higher strictness will increase precision but lower recall of the answer.
        /// </summary>
        public int? Strictness { get; set; }

        /// <summary>
        /// The maximum number of rewritten queries that should be sent to the search provider for a single user message.
        /// By default, the system will make an automatic determination.
        /// </summary>
        public int? MaxSearchQueries { get; set; }

        /// <summary>
        /// If set to true, the system will allow partial search results to be used and the request will fail if all
        /// partial queries fail. If not specified or specified as false, the request will fail if any search query fails.
        /// </summary>
        public bool? AllowPartialResult { get; set; }

        /// <summary> Gets the Endpoint. </summary>
        public Uri Endpoint { get; set; }

        /// <summary> Gets the IndexName. </summary>
        public string IndexName { get; set; }

        /// <summary></summary>
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
