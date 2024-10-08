// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The recovery point type. </summary>
    public readonly partial struct MigrationRecoveryPointType : IEquatable<MigrationRecoveryPointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MigrationRecoveryPointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MigrationRecoveryPointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string ApplicationConsistentValue = "ApplicationConsistent";
        private const string CrashConsistentValue = "CrashConsistent";

        /// <summary> NotSpecified. </summary>
        public static MigrationRecoveryPointType NotSpecified { get; } = new MigrationRecoveryPointType(NotSpecifiedValue);
        /// <summary> ApplicationConsistent. </summary>
        public static MigrationRecoveryPointType ApplicationConsistent { get; } = new MigrationRecoveryPointType(ApplicationConsistentValue);
        /// <summary> CrashConsistent. </summary>
        public static MigrationRecoveryPointType CrashConsistent { get; } = new MigrationRecoveryPointType(CrashConsistentValue);
        /// <summary> Determines if two <see cref="MigrationRecoveryPointType"/> values are the same. </summary>
        public static bool operator ==(MigrationRecoveryPointType left, MigrationRecoveryPointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MigrationRecoveryPointType"/> values are not the same. </summary>
        public static bool operator !=(MigrationRecoveryPointType left, MigrationRecoveryPointType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MigrationRecoveryPointType"/>. </summary>
        public static implicit operator MigrationRecoveryPointType(string value) => new MigrationRecoveryPointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MigrationRecoveryPointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MigrationRecoveryPointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
