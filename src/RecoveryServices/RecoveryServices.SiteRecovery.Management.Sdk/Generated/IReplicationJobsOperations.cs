// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ReplicationJobsOperations operations.
    /// </summary>
    public partial interface IReplicationJobsOperations
    {
        /// <summary>
        /// Gets the list of Azure Site Recovery Jobs for the vault.
        /// </summary>
        /// <remarks>
        /// Gets the list of Azure Site Recovery Jobs for the vault.
        /// </remarks>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Job>>> ListWithHttpMessagesAsync(string resourceGroupName, string resourceName, Microsoft.Rest.Azure.OData.ODataQuery<JobQueryParameter> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<JobQueryParameter>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the details of an Azure Site Recovery job.
        /// </summary>
        /// <remarks>
        /// Get the details of an Azure Site Recovery job.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobName'>
        /// Job identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to cancel an Azure Site Recovery job.
        /// </summary>
        /// <remarks>
        /// The operation to cancel an Azure Site Recovery job.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobName'>
        /// Job identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> CancelWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to restart an Azure Site Recovery job.
        /// </summary>
        /// <remarks>
        /// The operation to restart an Azure Site Recovery job.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobName'>
        /// Job identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> RestartWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to resume an Azure Site Recovery job.
        /// </summary>
        /// <remarks>
        /// The operation to resume an Azure Site Recovery job.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobName'>
        /// Job identifier.
        /// </param>
        /// <param name='properties'>
        /// Resume job properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> ResumeWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobName, ResumeJobParamsProperties properties = default(ResumeJobParamsProperties), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to export the details of the Azure Site Recovery jobs of the
        /// vault.
        /// </summary>
        /// <remarks>
        /// The operation to export the details of the Azure Site Recovery jobs of the
        /// vault.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobQueryParameter'>
        /// job query filter.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> ExportWithHttpMessagesAsync(string resourceGroupName, string resourceName, JobQueryParameter jobQueryParameter, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to cancel an Azure Site Recovery job.
        /// </summary>
        /// <remarks>
        /// The operation to cancel an Azure Site Recovery job.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobName'>
        /// Job identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> BeginCancelWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to restart an Azure Site Recovery job.
        /// </summary>
        /// <remarks>
        /// The operation to restart an Azure Site Recovery job.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobName'>
        /// Job identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> BeginRestartWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to resume an Azure Site Recovery job.
        /// </summary>
        /// <remarks>
        /// The operation to resume an Azure Site Recovery job.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobName'>
        /// Job identifier.
        /// </param>
        /// <param name='properties'>
        /// Resume job properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> BeginResumeWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobName, ResumeJobParamsProperties properties = default(ResumeJobParamsProperties), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The operation to export the details of the Azure Site Recovery jobs of the
        /// vault.
        /// </summary>
        /// <remarks>
        /// The operation to export the details of the Azure Site Recovery jobs of the
        /// vault.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='jobQueryParameter'>
        /// job query filter.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Job>> BeginExportWithHttpMessagesAsync(string resourceGroupName, string resourceName, JobQueryParameter jobQueryParameter, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the list of Azure Site Recovery Jobs for the vault.
        /// </summary>
        /// <remarks>
        /// Gets the list of Azure Site Recovery Jobs for the vault.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Job>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}