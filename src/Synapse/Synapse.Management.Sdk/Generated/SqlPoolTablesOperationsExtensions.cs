// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SqlPoolTablesOperations
    /// </summary>
    public static partial class SqlPoolTablesOperationsExtensions
    {
        /// <summary>
        /// Gets tables of a given schema in a SQL pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SqlPoolTable> ListBySchema(this ISqlPoolTablesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolTable> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolTable>))
        {
                return ((ISqlPoolTablesOperations)operations).ListBySchemaAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets tables of a given schema in a SQL pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SqlPoolTable>> ListBySchemaAsync(this ISqlPoolTablesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolTable> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolTable>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySchemaWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get Sql pool table
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        public static SqlPoolTable Get(this ISqlPoolTablesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName)
        {
                return ((ISqlPoolTablesOperations)operations).GetAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Sql pool table
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPoolTable> GetAsync(this ISqlPoolTablesOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets tables of a given schema in a SQL pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SqlPoolTable> ListBySchemaNext(this ISqlPoolTablesOperations operations, string nextPageLink)
        {
                return ((ISqlPoolTablesOperations)operations).ListBySchemaNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets tables of a given schema in a SQL pool.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SqlPoolTable>> ListBySchemaNextAsync(this ISqlPoolTablesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySchemaNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
