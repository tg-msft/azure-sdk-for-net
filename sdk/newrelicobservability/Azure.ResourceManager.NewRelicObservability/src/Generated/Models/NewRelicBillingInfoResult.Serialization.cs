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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicBillingInfoResult : IUtf8JsonSerializable, IJsonModel<NewRelicBillingInfoResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicBillingInfoResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NewRelicBillingInfoResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicBillingInfoResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicBillingInfoResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MarketplaceSaasInfo))
            {
                writer.WritePropertyName("marketplaceSaasInfo"u8);
                writer.WriteObjectValue(MarketplaceSaasInfo, options);
            }
            if (Optional.IsDefined(PartnerBillingEntity))
            {
                writer.WritePropertyName("partnerBillingEntity"u8);
                writer.WriteObjectValue(PartnerBillingEntity, options);
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

        NewRelicBillingInfoResult IJsonModel<NewRelicBillingInfoResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicBillingInfoResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicBillingInfoResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicBillingInfoResult(document.RootElement, options);
        }

        internal static NewRelicBillingInfoResult DeserializeNewRelicBillingInfoResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MarketplaceSaaSInfo marketplaceSaasInfo = default;
            PartnerBillingEntity partnerBillingEntity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplaceSaasInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSaasInfo = MarketplaceSaaSInfo.DeserializeMarketplaceSaaSInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("partnerBillingEntity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerBillingEntity = PartnerBillingEntity.DeserializePartnerBillingEntity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NewRelicBillingInfoResult(marketplaceSaasInfo, partnerBillingEntity, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MarketplaceSaasInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  marketplaceSaasInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MarketplaceSaasInfo))
                {
                    builder.Append("  marketplaceSaasInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, MarketplaceSaasInfo, options, 2, false, "  marketplaceSaasInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartnerBillingEntity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partnerBillingEntity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartnerBillingEntity))
                {
                    builder.Append("  partnerBillingEntity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PartnerBillingEntity, options, 2, false, "  partnerBillingEntity: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NewRelicBillingInfoResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicBillingInfoResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNewRelicObservabilityContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicBillingInfoResult)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicBillingInfoResult IPersistableModel<NewRelicBillingInfoResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicBillingInfoResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNewRelicBillingInfoResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicBillingInfoResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicBillingInfoResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
