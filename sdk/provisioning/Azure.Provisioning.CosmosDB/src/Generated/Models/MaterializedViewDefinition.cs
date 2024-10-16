// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Materialized View definition for the container.
/// </summary>
public partial class MaterializedViewDefinition : ProvisionableConstruct
{
    /// <summary>
    /// An unique identifier for the source collection. This is a system
    /// generated property.
    /// </summary>
    public BicepValue<string> SourceCollectionRid { get => _sourceCollectionRid; }
    private readonly BicepValue<string> _sourceCollectionRid;

    /// <summary>
    /// The name of the source container on which the Materialized View will be
    /// created.
    /// </summary>
    public BicepValue<string> SourceCollectionId { get => _sourceCollectionId; set => _sourceCollectionId.Assign(value); }
    private readonly BicepValue<string> _sourceCollectionId;

    /// <summary>
    /// The definition should be an SQL query which would be used to fetch data
    /// from the source container to populate into the Materialized View
    /// container.
    /// </summary>
    public BicepValue<string> Definition { get => _definition; set => _definition.Assign(value); }
    private readonly BicepValue<string> _definition;

    /// <summary>
    /// Creates a new MaterializedViewDefinition.
    /// </summary>
    public MaterializedViewDefinition()
    {
        _sourceCollectionRid = BicepValue<string>.DefineProperty(this, "SourceCollectionRid", ["sourceCollectionRid"], isOutput: true);
        _sourceCollectionId = BicepValue<string>.DefineProperty(this, "SourceCollectionId", ["sourceCollectionId"]);
        _definition = BicepValue<string>.DefineProperty(this, "Definition", ["definition"]);
    }
}
