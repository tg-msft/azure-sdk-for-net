// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Dapr component metadata.
/// </summary>
public partial class ContainerAppDaprMetadata : ProvisionableConstruct
{
    /// <summary>
    /// Metadata property name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Metadata property value.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Name of the Dapr Component secret from which to pull the metadata
    /// property value.
    /// </summary>
    public BicepValue<string> SecretRef { get => _secretRef; set => _secretRef.Assign(value); }
    private readonly BicepValue<string> _secretRef;

    /// <summary>
    /// Creates a new ContainerAppDaprMetadata.
    /// </summary>
    public ContainerAppDaprMetadata()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
        _secretRef = BicepValue<string>.DefineProperty(this, "SecretRef", ["secretRef"]);
    }
}
