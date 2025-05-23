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
    public partial class CronTrigger : IUtf8JsonSerializable, IJsonModel<CronTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CronTrigger>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CronTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CronTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CronTrigger)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
        }

        CronTrigger IJsonModel<CronTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CronTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CronTrigger)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCronTrigger(document.RootElement, options);
        }

        internal static CronTrigger DeserializeCronTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string expression = default;
            TriggerType triggerType = default;
            string endTime = default;
            string startTime = default;
            string timeZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    triggerType = new TriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CronTrigger(
                triggerType,
                endTime,
                startTime,
                timeZone,
                serializedAdditionalRawData,
                expression);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Expression), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expression: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Expression))
                {
                    builder.Append("  expression: ");
                    if (Expression.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Expression}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Expression}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TriggerType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  triggerType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  triggerType: ");
                builder.AppendLine($"'{TriggerType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndTime))
                {
                    builder.Append("  endTime: ");
                    if (EndTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartTime))
                {
                    builder.Append("  startTime: ");
                    if (StartTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StartTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StartTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeZone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeZone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeZone))
                {
                    builder.Append("  timeZone: ");
                    if (TimeZone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TimeZone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TimeZone}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CronTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CronTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CronTrigger)} does not support writing '{options.Format}' format.");
            }
        }

        CronTrigger IPersistableModel<CronTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CronTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCronTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CronTrigger)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CronTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
