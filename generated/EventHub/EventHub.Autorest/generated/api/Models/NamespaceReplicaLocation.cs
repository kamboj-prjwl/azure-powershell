// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Namespace replication properties</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class NamespaceReplicaLocation :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INamespaceReplicaLocation,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INamespaceReplicaLocationInternal
    {

        /// <summary>Backing field for <see cref="ClusterArmId" /> property.</summary>
        private string _clusterArmId;

        /// <summary>
        /// Optional property that denotes the ARM ID of the Cluster. This is required, if a namespace replica should be placed in
        /// a Dedicated Event Hub Cluster
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string ClusterArmId { get => this._clusterArmId; set => this._clusterArmId = value; }

        /// <summary>Backing field for <see cref="LocationName" /> property.</summary>
        private string _locationName;

        /// <summary>Azure regions where a replica of the namespace is maintained</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string LocationName { get => this._locationName; set => this._locationName = value; }

        /// <summary>Internal Acessors for ReplicaState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INamespaceReplicaLocationInternal.ReplicaState { get => this._replicaState; set { {_replicaState = value;} } }

        /// <summary>Backing field for <see cref="ReplicaState" /> property.</summary>
        private string _replicaState;

        /// <summary>state of Namespace replica.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string ReplicaState { get => this._replicaState; }

        /// <summary>Backing field for <see cref="RoleType" /> property.</summary>
        private string _roleType;

        /// <summary>GeoDR Role Types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string RoleType { get => this._roleType; set => this._roleType = value; }

        /// <summary>Creates an new <see cref="NamespaceReplicaLocation" /> instance.</summary>
        public NamespaceReplicaLocation()
        {

        }
    }
    /// Namespace replication properties
    public partial interface INamespaceReplicaLocation :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Optional property that denotes the ARM ID of the Cluster. This is required, if a namespace replica should be placed in
        /// a Dedicated Event Hub Cluster
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional property that denotes the ARM ID of the Cluster. This is required, if a namespace replica should be placed in a Dedicated Event Hub Cluster",
        SerializedName = @"clusterArmId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterArmId { get; set; }
        /// <summary>Azure regions where a replica of the namespace is maintained</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure regions where a replica of the namespace is maintained",
        SerializedName = @"locationName",
        PossibleTypes = new [] { typeof(string) })]
        string LocationName { get; set; }
        /// <summary>state of Namespace replica.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"state of Namespace replica.",
        SerializedName = @"replicaState",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaState { get;  }
        /// <summary>GeoDR Role Types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"GeoDR Role Types",
        SerializedName = @"roleType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Primary", "Secondary")]
        string RoleType { get; set; }

    }
    /// Namespace replication properties
    internal partial interface INamespaceReplicaLocationInternal

    {
        /// <summary>
        /// Optional property that denotes the ARM ID of the Cluster. This is required, if a namespace replica should be placed in
        /// a Dedicated Event Hub Cluster
        /// </summary>
        string ClusterArmId { get; set; }
        /// <summary>Azure regions where a replica of the namespace is maintained</summary>
        string LocationName { get; set; }
        /// <summary>state of Namespace replica.</summary>
        string ReplicaState { get; set; }
        /// <summary>GeoDR Role Types</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Primary", "Secondary")]
        string RoleType { get; set; }

    }
}