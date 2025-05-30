// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NetApp
{
    public partial class SnapshotPolicyResource : IJsonModel<SnapshotPolicyData>
    {
        private static SnapshotPolicyData s_dataDeserializationInstance;
        private static SnapshotPolicyData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SnapshotPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SnapshotPolicyData>)Data).Write(writer, options);

        SnapshotPolicyData IJsonModel<SnapshotPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SnapshotPolicyData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SnapshotPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SnapshotPolicyData>(Data, options, AzureResourceManagerNetAppContext.Default);

        SnapshotPolicyData IPersistableModel<SnapshotPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SnapshotPolicyData>(data, options, AzureResourceManagerNetAppContext.Default);

        string IPersistableModel<SnapshotPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SnapshotPolicyData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
