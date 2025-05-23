// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class RestorePointGroupResource : IJsonModel<RestorePointGroupData>
    {
        private static RestorePointGroupData s_dataDeserializationInstance;
        private static RestorePointGroupData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<RestorePointGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RestorePointGroupData>)Data).Write(writer, options);

        RestorePointGroupData IJsonModel<RestorePointGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RestorePointGroupData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<RestorePointGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RestorePointGroupData>(Data, options, AzureResourceManagerComputeContext.Default);

        RestorePointGroupData IPersistableModel<RestorePointGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RestorePointGroupData>(data, options, AzureResourceManagerComputeContext.Default);

        string IPersistableModel<RestorePointGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RestorePointGroupData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
