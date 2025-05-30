// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a SiteRecoveryNetwork along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SiteRecoveryNetworkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSiteRecoveryNetworkResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteRecoveryFabricResource"/> using the GetSiteRecoveryNetwork method.
    /// </summary>
    public partial class SiteRecoveryNetworkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteRecoveryNetworkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="fabricName"> The fabricName. </param>
        /// <param name="networkName"> The networkName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string networkName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteRecoveryNetworkReplicationNetworksClientDiagnostics;
        private readonly ReplicationNetworksRestOperations _siteRecoveryNetworkReplicationNetworksRestClient;
        private readonly SiteRecoveryNetworkData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationFabrics/replicationNetworks";

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkResource"/> class for mocking. </summary>
        protected SiteRecoveryNetworkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteRecoveryNetworkResource(ArmClient client, SiteRecoveryNetworkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteRecoveryNetworkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryNetworkReplicationNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteRecoveryNetworkReplicationNetworksApiVersion);
            _siteRecoveryNetworkReplicationNetworksRestClient = new ReplicationNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryNetworkReplicationNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteRecoveryNetworkData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteRecoveryNetworkMappingResources in the SiteRecoveryNetwork. </summary>
        /// <returns> An object representing collection of SiteRecoveryNetworkMappingResources and their operations over a SiteRecoveryNetworkMappingResource. </returns>
        public virtual SiteRecoveryNetworkMappingCollection GetSiteRecoveryNetworkMappings()
        {
            return GetCachedClient(client => new SiteRecoveryNetworkMappingCollection(client, Id));
        }

        /// <summary>
        /// Gets the details of an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteRecoveryNetworkMappingResource>> GetSiteRecoveryNetworkMappingAsync(string networkMappingName, CancellationToken cancellationToken = default)
        {
            return await GetSiteRecoveryNetworkMappings().GetAsync(networkMappingName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteRecoveryNetworkMappingResource> GetSiteRecoveryNetworkMapping(string networkMappingName, CancellationToken cancellationToken = default)
        {
            return GetSiteRecoveryNetworkMappings().Get(networkMappingName, cancellationToken);
        }

        /// <summary>
        /// Gets the details of a network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteRecoveryNetworkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkResource.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkReplicationNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteRecoveryNetworkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteRecoveryNetworkReplicationNetworksClientDiagnostics.CreateScope("SiteRecoveryNetworkResource.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkReplicationNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
