// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// ContainerRegistryWebhook.
/// </summary>
public partial class ContainerRegistryWebhook : ProvisionableResource
{
    /// <summary>
    /// The name of the webhook.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The location of the webhook. This cannot be changed after the resource
    /// is created.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The list of actions that trigger the webhook to post notifications.
    /// </summary>
    public BicepList<ContainerRegistryWebhookAction> Actions { get => _actions; set => _actions.Assign(value); }
    private readonly BicepList<ContainerRegistryWebhookAction> _actions;

    /// <summary>
    /// Custom headers that will be added to the webhook notifications.
    /// </summary>
    public BicepDictionary<string> CustomHeaders { get => _customHeaders; set => _customHeaders.Assign(value); }
    private readonly BicepDictionary<string> _customHeaders;

    /// <summary>
    /// The scope of repositories where the event can be triggered. For
    /// example, &apos;foo:*&apos; means events for all tags under repository
    /// &apos;foo&apos;. &apos;foo:bar&apos; means events for
    /// &apos;foo:bar&apos; only. &apos;foo&apos; is equivalent to
    /// &apos;foo:latest&apos;. Empty means all events.
    /// </summary>
    public BicepValue<string> Scope { get => _scope; set => _scope.Assign(value); }
    private readonly BicepValue<string> _scope;

    /// <summary>
    /// The service URI for the webhook to post notifications.
    /// </summary>
    public BicepValue<Uri> ServiceUri { get => _serviceUri; set => _serviceUri.Assign(value); }
    private readonly BicepValue<Uri> _serviceUri;

    /// <summary>
    /// The status of the webhook at the time the operation was called.
    /// </summary>
    public BicepValue<ContainerRegistryWebhookStatus> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<ContainerRegistryWebhookStatus> _status;

    /// <summary>
    /// The tags for the webhook.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The provisioning state of the webhook at the time the operation was
    /// called.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerRegistryProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerRegistryService.
    /// </summary>
    public ContainerRegistryService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerRegistryService> _parent;

    /// <summary>
    /// Creates a new ContainerRegistryWebhook.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryWebhook resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryWebhook.</param>
    public ContainerRegistryWebhook(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerRegistry/registries/webhooks", resourceVersion ?? "2023-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _actions = BicepList<ContainerRegistryWebhookAction>.DefineProperty(this, "Actions", ["properties", "actions"]);
        _customHeaders = BicepDictionary<string>.DefineProperty(this, "CustomHeaders", ["properties", "customHeaders"]);
        _scope = BicepValue<string>.DefineProperty(this, "Scope", ["properties", "scope"]);
        _serviceUri = BicepValue<Uri>.DefineProperty(this, "ServiceUri", ["properties", "serviceUri"]);
        _status = BicepValue<ContainerRegistryWebhookStatus>.DefineProperty(this, "Status", ["properties", "status"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<ContainerRegistryProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerRegistryService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerRegistryWebhook resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2019-05-01.
        /// </summary>
        public static readonly string V2019_05_01 = "2019-05-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryWebhook.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryWebhook resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryWebhook.</param>
    /// <returns>The existing ContainerRegistryWebhook resource.</returns>
    public static ContainerRegistryWebhook FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerRegistryWebhook resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 5, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers);
}
