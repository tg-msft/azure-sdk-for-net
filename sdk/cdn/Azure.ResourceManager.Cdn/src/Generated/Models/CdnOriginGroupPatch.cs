// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Origin group properties needed for origin group creation or update.
    /// Serialized Name: OriginGroupUpdateParameters
    /// </summary>
    public partial class CdnOriginGroupPatch
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

        /// <summary> Initializes a new instance of <see cref="CdnOriginGroupPatch"/>. </summary>
        public CdnOriginGroupPatch()
        {
            Origins = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CdnOriginGroupPatch"/>. </summary>
        /// <param name="healthProbeSettings">
        /// Health probe settings to the origin that is used to determine the health of the origin.
        /// Serialized Name: OriginGroupUpdateParameters.properties.healthProbeSettings
        /// </param>
        /// <param name="origins">
        /// The source of the content being delivered via CDN within given origin group.
        /// Serialized Name: OriginGroupUpdateParameters.properties.origins
        /// </param>
        /// <param name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes">
        /// Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported.
        /// Serialized Name: OriginGroupUpdateParameters.properties.trafficRestorationTimeToHealedOrNewEndpointsInMinutes
        /// </param>
        /// <param name="responseBasedOriginErrorDetectionSettings">
        /// The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported.
        /// Serialized Name: OriginGroupUpdateParameters.properties.responseBasedOriginErrorDetectionSettings
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnOriginGroupPatch(HealthProbeSettings healthProbeSettings, IList<WritableSubResource> origins, int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes, ResponseBasedOriginErrorDetectionSettings responseBasedOriginErrorDetectionSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HealthProbeSettings = healthProbeSettings;
            Origins = origins;
            TrafficRestorationTimeToHealedOrNewEndpointsInMinutes = trafficRestorationTimeToHealedOrNewEndpointsInMinutes;
            ResponseBasedOriginErrorDetectionSettings = responseBasedOriginErrorDetectionSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Health probe settings to the origin that is used to determine the health of the origin.
        /// Serialized Name: OriginGroupUpdateParameters.properties.healthProbeSettings
        /// </summary>
        public HealthProbeSettings HealthProbeSettings { get; set; }
        /// <summary>
        /// The source of the content being delivered via CDN within given origin group.
        /// Serialized Name: OriginGroupUpdateParameters.properties.origins
        /// </summary>
        public IList<WritableSubResource> Origins { get; }
        /// <summary>
        /// Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported.
        /// Serialized Name: OriginGroupUpdateParameters.properties.trafficRestorationTimeToHealedOrNewEndpointsInMinutes
        /// </summary>
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
        /// <summary>
        /// The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported.
        /// Serialized Name: OriginGroupUpdateParameters.properties.responseBasedOriginErrorDetectionSettings
        /// </summary>
        public ResponseBasedOriginErrorDetectionSettings ResponseBasedOriginErrorDetectionSettings { get; set; }
    }
}
