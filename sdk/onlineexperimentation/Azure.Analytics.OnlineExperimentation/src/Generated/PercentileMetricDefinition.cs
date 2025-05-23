// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.OnlineExperimentation
{
    /// <summary> The definition of a Percentile metric definition. Calculates a specified percentile of an event property. </summary>
    public partial class PercentileMetricDefinition : ExperimentMetricDefinition
    {
        /// <summary> Initializes a new instance of <see cref="PercentileMetricDefinition"/>. </summary>
        /// <param name="value"> The value to aggregate, including the event name and property to measure. </param>
        /// <param name="percentile"> The percentile to measure. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PercentileMetricDefinition(AggregatedValue value, double percentile)
        {
            Argument.AssertNotNull(value, nameof(value));

            Type = ExperimentMetricType.Percentile;
            Value = value;
            Percentile = percentile;
        }

        /// <summary> Initializes a new instance of <see cref="PercentileMetricDefinition"/>. </summary>
        /// <param name="type"> Discriminator property for ExperimentMetricDefinition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> The value to aggregate, including the event name and property to measure. </param>
        /// <param name="percentile"> The percentile to measure. </param>
        internal PercentileMetricDefinition(ExperimentMetricType type, IDictionary<string, BinaryData> serializedAdditionalRawData, AggregatedValue value, double percentile) : base(type, serializedAdditionalRawData)
        {
            Value = value;
            Percentile = percentile;
        }

        /// <summary> Initializes a new instance of <see cref="PercentileMetricDefinition"/> for deserialization. </summary>
        internal PercentileMetricDefinition()
        {
        }

        /// <summary> The value to aggregate, including the event name and property to measure. </summary>
        public AggregatedValue Value { get; set; }
        /// <summary> The percentile to measure. </summary>
        public double Percentile { get; set; }
    }
}
