// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Optional settings for a Managed Identity that is assigned to the Session pool. </summary>
    public partial class SessionPoolManagedIdentitySetting
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SessionPoolManagedIdentitySetting"/>. </summary>
        /// <param name="identity"> The resource ID of a user-assigned managed identity that is assigned to the Session Pool, or 'system' for system-assigned identity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identity"/> is null. </exception>
        public SessionPoolManagedIdentitySetting(string identity)
        {
            Argument.AssertNotNull(identity, nameof(identity));

            Identity = identity;
        }

        /// <summary> Initializes a new instance of <see cref="SessionPoolManagedIdentitySetting"/>. </summary>
        /// <param name="identity"> The resource ID of a user-assigned managed identity that is assigned to the Session Pool, or 'system' for system-assigned identity. </param>
        /// <param name="lifecycle"> Use to select the lifecycle stages of a Session Pool during which the Managed Identity should be available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionPoolManagedIdentitySetting(string identity, ContainerAppIdentitySettingsLifeCycle? lifecycle, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Lifecycle = lifecycle;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SessionPoolManagedIdentitySetting"/> for deserialization. </summary>
        internal SessionPoolManagedIdentitySetting()
        {
        }

        /// <summary> The resource ID of a user-assigned managed identity that is assigned to the Session Pool, or 'system' for system-assigned identity. </summary>
        [WirePath("identity")]
        public string Identity { get; set; }
        /// <summary> Use to select the lifecycle stages of a Session Pool during which the Managed Identity should be available. </summary>
        [WirePath("lifecycle")]
        public ContainerAppIdentitySettingsLifeCycle? Lifecycle { get; set; }
    }
}
