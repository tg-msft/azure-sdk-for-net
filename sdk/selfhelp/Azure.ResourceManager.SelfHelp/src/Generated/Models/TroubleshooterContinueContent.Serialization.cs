// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class TroubleshooterContinueContent : IUtf8JsonSerializable, IJsonModel<TroubleshooterContinueContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TroubleshooterContinueContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TroubleshooterContinueContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterContinueContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TroubleshooterContinueContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(StepId))
            {
                writer.WritePropertyName("stepId"u8);
                writer.WriteStringValue(StepId);
            }
            if (Optional.IsCollectionDefined(Responses))
            {
                writer.WritePropertyName("responses"u8);
                writer.WriteStartArray();
                foreach (var item in Responses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        TroubleshooterContinueContent IJsonModel<TroubleshooterContinueContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterContinueContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TroubleshooterContinueContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTroubleshooterContinueContent(document.RootElement, options);
        }

        internal static TroubleshooterContinueContent DeserializeTroubleshooterContinueContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string stepId = default;
            IList<TroubleshooterResult> responses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stepId"u8))
                {
                    stepId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TroubleshooterResult> array = new List<TroubleshooterResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TroubleshooterResult.DeserializeTroubleshooterResult(item, options));
                    }
                    responses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TroubleshooterContinueContent(stepId, responses ?? new ChangeTrackingList<TroubleshooterResult>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TroubleshooterContinueContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterContinueContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSelfHelpContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TroubleshooterContinueContent)} does not support writing '{options.Format}' format.");
            }
        }

        TroubleshooterContinueContent IPersistableModel<TroubleshooterContinueContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterContinueContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTroubleshooterContinueContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TroubleshooterContinueContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TroubleshooterContinueContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
