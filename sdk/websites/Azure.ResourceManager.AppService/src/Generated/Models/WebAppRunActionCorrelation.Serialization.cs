// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppRunActionCorrelation : IUtf8JsonSerializable, IJsonModel<WebAppRunActionCorrelation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppRunActionCorrelation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebAppRunActionCorrelation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRunActionCorrelation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppRunActionCorrelation)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ActionTrackingId))
            {
                writer.WritePropertyName("actionTrackingId"u8);
                writer.WriteStringValue(ActionTrackingId);
            }
        }

        WebAppRunActionCorrelation IJsonModel<WebAppRunActionCorrelation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRunActionCorrelation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppRunActionCorrelation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppRunActionCorrelation(document.RootElement, options);
        }

        internal static WebAppRunActionCorrelation DeserializeWebAppRunActionCorrelation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string actionTrackingId = default;
            string clientTrackingId = default;
            IList<string> clientKeywords = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionTrackingId"u8))
                {
                    actionTrackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientTrackingId"u8))
                {
                    clientTrackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientKeywords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    clientKeywords = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebAppRunActionCorrelation(clientTrackingId, clientKeywords ?? new ChangeTrackingList<string>(), serializedAdditionalRawData, actionTrackingId);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActionTrackingId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actionTrackingId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ActionTrackingId))
                {
                    builder.Append("  actionTrackingId: ");
                    if (ActionTrackingId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ActionTrackingId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ActionTrackingId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientTrackingId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientTrackingId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientTrackingId))
                {
                    builder.Append("  clientTrackingId: ");
                    if (ClientTrackingId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientTrackingId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientTrackingId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientKeywords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientKeywords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ClientKeywords))
                {
                    if (ClientKeywords.Any())
                    {
                        builder.Append("  clientKeywords: ");
                        builder.AppendLine("[");
                        foreach (var item in ClientKeywords)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WebAppRunActionCorrelation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRunActionCorrelation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebAppRunActionCorrelation)} does not support writing '{options.Format}' format.");
            }
        }

        WebAppRunActionCorrelation IPersistableModel<WebAppRunActionCorrelation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppRunActionCorrelation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWebAppRunActionCorrelation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppRunActionCorrelation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppRunActionCorrelation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
