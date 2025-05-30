// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class TargetCopySetting : IUtf8JsonSerializable, IJsonModel<TargetCopySetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TargetCopySetting>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TargetCopySetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetCopySetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetCopySetting)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("copyAfter"u8);
            writer.WriteObjectValue(CopyAfter, options);
            writer.WritePropertyName("dataStore"u8);
            writer.WriteObjectValue(DataStore, options);
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

        TargetCopySetting IJsonModel<TargetCopySetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetCopySetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetCopySetting)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetCopySetting(document.RootElement, options);
        }

        internal static TargetCopySetting DeserializeTargetCopySetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupCopySetting copyAfter = default;
            DataStoreInfoBase dataStore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyAfter"u8))
                {
                    copyAfter = DataProtectionBackupCopySetting.DeserializeDataProtectionBackupCopySetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataStore"u8))
                {
                    dataStore = DataStoreInfoBase.DeserializeDataStoreInfoBase(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TargetCopySetting(copyAfter, dataStore, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TargetCopySetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetCopySetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataProtectionBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TargetCopySetting)} does not support writing '{options.Format}' format.");
            }
        }

        TargetCopySetting IPersistableModel<TargetCopySetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetCopySetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTargetCopySetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TargetCopySetting)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TargetCopySetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
