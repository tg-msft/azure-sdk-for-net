// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SolutionReplacementMaps : IUtf8JsonSerializable, IJsonModel<SolutionReplacementMaps>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SolutionReplacementMaps>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SolutionReplacementMaps>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SolutionReplacementMaps)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(WebResults))
            {
                writer.WritePropertyName("webResults"u8);
                writer.WriteStartArray();
                foreach (var item in WebResults)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteStartArray();
                foreach (var item in Diagnostics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Troubleshooters))
            {
                writer.WritePropertyName("troubleshooters"u8);
                writer.WriteStartArray();
                foreach (var item in Troubleshooters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MetricsBasedCharts))
            {
                writer.WritePropertyName("metricsBasedCharts"u8);
                writer.WriteStartArray();
                foreach (var item in MetricsBasedCharts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Videos))
            {
                writer.WritePropertyName("videos"u8);
                writer.WriteStartArray();
                foreach (var item in Videos)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VideoGroups))
            {
                writer.WritePropertyName("videoGroups"u8);
                writer.WriteStartArray();
                foreach (var item in VideoGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        SolutionReplacementMaps IJsonModel<SolutionReplacementMaps>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SolutionReplacementMaps)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSolutionReplacementMaps(document.RootElement, options);
        }

        internal static SolutionReplacementMaps DeserializeSolutionReplacementMaps(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<KBWebResult> webResults = default;
            IReadOnlyList<SolutionsDiagnostic> diagnostics = default;
            IReadOnlyList<SolutionsTroubleshooters> troubleshooters = default;
            IReadOnlyList<MetricsBasedChart> metricsBasedCharts = default;
            IReadOnlyList<SelfHelpVideo> videos = default;
            IReadOnlyList<VideoGroupDetail> videoGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KBWebResult> array = new List<KBWebResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KBWebResult.DeserializeKBWebResult(item, options));
                    }
                    webResults = array;
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SolutionsDiagnostic> array = new List<SolutionsDiagnostic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SolutionsDiagnostic.DeserializeSolutionsDiagnostic(item, options));
                    }
                    diagnostics = array;
                    continue;
                }
                if (property.NameEquals("troubleshooters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SolutionsTroubleshooters> array = new List<SolutionsTroubleshooters>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SolutionsTroubleshooters.DeserializeSolutionsTroubleshooters(item, options));
                    }
                    troubleshooters = array;
                    continue;
                }
                if (property.NameEquals("metricsBasedCharts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricsBasedChart> array = new List<MetricsBasedChart>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsBasedChart.DeserializeMetricsBasedChart(item, options));
                    }
                    metricsBasedCharts = array;
                    continue;
                }
                if (property.NameEquals("videos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SelfHelpVideo> array = new List<SelfHelpVideo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SelfHelpVideo.DeserializeSelfHelpVideo(item, options));
                    }
                    videos = array;
                    continue;
                }
                if (property.NameEquals("videoGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VideoGroupDetail> array = new List<VideoGroupDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VideoGroupDetail.DeserializeVideoGroupDetail(item, options));
                    }
                    videoGroups = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SolutionReplacementMaps(
                webResults ?? new ChangeTrackingList<KBWebResult>(),
                diagnostics ?? new ChangeTrackingList<SolutionsDiagnostic>(),
                troubleshooters ?? new ChangeTrackingList<SolutionsTroubleshooters>(),
                metricsBasedCharts ?? new ChangeTrackingList<MetricsBasedChart>(),
                videos ?? new ChangeTrackingList<SelfHelpVideo>(),
                videoGroups ?? new ChangeTrackingList<VideoGroupDetail>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SolutionReplacementMaps>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSelfHelpContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SolutionReplacementMaps)} does not support writing '{options.Format}' format.");
            }
        }

        SolutionReplacementMaps IPersistableModel<SolutionReplacementMaps>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SolutionReplacementMaps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSolutionReplacementMaps(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SolutionReplacementMaps)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SolutionReplacementMaps>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
