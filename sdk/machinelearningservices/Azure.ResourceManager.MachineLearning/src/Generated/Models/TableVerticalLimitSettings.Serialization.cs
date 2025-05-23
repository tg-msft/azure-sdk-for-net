// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class TableVerticalLimitSettings : IUtf8JsonSerializable, IJsonModel<TableVerticalLimitSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TableVerticalLimitSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TableVerticalLimitSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MaxTrials))
            {
                writer.WritePropertyName("maxTrials"u8);
                writer.WriteNumberValue(MaxTrials.Value);
            }
            if (Optional.IsDefined(TrialTimeout))
            {
                writer.WritePropertyName("trialTimeout"u8);
                writer.WriteStringValue(TrialTimeout.Value, "P");
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
            }
            if (Optional.IsDefined(MaxConcurrentTrials))
            {
                writer.WritePropertyName("maxConcurrentTrials"u8);
                writer.WriteNumberValue(MaxConcurrentTrials.Value);
            }
            if (Optional.IsDefined(MaxCoresPerTrial))
            {
                writer.WritePropertyName("maxCoresPerTrial"u8);
                writer.WriteNumberValue(MaxCoresPerTrial.Value);
            }
            if (Optional.IsDefined(ExitScore))
            {
                if (ExitScore != null)
                {
                    writer.WritePropertyName("exitScore"u8);
                    writer.WriteNumberValue(ExitScore.Value);
                }
                else
                {
                    writer.WriteNull("exitScore");
                }
            }
            if (Optional.IsDefined(EnableEarlyTermination))
            {
                writer.WritePropertyName("enableEarlyTermination"u8);
                writer.WriteBooleanValue(EnableEarlyTermination.Value);
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

        TableVerticalLimitSettings IJsonModel<TableVerticalLimitSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTableVerticalLimitSettings(document.RootElement, options);
        }

        internal static TableVerticalLimitSettings DeserializeTableVerticalLimitSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxTrials = default;
            TimeSpan? trialTimeout = default;
            TimeSpan? timeout = default;
            int? maxConcurrentTrials = default;
            int? maxCoresPerTrial = default;
            double? exitScore = default;
            bool? enableEarlyTermination = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trialTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trialTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxCoresPerTrial"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCoresPerTrial = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exitScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        exitScore = null;
                        continue;
                    }
                    exitScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("enableEarlyTermination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableEarlyTermination = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TableVerticalLimitSettings(
                maxTrials,
                trialTimeout,
                timeout,
                maxConcurrentTrials,
                maxCoresPerTrial,
                exitScore,
                enableEarlyTermination,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxTrials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxTrials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxTrials))
                {
                    builder.Append("  maxTrials: ");
                    builder.AppendLine($"{MaxTrials.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrialTimeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trialTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TrialTimeout))
                {
                    builder.Append("  trialTimeout: ");
                    var formattedTimeSpan = TypeFormatters.ToString(TrialTimeout.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timeout))
                {
                    builder.Append("  timeout: ");
                    var formattedTimeSpan = TypeFormatters.ToString(Timeout.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxConcurrentTrials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxConcurrentTrials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxConcurrentTrials))
                {
                    builder.Append("  maxConcurrentTrials: ");
                    builder.AppendLine($"{MaxConcurrentTrials.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxCoresPerTrial), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxCoresPerTrial: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxCoresPerTrial))
                {
                    builder.Append("  maxCoresPerTrial: ");
                    builder.AppendLine($"{MaxCoresPerTrial.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExitScore), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  exitScore: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExitScore))
                {
                    builder.Append("  exitScore: ");
                    builder.AppendLine($"'{ExitScore.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnableEarlyTermination), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableEarlyTermination: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnableEarlyTermination))
                {
                    builder.Append("  enableEarlyTermination: ");
                    var boolValue = EnableEarlyTermination.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<TableVerticalLimitSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support writing '{options.Format}' format.");
            }
        }

        TableVerticalLimitSettings IPersistableModel<TableVerticalLimitSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTableVerticalLimitSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TableVerticalLimitSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TableVerticalLimitSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
