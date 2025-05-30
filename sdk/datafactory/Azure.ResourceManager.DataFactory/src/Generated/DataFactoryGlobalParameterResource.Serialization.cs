// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataFactory
{
    public partial class DataFactoryGlobalParameterResource : IJsonModel<DataFactoryGlobalParameterData>
    {
        private static DataFactoryGlobalParameterData s_dataDeserializationInstance;
        private static DataFactoryGlobalParameterData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DataFactoryGlobalParameterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataFactoryGlobalParameterData>)Data).Write(writer, options);

        DataFactoryGlobalParameterData IJsonModel<DataFactoryGlobalParameterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataFactoryGlobalParameterData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DataFactoryGlobalParameterData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataFactoryGlobalParameterData>(Data, options, AzureResourceManagerDataFactoryContext.Default);

        DataFactoryGlobalParameterData IPersistableModel<DataFactoryGlobalParameterData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataFactoryGlobalParameterData>(data, options, AzureResourceManagerDataFactoryContext.Default);

        string IPersistableModel<DataFactoryGlobalParameterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataFactoryGlobalParameterData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
