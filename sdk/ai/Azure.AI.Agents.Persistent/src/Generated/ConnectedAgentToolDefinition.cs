// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The input definition information for a connected agent tool which defines a domain specific sub-agent. </summary>
    public partial class ConnectedAgentToolDefinition : ToolDefinition
    {
        /// <summary> Initializes a new instance of <see cref="ConnectedAgentToolDefinition"/>. </summary>
        /// <param name="connectedAgent"> The sub-agent to connect. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedAgent"/> is null. </exception>
        public ConnectedAgentToolDefinition(ConnectedAgentDetails connectedAgent)
        {
            Argument.AssertNotNull(connectedAgent, nameof(connectedAgent));

            Type = "connected_agent";
            ConnectedAgent = connectedAgent;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedAgentToolDefinition"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="connectedAgent"> The sub-agent to connect. </param>
        internal ConnectedAgentToolDefinition(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, ConnectedAgentDetails connectedAgent) : base(type, serializedAdditionalRawData)
        {
            ConnectedAgent = connectedAgent;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedAgentToolDefinition"/> for deserialization. </summary>
        internal ConnectedAgentToolDefinition()
        {
        }

        /// <summary> The sub-agent to connect. </summary>
        public ConnectedAgentDetails ConnectedAgent { get; set; }
    }
}
