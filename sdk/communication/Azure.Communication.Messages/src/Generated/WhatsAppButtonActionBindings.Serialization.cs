// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Messages.Models.Channels
{
    public partial class WhatsAppButtonActionBindings : IUtf8JsonSerializable, IJsonModel<WhatsAppButtonActionBindings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WhatsAppButtonActionBindings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WhatsAppButtonActionBindings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppButtonActionBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatsAppButtonActionBindings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("content"u8);
            writer.WriteObjectValue(Content, options);
        }

        WhatsAppButtonActionBindings IJsonModel<WhatsAppButtonActionBindings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppButtonActionBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatsAppButtonActionBindings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWhatsAppButtonActionBindings(document.RootElement, options);
        }

        internal static WhatsAppButtonActionBindings DeserializeWhatsAppButtonActionBindings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ButtonSetContent content = default;
            MessageActionBindingKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    content = ButtonSetContent.DeserializeButtonSetContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MessageActionBindingKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WhatsAppButtonActionBindings(kind, serializedAdditionalRawData, content);
        }

        BinaryData IPersistableModel<WhatsAppButtonActionBindings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppButtonActionBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureCommunicationMessagesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(WhatsAppButtonActionBindings)} does not support writing '{options.Format}' format.");
            }
        }

        WhatsAppButtonActionBindings IPersistableModel<WhatsAppButtonActionBindings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppButtonActionBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWhatsAppButtonActionBindings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WhatsAppButtonActionBindings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WhatsAppButtonActionBindings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WhatsAppButtonActionBindings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeWhatsAppButtonActionBindings(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
