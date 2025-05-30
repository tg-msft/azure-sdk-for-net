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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class SessionPoolLifecycleConfiguration : IUtf8JsonSerializable, IJsonModel<SessionPoolLifecycleConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SessionPoolLifecycleConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SessionPoolLifecycleConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionPoolLifecycleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionPoolLifecycleConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(LifecycleType))
            {
                writer.WritePropertyName("lifecycleType"u8);
                writer.WriteStringValue(LifecycleType.Value.ToString());
            }
            if (Optional.IsDefined(CooldownPeriodInSeconds))
            {
                writer.WritePropertyName("cooldownPeriodInSeconds"u8);
                writer.WriteNumberValue(CooldownPeriodInSeconds.Value);
            }
            if (Optional.IsDefined(MaxAlivePeriodInSeconds))
            {
                writer.WritePropertyName("maxAlivePeriodInSeconds"u8);
                writer.WriteNumberValue(MaxAlivePeriodInSeconds.Value);
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

        SessionPoolLifecycleConfiguration IJsonModel<SessionPoolLifecycleConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionPoolLifecycleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionPoolLifecycleConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSessionPoolLifecycleConfiguration(document.RootElement, options);
        }

        internal static SessionPoolLifecycleConfiguration DeserializeSessionPoolLifecycleConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SessionPoolLifecycleType? lifecycleType = default;
            int? cooldownPeriodInSeconds = default;
            int? maxAlivePeriodInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lifecycleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifecycleType = new SessionPoolLifecycleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cooldownPeriodInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cooldownPeriodInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxAlivePeriodInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAlivePeriodInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SessionPoolLifecycleConfiguration(lifecycleType, cooldownPeriodInSeconds, maxAlivePeriodInSeconds, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LifecycleType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lifecycleType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LifecycleType))
                {
                    builder.Append("  lifecycleType: ");
                    builder.AppendLine($"'{LifecycleType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CooldownPeriodInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cooldownPeriodInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CooldownPeriodInSeconds))
                {
                    builder.Append("  cooldownPeriodInSeconds: ");
                    builder.AppendLine($"{CooldownPeriodInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxAlivePeriodInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxAlivePeriodInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxAlivePeriodInSeconds))
                {
                    builder.Append("  maxAlivePeriodInSeconds: ");
                    builder.AppendLine($"{MaxAlivePeriodInSeconds.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SessionPoolLifecycleConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionPoolLifecycleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SessionPoolLifecycleConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        SessionPoolLifecycleConfiguration IPersistableModel<SessionPoolLifecycleConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionPoolLifecycleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSessionPoolLifecycleConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SessionPoolLifecycleConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SessionPoolLifecycleConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
