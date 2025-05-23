// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasRelationshipAttributeDef : IUtf8JsonSerializable, IJsonModel<AtlasRelationshipAttributeDef>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasRelationshipAttributeDef>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtlasRelationshipAttributeDef>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasRelationshipAttributeDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasRelationshipAttributeDef)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Cardinality))
            {
                writer.WritePropertyName("cardinality"u8);
                writer.WriteStringValue(Cardinality.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Constraints))
            {
                writer.WritePropertyName("constraints"u8);
                writer.WriteStartArray();
                foreach (var item in Constraints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IncludeInNotification))
            {
                writer.WritePropertyName("includeInNotification"u8);
                writer.WriteBooleanValue(IncludeInNotification.Value);
            }
            if (Optional.IsDefined(IsIndexable))
            {
                writer.WritePropertyName("isIndexable"u8);
                writer.WriteBooleanValue(IsIndexable.Value);
            }
            if (Optional.IsDefined(IsOptional))
            {
                writer.WritePropertyName("isOptional"u8);
                writer.WriteBooleanValue(IsOptional.Value);
            }
            if (Optional.IsDefined(IsUnique))
            {
                writer.WritePropertyName("isUnique"u8);
                writer.WriteBooleanValue(IsUnique.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TypeName))
            {
                writer.WritePropertyName("typeName"u8);
                writer.WriteStringValue(TypeName);
            }
            if (Optional.IsDefined(ValuesMaxCount))
            {
                writer.WritePropertyName("valuesMaxCount"u8);
                writer.WriteNumberValue(ValuesMaxCount.Value);
            }
            if (Optional.IsDefined(ValuesMinCount))
            {
                writer.WritePropertyName("valuesMinCount"u8);
                writer.WriteNumberValue(ValuesMinCount.Value);
            }
            if (Optional.IsDefined(IsLegacyAttribute))
            {
                writer.WritePropertyName("isLegacyAttribute"u8);
                writer.WriteBooleanValue(IsLegacyAttribute.Value);
            }
            if (Optional.IsDefined(RelationshipTypeName))
            {
                writer.WritePropertyName("relationshipTypeName"u8);
                writer.WriteStringValue(RelationshipTypeName);
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

        AtlasRelationshipAttributeDef IJsonModel<AtlasRelationshipAttributeDef>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasRelationshipAttributeDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasRelationshipAttributeDef)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasRelationshipAttributeDef(document.RootElement, options);
        }

        internal static AtlasRelationshipAttributeDef DeserializeAtlasRelationshipAttributeDef(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CardinalityValue? cardinality = default;
            IList<AtlasConstraintDef> constraints = default;
            string defaultValue = default;
            string description = default;
            bool? includeInNotification = default;
            bool? isIndexable = default;
            bool? isOptional = default;
            bool? isUnique = default;
            string name = default;
            IDictionary<string, string> options0 = default;
            string typeName = default;
            int? valuesMaxCount = default;
            int? valuesMinCount = default;
            bool? isLegacyAttribute = default;
            string relationshipTypeName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cardinality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cardinality = new CardinalityValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("constraints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasConstraintDef> array = new List<AtlasConstraintDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasConstraintDef.DeserializeAtlasConstraintDef(item, options));
                    }
                    constraints = array;
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includeInNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeInNotification = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isIndexable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isIndexable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOptional"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isUnique"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isUnique = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    options0 = dictionary;
                    continue;
                }
                if (property.NameEquals("typeName"u8))
                {
                    typeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valuesMaxCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valuesMaxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("valuesMinCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valuesMinCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isLegacyAttribute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLegacyAttribute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("relationshipTypeName"u8))
                {
                    relationshipTypeName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AtlasRelationshipAttributeDef(
                cardinality,
                constraints ?? new ChangeTrackingList<AtlasConstraintDef>(),
                defaultValue,
                description,
                includeInNotification,
                isIndexable,
                isOptional,
                isUnique,
                name,
                options0 ?? new ChangeTrackingDictionary<string, string>(),
                typeName,
                valuesMaxCount,
                valuesMinCount,
                isLegacyAttribute,
                relationshipTypeName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasRelationshipAttributeDef>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasRelationshipAttributeDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAnalyticsPurviewDataMapContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AtlasRelationshipAttributeDef)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasRelationshipAttributeDef IPersistableModel<AtlasRelationshipAttributeDef>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasRelationshipAttributeDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAtlasRelationshipAttributeDef(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasRelationshipAttributeDef)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasRelationshipAttributeDef>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasRelationshipAttributeDef FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAtlasRelationshipAttributeDef(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
