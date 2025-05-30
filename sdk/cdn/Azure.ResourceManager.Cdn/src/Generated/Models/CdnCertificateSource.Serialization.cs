// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnCertificateSource : IUtf8JsonSerializable, IJsonModel<CdnCertificateSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnCertificateSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CdnCertificateSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnCertificateSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnCertificateSource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("certificateType"u8);
            writer.WriteStringValue(CertificateType.ToString());
        }

        CdnCertificateSource IJsonModel<CdnCertificateSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnCertificateSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnCertificateSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnCertificateSource(document.RootElement, options);
        }

        internal static CdnCertificateSource DeserializeCdnCertificateSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CdnManagedCertificateType certificateType = default;
            CertificateSourceParametersType typeName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateType"u8))
                {
                    certificateType = new CdnManagedCertificateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new CertificateSourceParametersType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CdnCertificateSource(typeName, serializedAdditionalRawData, certificateType);
        }

        BinaryData IPersistableModel<CdnCertificateSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnCertificateSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CdnCertificateSource)} does not support writing '{options.Format}' format.");
            }
        }

        CdnCertificateSource IPersistableModel<CdnCertificateSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnCertificateSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCdnCertificateSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnCertificateSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnCertificateSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
