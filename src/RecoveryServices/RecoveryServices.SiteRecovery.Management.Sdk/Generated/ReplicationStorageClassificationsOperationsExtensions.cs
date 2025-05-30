// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ReplicationStorageClassificationsOperations
    /// </summary>
    public static partial class ReplicationStorageClassificationsOperationsExtensions
    {
        /// <summary>
        /// Lists the storage classifications available in the specified fabric.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Site name of interest.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<StorageClassification> ListByReplicationFabrics(this IReplicationStorageClassificationsOperations operations, string resourceGroupName, string resourceName, string fabricName)
        {
                return ((IReplicationStorageClassificationsOperations)operations).ListByReplicationFabricsAsync(resourceGroupName, resourceName, fabricName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the storage classifications available in the specified fabric.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Site name of interest.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<StorageClassification>> ListByReplicationFabricsAsync(this IReplicationStorageClassificationsOperations operations, string resourceGroupName, string resourceName, string fabricName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByReplicationFabricsWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the details of the specified storage classification.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        public static StorageClassification Get(this IReplicationStorageClassificationsOperations operations, string resourceGroupName, string resourceName, string fabricName, string storageClassificationName)
        {
                return ((IReplicationStorageClassificationsOperations)operations).GetAsync(resourceGroupName, resourceName, fabricName, storageClassificationName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the details of the specified storage classification.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='storageClassificationName'>
        /// Storage classification name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageClassification> GetAsync(this IReplicationStorageClassificationsOperations operations, string resourceGroupName, string resourceName, string fabricName, string storageClassificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, storageClassificationName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists the storage classifications in the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<StorageClassification> List(this IReplicationStorageClassificationsOperations operations, string resourceGroupName, string resourceName)
        {
                return ((IReplicationStorageClassificationsOperations)operations).ListAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the storage classifications in the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<StorageClassification>> ListAsync(this IReplicationStorageClassificationsOperations operations, string resourceGroupName, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists the storage classifications available in the specified fabric.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<StorageClassification> ListByReplicationFabricsNext(this IReplicationStorageClassificationsOperations operations, string nextPageLink)
        {
                return ((IReplicationStorageClassificationsOperations)operations).ListByReplicationFabricsNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the storage classifications available in the specified fabric.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<StorageClassification>> ListByReplicationFabricsNextAsync(this IReplicationStorageClassificationsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByReplicationFabricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists the storage classifications in the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<StorageClassification> ListNext(this IReplicationStorageClassificationsOperations operations, string nextPageLink)
        {
                return ((IReplicationStorageClassificationsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the storage classifications in the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<StorageClassification>> ListNextAsync(this IReplicationStorageClassificationsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
