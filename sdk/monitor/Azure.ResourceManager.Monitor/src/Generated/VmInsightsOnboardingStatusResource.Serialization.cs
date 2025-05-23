// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Monitor
{
    public partial class VmInsightsOnboardingStatusResource : IJsonModel<VmInsightsOnboardingStatusData>
    {
        private static VmInsightsOnboardingStatusData s_dataDeserializationInstance;
        private static VmInsightsOnboardingStatusData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<VmInsightsOnboardingStatusData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VmInsightsOnboardingStatusData>)Data).Write(writer, options);

        VmInsightsOnboardingStatusData IJsonModel<VmInsightsOnboardingStatusData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VmInsightsOnboardingStatusData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<VmInsightsOnboardingStatusData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<VmInsightsOnboardingStatusData>(Data, options, AzureResourceManagerMonitorContext.Default);

        VmInsightsOnboardingStatusData IPersistableModel<VmInsightsOnboardingStatusData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VmInsightsOnboardingStatusData>(data, options, AzureResourceManagerMonitorContext.Default);

        string IPersistableModel<VmInsightsOnboardingStatusData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VmInsightsOnboardingStatusData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
