// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NetworkManagerDeploymentStatusOperations
    /// </summary>
    public static partial class NetworkManagerDeploymentStatusOperationsExtensions
    {
        /// <summary>
        /// Post to List of Network Manager Deployment Status.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='top'>
        /// An optional query parameter which specifies the maximum number of records
        /// to be returned by the server.
        /// </param>
        public static NetworkManagerDeploymentStatusListResult List(this INetworkManagerDeploymentStatusOperations operations, string resourceGroupName, string networkManagerName, NetworkManagerDeploymentStatusParameter parameters, int? top = default(int?))
        {
                return ((INetworkManagerDeploymentStatusOperations)operations).ListAsync(resourceGroupName, networkManagerName, parameters, top).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Post to List of Network Manager Deployment Status.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='top'>
        /// An optional query parameter which specifies the maximum number of records
        /// to be returned by the server.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<NetworkManagerDeploymentStatusListResult> ListAsync(this INetworkManagerDeploymentStatusOperations operations, string resourceGroupName, string networkManagerName, NetworkManagerDeploymentStatusParameter parameters, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkManagerName, parameters, top, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
