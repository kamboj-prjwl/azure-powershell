// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Input for task that validates migration input for SQL sync migrations
    /// </summary>
    public partial class ValidateSyncMigrationInputSqlServerTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the ValidateSyncMigrationInputSqlServerTaskInput class.
        /// </summary>
        public ValidateSyncMigrationInputSqlServerTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateSyncMigrationInputSqlServerTaskInput class.
        /// </summary>

        /// <param name="sourceConnectionInfo">Information for connecting to source SQL server
        /// </param>

        /// <param name="targetConnectionInfo">Information for connecting to target
        /// </param>

        /// <param name="selectedDatabases">Databases to migrate
        /// </param>
        public ValidateSyncMigrationInputSqlServerTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, System.Collections.Generic.IList<MigrateSqlServerSqlDbSyncDatabaseInput> selectedDatabases)

        {
            this.SourceConnectionInfo = sourceConnectionInfo;
            this.TargetConnectionInfo = targetConnectionInfo;
            this.SelectedDatabases = selectedDatabases;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets information for connecting to source SQL server
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceConnectionInfo")]
        public SqlConnectionInfo SourceConnectionInfo {get; set; }

        /// <summary>
        /// Gets or sets information for connecting to target
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetConnectionInfo")]
        public SqlConnectionInfo TargetConnectionInfo {get; set; }

        /// <summary>
        /// Gets or sets databases to migrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "selectedDatabases")]
        public System.Collections.Generic.IList<MigrateSqlServerSqlDbSyncDatabaseInput> SelectedDatabases {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SourceConnectionInfo == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SourceConnectionInfo");
            }
            if (this.TargetConnectionInfo == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TargetConnectionInfo");
            }
            if (this.SelectedDatabases == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SelectedDatabases");
            }
            if (this.SourceConnectionInfo != null)
            {
                this.SourceConnectionInfo.Validate();
            }
            if (this.TargetConnectionInfo != null)
            {
                this.TargetConnectionInfo.Validate();
            }

        }
    }
}