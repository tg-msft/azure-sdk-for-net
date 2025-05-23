// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PureStorageBlock.Models
{
    /// <summary> AVS disk/volume information. </summary>
    public partial class PureStorageAvsDiskDetails
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

        /// <summary> Initializes a new instance of <see cref="PureStorageAvsDiskDetails"/>. </summary>
        /// <param name="diskId"> VMware ID of the disk/volume. </param>
        /// <param name="diskName"> VMware name of the disk/volume. </param>
        /// <param name="folder"> Name of the top-level folder in the datastore that contains the disk/volume. </param>
        /// <param name="avsVmInternalId"> VMware ID assigned to the disk/volume. </param>
        /// <param name="avsVmResourceId"> Azure resource ID of the AVS VM connected to this disk/volume. </param>
        /// <param name="avsVmName"> Name of the AVS VM connected to this disk/volume. </param>
        /// <param name="avsStorageContainerResourceId"> Azure resource ID of the AVS storage container containing this disk/volume. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/>, <paramref name="diskName"/>, <paramref name="folder"/>, <paramref name="avsVmInternalId"/>, <paramref name="avsVmResourceId"/>, <paramref name="avsVmName"/> or <paramref name="avsStorageContainerResourceId"/> is null. </exception>
        internal PureStorageAvsDiskDetails(string diskId, string diskName, string folder, string avsVmInternalId, ResourceIdentifier avsVmResourceId, string avsVmName, ResourceIdentifier avsStorageContainerResourceId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));
            Argument.AssertNotNull(diskName, nameof(diskName));
            Argument.AssertNotNull(folder, nameof(folder));
            Argument.AssertNotNull(avsVmInternalId, nameof(avsVmInternalId));
            Argument.AssertNotNull(avsVmResourceId, nameof(avsVmResourceId));
            Argument.AssertNotNull(avsVmName, nameof(avsVmName));
            Argument.AssertNotNull(avsStorageContainerResourceId, nameof(avsStorageContainerResourceId));

            DiskId = diskId;
            DiskName = diskName;
            Folder = folder;
            AvsVmInternalId = avsVmInternalId;
            AvsVmResourceId = avsVmResourceId;
            AvsVmName = avsVmName;
            AvsStorageContainerResourceId = avsStorageContainerResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageAvsDiskDetails"/>. </summary>
        /// <param name="diskId"> VMware ID of the disk/volume. </param>
        /// <param name="diskName"> VMware name of the disk/volume. </param>
        /// <param name="folder"> Name of the top-level folder in the datastore that contains the disk/volume. </param>
        /// <param name="avsVmInternalId"> VMware ID assigned to the disk/volume. </param>
        /// <param name="avsVmResourceId"> Azure resource ID of the AVS VM connected to this disk/volume. </param>
        /// <param name="avsVmName"> Name of the AVS VM connected to this disk/volume. </param>
        /// <param name="avsStorageContainerResourceId"> Azure resource ID of the AVS storage container containing this disk/volume. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PureStorageAvsDiskDetails(string diskId, string diskName, string folder, string avsVmInternalId, ResourceIdentifier avsVmResourceId, string avsVmName, ResourceIdentifier avsStorageContainerResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            DiskName = diskName;
            Folder = folder;
            AvsVmInternalId = avsVmInternalId;
            AvsVmResourceId = avsVmResourceId;
            AvsVmName = avsVmName;
            AvsStorageContainerResourceId = avsStorageContainerResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageAvsDiskDetails"/> for deserialization. </summary>
        internal PureStorageAvsDiskDetails()
        {
        }

        /// <summary> VMware ID of the disk/volume. </summary>
        public string DiskId { get; }
        /// <summary> VMware name of the disk/volume. </summary>
        public string DiskName { get; }
        /// <summary> Name of the top-level folder in the datastore that contains the disk/volume. </summary>
        public string Folder { get; }
        /// <summary> VMware ID assigned to the disk/volume. </summary>
        public string AvsVmInternalId { get; }
        /// <summary> Azure resource ID of the AVS VM connected to this disk/volume. </summary>
        public ResourceIdentifier AvsVmResourceId { get; }
        /// <summary> Name of the AVS VM connected to this disk/volume. </summary>
        public string AvsVmName { get; }
        /// <summary> Azure resource ID of the AVS storage container containing this disk/volume. </summary>
        public ResourceIdentifier AvsStorageContainerResourceId { get; }
    }
}
