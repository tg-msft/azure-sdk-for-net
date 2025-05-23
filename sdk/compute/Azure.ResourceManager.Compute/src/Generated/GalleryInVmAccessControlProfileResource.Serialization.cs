// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class GalleryInVmAccessControlProfileResource : IJsonModel<GalleryInVmAccessControlProfileData>
    {
        private static GalleryInVmAccessControlProfileData s_dataDeserializationInstance;
        private static GalleryInVmAccessControlProfileData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<GalleryInVmAccessControlProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GalleryInVmAccessControlProfileData>)Data).Write(writer, options);

        GalleryInVmAccessControlProfileData IJsonModel<GalleryInVmAccessControlProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GalleryInVmAccessControlProfileData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<GalleryInVmAccessControlProfileData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<GalleryInVmAccessControlProfileData>(Data, options, AzureResourceManagerComputeContext.Default);

        GalleryInVmAccessControlProfileData IPersistableModel<GalleryInVmAccessControlProfileData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GalleryInVmAccessControlProfileData>(data, options, AzureResourceManagerComputeContext.Default);

        string IPersistableModel<GalleryInVmAccessControlProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GalleryInVmAccessControlProfileData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
