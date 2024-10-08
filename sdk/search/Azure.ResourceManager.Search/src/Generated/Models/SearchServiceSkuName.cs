// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The SKU of the search service. Valid values include: 'free': Shared service. 'basic': Dedicated service with up to 3 replicas. 'standard': Dedicated service with up to 12 partitions and 12 replicas. 'standard2': Similar to standard, but with more capacity per search unit. 'standard3': The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). 'storage_optimized_l1': Supports 1TB per partition, up to 12 partitions. 'storage_optimized_l2': Supports 2TB per partition, up to 12 partitions.'. </summary>
    public readonly partial struct SearchServiceSkuName : IEquatable<SearchServiceSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchServiceSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchServiceSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "free";
        private const string BasicValue = "basic";
        private const string StandardValue = "standard";
        private const string Standard2Value = "standard2";
        private const string Standard3Value = "standard3";
        private const string StorageOptimizedL1Value = "storage_optimized_l1";
        private const string StorageOptimizedL2Value = "storage_optimized_l2";

        /// <summary> Free tier, with no SLA guarantees and a subset of the features offered on billable tiers. </summary>
        public static SearchServiceSkuName Free { get; } = new SearchServiceSkuName(FreeValue);
        /// <summary> Billable tier for a dedicated service having up to 3 replicas. </summary>
        public static SearchServiceSkuName Basic { get; } = new SearchServiceSkuName(BasicValue);
        /// <summary> Billable tier for a dedicated service having up to 12 partitions and 12 replicas. </summary>
        public static SearchServiceSkuName Standard { get; } = new SearchServiceSkuName(StandardValue);
        /// <summary> Similar to 'standard', but with more capacity per search unit. </summary>
        public static SearchServiceSkuName Standard2 { get; } = new SearchServiceSkuName(Standard2Value);
        /// <summary> The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). </summary>
        public static SearchServiceSkuName Standard3 { get; } = new SearchServiceSkuName(Standard3Value);
        /// <summary> Billable tier for a dedicated service that supports 1TB per partition, up to 12 partitions. </summary>
        public static SearchServiceSkuName StorageOptimizedL1 { get; } = new SearchServiceSkuName(StorageOptimizedL1Value);
        /// <summary> Billable tier for a dedicated service that supports 2TB per partition, up to 12 partitions. </summary>
        public static SearchServiceSkuName StorageOptimizedL2 { get; } = new SearchServiceSkuName(StorageOptimizedL2Value);
        /// <summary> Determines if two <see cref="SearchServiceSkuName"/> values are the same. </summary>
        public static bool operator ==(SearchServiceSkuName left, SearchServiceSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchServiceSkuName"/> values are not the same. </summary>
        public static bool operator !=(SearchServiceSkuName left, SearchServiceSkuName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SearchServiceSkuName"/>. </summary>
        public static implicit operator SearchServiceSkuName(string value) => new SearchServiceSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchServiceSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchServiceSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
