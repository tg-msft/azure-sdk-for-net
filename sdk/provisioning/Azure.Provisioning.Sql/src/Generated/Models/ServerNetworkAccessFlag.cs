// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.Sql;

/// <summary>
/// Whether or not public endpoint access is allowed for this server.  Value is
/// optional but if passed in, must be &apos;Enabled&apos; or
/// &apos;Disabled&apos; or &apos;SecuredByPerimeter&apos;.
/// </summary>
public enum ServerNetworkAccessFlag
{
    /// <summary>
    /// Enabled.
    /// </summary>
    Enabled,

    /// <summary>
    /// Disabled.
    /// </summary>
    Disabled,

    /// <summary>
    /// SecuredByPerimeter.
    /// </summary>
    SecuredByPerimeter,
}
