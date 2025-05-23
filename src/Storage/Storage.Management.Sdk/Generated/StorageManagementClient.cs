// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage
{
    using System.Linq;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// The Azure Storage Management API.
    /// </summary>
    public partial class StorageManagementClient : Microsoft.Rest.ServiceClient<StorageManagementClient>, IStorageManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }
        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; private set; }
        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; private set; }
        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public Microsoft.Rest.ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        public string SubscriptionId { get; set;}

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set;}

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// /// value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set;}

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// /// set to true a unique x-ms-client-request-id value is generated and
        /// /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set;}

        /// <summary>
        /// Gets the IOperations
        /// </summary>
        public virtual IOperations Operations { get; private set; }
        /// <summary>
        /// Gets the ISkusOperations
        /// </summary>
        public virtual ISkusOperations Skus { get; private set; }
        /// <summary>
        /// Gets the IStorageAccountsOperations
        /// </summary>
        public virtual IStorageAccountsOperations StorageAccounts { get; private set; }
        /// <summary>
        /// Gets the IDeletedAccountsOperations
        /// </summary>
        public virtual IDeletedAccountsOperations DeletedAccounts { get; private set; }
        /// <summary>
        /// Gets the IUsagesOperations
        /// </summary>
        public virtual IUsagesOperations Usages { get; private set; }
        /// <summary>
        /// Gets the IManagementPoliciesOperations
        /// </summary>
        public virtual IManagementPoliciesOperations ManagementPolicies { get; private set; }
        /// <summary>
        /// Gets the IBlobInventoryPoliciesOperations
        /// </summary>
        public virtual IBlobInventoryPoliciesOperations BlobInventoryPolicies { get; private set; }
        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations
        /// </summary>
        public virtual IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; private set; }
        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations
        /// </summary>
        public virtual IPrivateLinkResourcesOperations PrivateLinkResources { get; private set; }
        /// <summary>
        /// Gets the IObjectReplicationPoliciesOperations
        /// </summary>
        public virtual IObjectReplicationPoliciesOperations ObjectReplicationPolicies { get; private set; }
        /// <summary>
        /// Gets the ILocalUsersOperations
        /// </summary>
        public virtual ILocalUsersOperations LocalUsers { get; private set; }
        /// <summary>
        /// Gets the IEncryptionScopesOperations
        /// </summary>
        public virtual IEncryptionScopesOperations EncryptionScopes { get; private set; }
        /// <summary>
        /// Gets the IBlobServicesOperations
        /// </summary>
        public virtual IBlobServicesOperations BlobServices { get; private set; }
        /// <summary>
        /// Gets the IBlobContainersOperations
        /// </summary>
        public virtual IBlobContainersOperations BlobContainers { get; private set; }
        /// <summary>
        /// Gets the IFileServicesOperations
        /// </summary>
        public virtual IFileServicesOperations FileServices { get; private set; }
        /// <summary>
        /// Gets the IFileSharesOperations
        /// </summary>
        public virtual IFileSharesOperations FileShares { get; private set; }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling StorageManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected StorageManagementClient(System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            this.Initialize();
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected StorageManagementClient(params System.Net.Http.DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient  class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected StorageManagementClient(System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected StorageManagementClient(System.Uri baseUri, params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected StorageManagementClient(System.Uri baseUri, System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
        
            this.BaseUri = baseUri;
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public StorageManagementClient(Microsoft.Rest.ServiceClientCredentials credentials, params System.Net.Http.DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name="credentials">
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling StorageManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public StorageManagementClient(Microsoft.Rest.ServiceClientCredentials credentials, System.Net.Http.HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name="credentials">
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public StorageManagementClient(Microsoft.Rest.ServiceClientCredentials credentials, System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name="credentials">
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public StorageManagementClient(System.Uri baseUri, Microsoft.Rest.ServiceClientCredentials credentials, params System.Net.Http.DelegatingHandler[] handlers) : this(handlers) 
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            
        }
        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name="credentials">
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public StorageManagementClient(System.Uri baseUri, Microsoft.Rest.ServiceClientCredentials credentials, System.Net.Http.HttpClientHandler rootHandler, params System.Net.Http.DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            
        }
        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.Operations = new Operations(this);
            this.Skus = new SkusOperations(this);
            this.StorageAccounts = new StorageAccountsOperations(this);
            this.DeletedAccounts = new DeletedAccountsOperations(this);
            this.Usages = new UsagesOperations(this);
            this.ManagementPolicies = new ManagementPoliciesOperations(this);
            this.BlobInventoryPolicies = new BlobInventoryPoliciesOperations(this);
            this.PrivateEndpointConnections = new PrivateEndpointConnectionsOperations(this);
            this.PrivateLinkResources = new PrivateLinkResourcesOperations(this);
            this.ObjectReplicationPolicies = new ObjectReplicationPoliciesOperations(this);
            this.LocalUsers = new LocalUsersOperations(this);
            this.EncryptionScopes = new EncryptionScopesOperations(this);
            this.BlobServices = new BlobServicesOperations(this);
            this.BlobContainers = new BlobContainersOperations(this);
            this.FileServices = new FileServicesOperations(this);
            this.FileShares = new FileSharesOperations(this);
            this.BaseUri = new System.Uri("https://management.azure.com");
            this.ApiVersion = "2024-01-01";
            this.AcceptLanguage = "en-US";
            this.LongRunningOperationRetryTimeout = 30;
            this.GenerateClientRequestId = true;
            SerializationSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new Microsoft.Rest.Serialization.ReadOnlyJsonContractResolver(),
                Converters = new System.Collections.Generic.List<Newtonsoft.Json.JsonConverter>
                    {
                        new Microsoft.Rest.Serialization.Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new Microsoft.Rest.Serialization.TransformationJsonConverter());
            DeserializationSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new Microsoft.Rest.Serialization.ReadOnlyJsonContractResolver(),
                Converters = new System.Collections.Generic.List<Newtonsoft.Json.JsonConverter>
                    {
                        new Microsoft.Rest.Serialization.Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new Microsoft.Rest.Serialization.TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new Microsoft.Rest.Azure.CloudErrorJsonConverter());
        }
    }
}