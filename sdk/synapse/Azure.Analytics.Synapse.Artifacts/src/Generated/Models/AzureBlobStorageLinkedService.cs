// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The azure blob storage linked service. </summary>
    public partial class AzureBlobStorageLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureBlobStorageLinkedService"/>. </summary>
        public AzureBlobStorageLinkedService()
        {
            Type = "AzureBlobStorage";
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobStorageLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. It is mutually exclusive with sasUri, serviceEndpoint property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="accountKey"> The Azure key vault secret reference of accountKey in connection string. </param>
        /// <param name="sasUri"> SAS URI of the Azure Blob Storage resource. It is mutually exclusive with connectionString, serviceEndpoint property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="sasToken"> The Azure key vault secret reference of sasToken in sas uri. </param>
        /// <param name="serviceEndpoint"> Blob service endpoint of the Azure Blob Storage resource. It is mutually exclusive with connectionString, sasUri property. </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against Azure SQL Data Warehouse. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// The key of the service principal used to authenticate against Azure SQL Data Warehouse.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="accountKind"> Specify the kind of your storage account. Allowed values are: Storage (general purpose v1), StorageV2 (general purpose v2), BlobStorage, or BlockBlobStorage. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="authenticationType"> The type used for authentication. Type: string. </param>
        /// <param name="containerUri"> Container uri of the Azure Blob Storage resource only support for anonymous access. Type: string (or Expression with resultType string). </param>
        internal AzureBlobStorageLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, AzureKeyVaultSecretReference accountKey, object sasUri, AzureKeyVaultSecretReference sasToken, string serviceEndpoint, object servicePrincipalId, SecretBase servicePrincipalKey, object tenant, object azureCloudType, string accountKind, string encryptedCredential, CredentialReference credential, AzureStorageAuthenticationType? authenticationType, object containerUri) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            AccountKey = accountKey;
            SasUri = sasUri;
            SasToken = sasToken;
            ServiceEndpoint = serviceEndpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            AccountKind = accountKind;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            AuthenticationType = authenticationType;
            ContainerUri = containerUri;
            Type = type ?? "AzureBlobStorage";
        }

        /// <summary> The connection string. It is mutually exclusive with sasUri, serviceEndpoint property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The Azure key vault secret reference of accountKey in connection string. </summary>
        public AzureKeyVaultSecretReference AccountKey { get; set; }
        /// <summary> SAS URI of the Azure Blob Storage resource. It is mutually exclusive with connectionString, serviceEndpoint property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object SasUri { get; set; }
        /// <summary> The Azure key vault secret reference of sasToken in sas uri. </summary>
        public AzureKeyVaultSecretReference SasToken { get; set; }
        /// <summary> Blob service endpoint of the Azure Blob Storage resource. It is mutually exclusive with connectionString, sasUri property. </summary>
        public string ServiceEndpoint { get; set; }
        /// <summary> The ID of the service principal used to authenticate against Azure SQL Data Warehouse. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary>
        /// The key of the service principal used to authenticate against Azure SQL Data Warehouse.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public object Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public object AzureCloudType { get; set; }
        /// <summary> Specify the kind of your storage account. Allowed values are: Storage (general purpose v1), StorageV2 (general purpose v2), BlobStorage, or BlockBlobStorage. Type: string (or Expression with resultType string). </summary>
        public string AccountKind { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
        /// <summary> The type used for authentication. Type: string. </summary>
        public AzureStorageAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Container uri of the Azure Blob Storage resource only support for anonymous access. Type: string (or Expression with resultType string). </summary>
        public object ContainerUri { get; set; }
    }
}
