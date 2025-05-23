// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class MachineLearningStudioInputs : IUtf8JsonSerializable, IJsonModel<MachineLearningStudioInputs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningStudioInputs>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningStudioInputs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStudioInputs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningStudioInputs)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(ColumnNames))
            {
                writer.WritePropertyName("columnNames"u8);
                writer.WriteStartArray();
                foreach (var item in ColumnNames)
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

        MachineLearningStudioInputs IJsonModel<MachineLearningStudioInputs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStudioInputs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningStudioInputs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningStudioInputs(document.RootElement, options);
        }

        internal static MachineLearningStudioInputs DeserializeMachineLearningStudioInputs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<MachineLearningStudioInputColumn> columnNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("columnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningStudioInputColumn> array = new List<MachineLearningStudioInputColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningStudioInputColumn.DeserializeMachineLearningStudioInputColumn(item, options));
                    }
                    columnNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningStudioInputs(name, columnNames ?? new ChangeTrackingList<MachineLearningStudioInputColumn>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningStudioInputs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStudioInputs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStreamAnalyticsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningStudioInputs)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningStudioInputs IPersistableModel<MachineLearningStudioInputs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningStudioInputs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningStudioInputs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningStudioInputs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningStudioInputs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
