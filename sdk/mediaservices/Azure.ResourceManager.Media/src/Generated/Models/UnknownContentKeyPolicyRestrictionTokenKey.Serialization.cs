// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class UnknownContentKeyPolicyRestrictionTokenKey : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyRestrictionTokenKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyRestrictionTokenKey>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContentKeyPolicyRestrictionTokenKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ContentKeyPolicyRestrictionTokenKey IJsonModel<ContentKeyPolicyRestrictionTokenKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyRestrictionTokenKey(document.RootElement, options);
        }

        internal static UnknownContentKeyPolicyRestrictionTokenKey DeserializeUnknownContentKeyPolicyRestrictionTokenKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownContentKeyPolicyRestrictionTokenKey(odataType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMediaContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicyRestrictionTokenKey IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContentKeyPolicyRestrictionTokenKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
