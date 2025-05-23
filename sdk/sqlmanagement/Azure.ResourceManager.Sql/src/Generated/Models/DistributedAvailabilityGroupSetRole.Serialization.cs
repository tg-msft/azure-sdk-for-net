// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class DistributedAvailabilityGroupSetRole : IUtf8JsonSerializable, IJsonModel<DistributedAvailabilityGroupSetRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DistributedAvailabilityGroupSetRole>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DistributedAvailabilityGroupSetRole>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupSetRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DistributedAvailabilityGroupSetRole)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("instanceRole"u8);
            writer.WriteStringValue(InstanceRole.ToString());
            writer.WritePropertyName("roleChangeType"u8);
            writer.WriteStringValue(RoleChangeType.ToString());
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

        DistributedAvailabilityGroupSetRole IJsonModel<DistributedAvailabilityGroupSetRole>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupSetRole>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DistributedAvailabilityGroupSetRole)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDistributedAvailabilityGroupSetRole(document.RootElement, options);
        }

        internal static DistributedAvailabilityGroupSetRole DeserializeDistributedAvailabilityGroupSetRole(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DistributedAvailabilityGroupManagedInstanceRole instanceRole = default;
            DistributedAvailabilityGroupRoleChangeType roleChangeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceRole"u8))
                {
                    instanceRole = new DistributedAvailabilityGroupManagedInstanceRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleChangeType"u8))
                {
                    roleChangeType = new DistributedAvailabilityGroupRoleChangeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DistributedAvailabilityGroupSetRole(instanceRole, roleChangeType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DistributedAvailabilityGroupSetRole>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupSetRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSqlContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DistributedAvailabilityGroupSetRole)} does not support writing '{options.Format}' format.");
            }
        }

        DistributedAvailabilityGroupSetRole IPersistableModel<DistributedAvailabilityGroupSetRole>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupSetRole>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDistributedAvailabilityGroupSetRole(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DistributedAvailabilityGroupSetRole)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DistributedAvailabilityGroupSetRole>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
