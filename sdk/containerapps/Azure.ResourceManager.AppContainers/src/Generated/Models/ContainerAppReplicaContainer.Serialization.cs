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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppReplicaContainer : IUtf8JsonSerializable, IJsonModel<ContainerAppReplicaContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppReplicaContainer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppReplicaContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppReplicaContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppReplicaContainer)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteStringValue(ContainerId);
            }
            if (Optional.IsDefined(IsReady))
            {
                writer.WritePropertyName("ready"u8);
                writer.WriteBooleanValue(IsReady.Value);
            }
            if (Optional.IsDefined(IsStarted))
            {
                writer.WritePropertyName("started"u8);
                writer.WriteBooleanValue(IsStarted.Value);
            }
            if (Optional.IsDefined(RestartCount))
            {
                writer.WritePropertyName("restartCount"u8);
                writer.WriteNumberValue(RestartCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RunningState))
            {
                writer.WritePropertyName("runningState"u8);
                writer.WriteStringValue(RunningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RunningStateDetails))
            {
                writer.WritePropertyName("runningStateDetails"u8);
                writer.WriteStringValue(RunningStateDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(LogStreamEndpoint))
            {
                writer.WritePropertyName("logStreamEndpoint"u8);
                writer.WriteStringValue(LogStreamEndpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(ExecEndpoint))
            {
                writer.WritePropertyName("execEndpoint"u8);
                writer.WriteStringValue(ExecEndpoint);
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

        ContainerAppReplicaContainer IJsonModel<ContainerAppReplicaContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppReplicaContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppReplicaContainer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppReplicaContainer(document.RootElement, options);
        }

        internal static ContainerAppReplicaContainer DeserializeContainerAppReplicaContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string containerId = default;
            bool? ready = default;
            bool? started = default;
            int? restartCount = default;
            ContainerAppContainerRunningState? runningState = default;
            string runningStateDetails = default;
            string logStreamEndpoint = default;
            string execEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    containerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ready"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ready = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("started"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    started = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restartCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restartCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runningState = new ContainerAppContainerRunningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runningStateDetails"u8))
                {
                    runningStateDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStreamEndpoint"u8))
                {
                    logStreamEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("execEndpoint"u8))
                {
                    execEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppReplicaContainer(
                name,
                containerId,
                ready,
                started,
                restartCount,
                runningState,
                runningStateDetails,
                logStreamEndpoint,
                execEndpoint,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContainerId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  containerId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContainerId))
                {
                    builder.Append("  containerId: ");
                    if (ContainerId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContainerId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContainerId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsReady), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ready: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsReady))
                {
                    builder.Append("  ready: ");
                    var boolValue = IsReady.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStarted), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  started: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStarted))
                {
                    builder.Append("  started: ");
                    var boolValue = IsStarted.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RestartCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  restartCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RestartCount))
                {
                    builder.Append("  restartCount: ");
                    builder.AppendLine($"{RestartCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  runningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunningState))
                {
                    builder.Append("  runningState: ");
                    builder.AppendLine($"'{RunningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunningStateDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  runningStateDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunningStateDetails))
                {
                    builder.Append("  runningStateDetails: ");
                    if (RunningStateDetails.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RunningStateDetails}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RunningStateDetails}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogStreamEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logStreamEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogStreamEndpoint))
                {
                    builder.Append("  logStreamEndpoint: ");
                    if (LogStreamEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LogStreamEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LogStreamEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExecEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  execEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExecEndpoint))
                {
                    builder.Append("  execEndpoint: ");
                    if (ExecEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ExecEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ExecEndpoint}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppReplicaContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppReplicaContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppReplicaContainer)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppReplicaContainer IPersistableModel<ContainerAppReplicaContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppReplicaContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppReplicaContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppReplicaContainer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppReplicaContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
