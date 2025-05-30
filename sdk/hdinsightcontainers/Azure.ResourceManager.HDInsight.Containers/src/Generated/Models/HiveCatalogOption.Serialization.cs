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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HiveCatalogOption : IUtf8JsonSerializable, IJsonModel<HiveCatalogOption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HiveCatalogOption>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HiveCatalogOption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("catalogName"u8);
            writer.WriteStringValue(CatalogName);
            if (Optional.IsDefined(MetastoreDBConnectionAuthenticationMode))
            {
                writer.WritePropertyName("metastoreDbConnectionAuthenticationMode"u8);
                writer.WriteStringValue(MetastoreDBConnectionAuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(MetastoreDBConnectionPasswordSecret))
            {
                writer.WritePropertyName("metastoreDbConnectionPasswordSecret"u8);
                writer.WriteStringValue(MetastoreDBConnectionPasswordSecret);
            }
            writer.WritePropertyName("metastoreDbConnectionURL"u8);
            writer.WriteStringValue(MetastoreDBConnectionUriString);
            if (Optional.IsDefined(MetastoreDBConnectionUserName))
            {
                writer.WritePropertyName("metastoreDbConnectionUserName"u8);
                writer.WriteStringValue(MetastoreDBConnectionUserName);
            }
            writer.WritePropertyName("metastoreWarehouseDir"u8);
            writer.WriteStringValue(MetastoreWarehouseDir);
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

        HiveCatalogOption IJsonModel<HiveCatalogOption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHiveCatalogOption(document.RootElement, options);
        }

        internal static HiveCatalogOption DeserializeHiveCatalogOption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string catalogName = default;
            MetastoreDBConnectionAuthenticationMode? metastoreDBConnectionAuthenticationMode = default;
            string metastoreDBConnectionPasswordSecret = default;
            string metastoreDBConnectionURL = default;
            string metastoreDBConnectionUserName = default;
            string metastoreWarehouseDir = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogName"u8))
                {
                    catalogName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionAuthenticationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metastoreDBConnectionAuthenticationMode = new MetastoreDBConnectionAuthenticationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionPasswordSecret"u8))
                {
                    metastoreDBConnectionPasswordSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionURL"u8))
                {
                    metastoreDBConnectionURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionUserName"u8))
                {
                    metastoreDBConnectionUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreWarehouseDir"u8))
                {
                    metastoreWarehouseDir = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HiveCatalogOption(
                catalogName,
                metastoreDBConnectionAuthenticationMode,
                metastoreDBConnectionPasswordSecret,
                metastoreDBConnectionURL,
                metastoreDBConnectionUserName,
                metastoreWarehouseDir,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CatalogName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  catalogName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CatalogName))
                {
                    builder.Append("  catalogName: ");
                    if (CatalogName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CatalogName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CatalogName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetastoreDBConnectionAuthenticationMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metastoreDbConnectionAuthenticationMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetastoreDBConnectionAuthenticationMode))
                {
                    builder.Append("  metastoreDbConnectionAuthenticationMode: ");
                    builder.AppendLine($"'{MetastoreDBConnectionAuthenticationMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetastoreDBConnectionPasswordSecret), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metastoreDbConnectionPasswordSecret: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetastoreDBConnectionPasswordSecret))
                {
                    builder.Append("  metastoreDbConnectionPasswordSecret: ");
                    if (MetastoreDBConnectionPasswordSecret.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MetastoreDBConnectionPasswordSecret}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MetastoreDBConnectionPasswordSecret}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetastoreDBConnectionUriString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metastoreDbConnectionURL: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetastoreDBConnectionUriString))
                {
                    builder.Append("  metastoreDbConnectionURL: ");
                    if (MetastoreDBConnectionUriString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MetastoreDBConnectionUriString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MetastoreDBConnectionUriString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetastoreDBConnectionUserName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metastoreDbConnectionUserName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetastoreDBConnectionUserName))
                {
                    builder.Append("  metastoreDbConnectionUserName: ");
                    if (MetastoreDBConnectionUserName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MetastoreDBConnectionUserName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MetastoreDBConnectionUserName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetastoreWarehouseDir), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metastoreWarehouseDir: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetastoreWarehouseDir))
                {
                    builder.Append("  metastoreWarehouseDir: ");
                    if (MetastoreWarehouseDir.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MetastoreWarehouseDir}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MetastoreWarehouseDir}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HiveCatalogOption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHDInsightContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support writing '{options.Format}' format.");
            }
        }

        HiveCatalogOption IPersistableModel<HiveCatalogOption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HiveCatalogOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHiveCatalogOption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HiveCatalogOption)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HiveCatalogOption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
