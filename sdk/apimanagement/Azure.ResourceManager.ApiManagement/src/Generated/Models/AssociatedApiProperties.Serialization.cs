// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AssociatedApiProperties : IUtf8JsonSerializable, IJsonModel<AssociatedApiProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssociatedApiProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssociatedApiProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssociatedApiProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssociatedApiProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUrl"u8);
                writer.WriteStringValue(ServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
        }

        AssociatedApiProperties IJsonModel<AssociatedApiProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssociatedApiProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssociatedApiProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssociatedApiProperties(document.RootElement, options);
        }

        internal static AssociatedApiProperties DeserializeAssociatedApiProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            Uri serviceUri = default;
            string path = default;
            IReadOnlyList<ApiOperationInvokableProtocol> protocols = default;
            string description = default;
            AuthenticationSettingsContract authenticationSettings = default;
            SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default;
            ApiType? type = default;
            string apiRevision = default;
            string apiVersion = default;
            bool? isCurrent = default;
            bool? isOnline = default;
            string apiRevisionDescription = default;
            string apiVersionDescription = default;
            ResourceIdentifier apiVersionSetId = default;
            bool? subscriptionRequired = default;
            string termsOfServiceUri = default;
            ApiContactInformation contact = default;
            ApiLicenseInformation license = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiOperationInvokableProtocol> array = new List<ApiOperationInvokableProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApiOperationInvokableProtocol(item.GetString()));
                    }
                    protocols = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subscriptionKeyParameterNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ApiType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiRevision"u8))
                {
                    apiRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCurrent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOnline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("apiRevisionDescription"u8))
                {
                    apiRevisionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionDescription"u8))
                {
                    apiVersionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiVersionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("termsOfServiceUrl"u8))
                {
                    termsOfServiceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contact = ApiContactInformation.DeserializeApiContactInformation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("license"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    license = ApiLicenseInformation.DeserializeApiLicenseInformation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssociatedApiProperties(
                description,
                authenticationSettings,
                subscriptionKeyParameterNames,
                type,
                apiRevision,
                apiVersion,
                isCurrent,
                isOnline,
                apiRevisionDescription,
                apiVersionDescription,
                apiVersionSetId,
                subscriptionRequired,
                termsOfServiceUri,
                contact,
                license,
                serializedAdditionalRawData,
                id,
                name,
                serviceUri,
                path,
                protocols ?? new ChangeTrackingList<ApiOperationInvokableProtocol>());
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    if (Id.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Id}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Id}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serviceUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServiceUri))
                {
                    builder.Append("  serviceUrl: ");
                    builder.AppendLine($"'{ServiceUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Path), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  path: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Path))
                {
                    builder.Append("  path: ");
                    if (Path.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Path}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Path}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Protocols), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  protocols: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Protocols))
                {
                    if (Protocols.Any())
                    {
                        builder.Append("  protocols: ");
                        builder.AppendLine("[");
                        foreach (var item in Protocols)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthenticationSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authenticationSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AuthenticationSettings))
                {
                    builder.Append("  authenticationSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AuthenticationSettings, options, 2, false, "  authenticationSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubscriptionKeyParameterNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subscriptionKeyParameterNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubscriptionKeyParameterNames))
                {
                    builder.Append("  subscriptionKeyParameterNames: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SubscriptionKeyParameterNames, options, 2, false, "  subscriptionKeyParameterNames: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiRevision), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiRevision: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiRevision))
                {
                    builder.Append("  apiRevision: ");
                    if (ApiRevision.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiRevision}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiRevision}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersion))
                {
                    builder.Append("  apiVersion: ");
                    if (ApiVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsCurrent), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isCurrent: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsCurrent))
                {
                    builder.Append("  isCurrent: ");
                    var boolValue = IsCurrent.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsOnline), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isOnline: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsOnline))
                {
                    builder.Append("  isOnline: ");
                    var boolValue = IsOnline.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiRevisionDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiRevisionDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiRevisionDescription))
                {
                    builder.Append("  apiRevisionDescription: ");
                    if (ApiRevisionDescription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiRevisionDescription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiRevisionDescription}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiVersionDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiVersionDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersionDescription))
                {
                    builder.Append("  apiVersionDescription: ");
                    if (ApiVersionDescription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiVersionDescription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiVersionDescription}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiVersionSetId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiVersionSetId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersionSetId))
                {
                    builder.Append("  apiVersionSetId: ");
                    builder.AppendLine($"'{ApiVersionSetId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSubscriptionRequired), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subscriptionRequired: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSubscriptionRequired))
                {
                    builder.Append("  subscriptionRequired: ");
                    var boolValue = IsSubscriptionRequired.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TermsOfServiceLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  termsOfServiceUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TermsOfServiceLink))
                {
                    builder.Append("  termsOfServiceUrl: ");
                    if (TermsOfServiceLink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TermsOfServiceLink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TermsOfServiceLink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Contact), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contact: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Contact))
                {
                    builder.Append("  contact: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Contact, options, 2, false, "  contact: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(License), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  license: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(License))
                {
                    builder.Append("  license: ");
                    BicepSerializationHelpers.AppendChildObject(builder, License, options, 2, false, "  license: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AssociatedApiProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssociatedApiProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiManagementContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AssociatedApiProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AssociatedApiProperties IPersistableModel<AssociatedApiProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssociatedApiProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAssociatedApiProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssociatedApiProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssociatedApiProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
