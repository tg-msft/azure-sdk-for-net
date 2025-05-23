// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementGatewayHostnameConfigurationResource"/> and their operations.
    /// Each <see cref="ApiManagementGatewayHostnameConfigurationResource"/> in the collection will belong to the same instance of <see cref="ApiManagementGatewayResource"/>.
    /// To get an <see cref="ApiManagementGatewayHostnameConfigurationCollection"/> instance call the GetApiManagementGatewayHostnameConfigurations method from an instance of <see cref="ApiManagementGatewayResource"/>.
    /// </summary>
    public partial class ApiManagementGatewayHostnameConfigurationCollection : ArmCollection, IEnumerable<ApiManagementGatewayHostnameConfigurationResource>, IAsyncEnumerable<ApiManagementGatewayHostnameConfigurationResource>
    {
        private readonly ClientDiagnostics _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics;
        private readonly GatewayHostnameConfigurationRestOperations _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayHostnameConfigurationCollection"/> class for mocking. </summary>
        protected ApiManagementGatewayHostnameConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayHostnameConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementGatewayHostnameConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementGatewayHostnameConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementGatewayHostnameConfigurationResource.ResourceType, out string apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationApiVersion);
            _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient = new GatewayHostnameConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates of updates hostname configuration for a Gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="data"> The <see cref="ApiManagementGatewayHostnameConfigurationData"/> to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementGatewayHostnameConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hcId, ApiManagementGatewayHostnameConfigurationData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementGatewayHostnameConfigurationResource>(Response.FromValue(new ApiManagementGatewayHostnameConfigurationResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates of updates hostname configuration for a Gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="data"> The <see cref="ApiManagementGatewayHostnameConfigurationData"/> to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementGatewayHostnameConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string hcId, ApiManagementGatewayHostnameConfigurationData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, data, ifMatch, cancellationToken);
                var uri = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementGatewayHostnameConfigurationResource>(Response.FromValue(new ApiManagementGatewayHostnameConfigurationResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of a hostname configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementGatewayHostnameConfigurationResource>> GetAsync(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayHostnameConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of a hostname configuration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual Response<ApiManagementGatewayHostnameConfigurationResource> Get(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayHostnameConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the collection of hostname configurations for the specified gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| hostname | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementGatewayHostnameConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementGatewayHostnameConfigurationResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGatewayHostnameConfigurationResource(Client, ApiManagementGatewayHostnameConfigurationData.DeserializeApiManagementGatewayHostnameConfigurationData(e)), _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics, Pipeline, "ApiManagementGatewayHostnameConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the collection of hostname configurations for the specified gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| hostname | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementGatewayHostnameConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementGatewayHostnameConfigurationResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGatewayHostnameConfigurationResource(Client, ApiManagementGatewayHostnameConfigurationData.DeserializeApiManagementGatewayHostnameConfigurationData(e)), _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics, Pipeline, "ApiManagementGatewayHostnameConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual Response<bool> Exists(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementGatewayHostnameConfigurationResource>> GetIfExistsAsync(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGatewayHostnameConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayHostnameConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayHostnameConfiguration_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayHostnameConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual NullableResponse<ApiManagementGatewayHostnameConfigurationResource> GetIfExists(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationClientDiagnostics.CreateScope("ApiManagementGatewayHostnameConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayHostnameConfigurationGatewayHostnameConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGatewayHostnameConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayHostnameConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementGatewayHostnameConfigurationResource> IEnumerable<ApiManagementGatewayHostnameConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementGatewayHostnameConfigurationResource> IAsyncEnumerable<ApiManagementGatewayHostnameConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
