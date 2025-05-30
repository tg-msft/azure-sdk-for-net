// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MongoCluster.Models
{
    public partial class MongoClusterFirewallRuleProperties : IUtf8JsonSerializable, IJsonModel<MongoClusterFirewallRuleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoClusterFirewallRuleProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MongoClusterFirewallRuleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterFirewallRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoClusterFirewallRuleProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("startIpAddress"u8);
            writer.WriteStringValue(StartIPAddress);
            writer.WritePropertyName("endIpAddress"u8);
            writer.WriteStringValue(EndIPAddress);
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

        MongoClusterFirewallRuleProperties IJsonModel<MongoClusterFirewallRuleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterFirewallRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoClusterFirewallRuleProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoClusterFirewallRuleProperties(document.RootElement, options);
        }

        internal static MongoClusterFirewallRuleProperties DeserializeMongoClusterFirewallRuleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MongoClusterProvisioningState? provisioningState = default;
            string startIPAddress = default;
            string endIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MongoClusterProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startIpAddress"u8))
                {
                    startIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endIpAddress"u8))
                {
                    endIPAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MongoClusterFirewallRuleProperties(provisioningState, startIPAddress, endIPAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoClusterFirewallRuleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterFirewallRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMongoClusterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MongoClusterFirewallRuleProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MongoClusterFirewallRuleProperties IPersistableModel<MongoClusterFirewallRuleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterFirewallRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMongoClusterFirewallRuleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoClusterFirewallRuleProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoClusterFirewallRuleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
