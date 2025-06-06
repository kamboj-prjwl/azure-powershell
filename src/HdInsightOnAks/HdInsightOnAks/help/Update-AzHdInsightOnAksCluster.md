---
external help file: Az.HdInsightOnAks-help.xml
Module Name: Az.HdInsightOnAks
online version: https://learn.microsoft.com/powershell/module/az.hdinsightonaks/update-azhdinsightonakscluster
schema: 2.0.0
---

# Update-AzHdInsightOnAksCluster

## SYNOPSIS
update an existing Cluster.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzHdInsightOnAksCluster -Name <String> -PoolName <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] [-ApplicationLogStdErrorEnabled] [-ApplicationLogStdOutEnabled]
 [-AuthorizationProfileGroupId <String[]>] [-AuthorizationProfileUserId <String[]>]
 [-AutoscaleProfileAutoscaleType <String>] [-AutoscaleProfileEnabled]
 [-AutoscaleProfileGracefulDecommissionTimeout <Int32>] [-CatalogOptionHive <IHiveCatalogOption[]>]
 [-ClusterProfileScriptActionProfile <IScriptActionProfile[]>]
 [-ClusterProfileServiceConfigsProfile <IClusterServiceConfigsProfile[]>] [-CoordinatorDebugEnable]
 [-CoordinatorDebugPort <Int32>] [-CoordinatorDebugSuspend] [-CoordinatorHighAvailabilityEnabled]
 [-DatabaseHost <String>] [-DatabaseName <String>] [-DatabasePasswordSecretRef <String>]
 [-DatabaseUsername <String>] [-LoadBasedConfigCooldownPeriod <Int32>] [-LoadBasedConfigMaxNode <Int32>]
 [-LoadBasedConfigMinNode <Int32>] [-LoadBasedConfigPollInterval <Int32>]
 [-LoadBasedConfigScalingRule <IScalingRule[]>] [-LogAnalyticProfileEnabled]
 [-LogAnalyticProfileMetricsEnabled] [-PrometheuProfileEnabled] [-RangerAdmin <String[]>]
 [-RangerAuditStorageAccount <String>] [-RangerPluginProfileEnabled] [-RangerUsersyncEnabled]
 [-RangerUsersyncGroup <String[]>] [-RangerUsersyncMode <String>] [-RangerUsersyncUser <String[]>]
 [-RangerUsersyncUserMappingLocation <String>] [-ScheduleBasedConfigDefaultCount <Int32>]
 [-ScheduleBasedConfigSchedule <ISchedule[]>] [-ScheduleBasedConfigTimeZone <String>]
 [-SecretProfileKeyVaultResourceId <String>] [-SecretProfileSecret <ISecretReference[]>]
 [-SshProfileCount <Int32>] [-SshProfileVMSize <String>] [-StorageHivecatalogName <String>]
 [-StorageHivecatalogSchema <String>] [-StoragePartitionRetentionInDay <Int32>] [-StoragePath <String>]
 [-Tag <Hashtable>] [-UserPluginSpecPlugin <ITrinoUserPlugin[]>] [-WorkerDebugEnable]
 [-WorkerDebugPort <Int32>] [-WorkerDebugSuspend] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaJsonString
```
Update-AzHdInsightOnAksCluster -Name <String> -PoolName <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] -JsonString <String> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaJsonFilePath
```
Update-AzHdInsightOnAksCluster -Name <String> -PoolName <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] -JsonFilePath <String> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityClusterpoolExpanded
```
Update-AzHdInsightOnAksCluster -Name <String> -ClusterpoolInputObject <IHdInsightOnAksIdentity>
 [-ApplicationLogStdErrorEnabled] [-ApplicationLogStdOutEnabled] [-AuthorizationProfileGroupId <String[]>]
 [-AuthorizationProfileUserId <String[]>] [-AutoscaleProfileAutoscaleType <String>] [-AutoscaleProfileEnabled]
 [-AutoscaleProfileGracefulDecommissionTimeout <Int32>] [-CatalogOptionHive <IHiveCatalogOption[]>]
 [-ClusterProfileScriptActionProfile <IScriptActionProfile[]>]
 [-ClusterProfileServiceConfigsProfile <IClusterServiceConfigsProfile[]>] [-CoordinatorDebugEnable]
 [-CoordinatorDebugPort <Int32>] [-CoordinatorDebugSuspend] [-CoordinatorHighAvailabilityEnabled]
 [-DatabaseHost <String>] [-DatabaseName <String>] [-DatabasePasswordSecretRef <String>]
 [-DatabaseUsername <String>] [-LoadBasedConfigCooldownPeriod <Int32>] [-LoadBasedConfigMaxNode <Int32>]
 [-LoadBasedConfigMinNode <Int32>] [-LoadBasedConfigPollInterval <Int32>]
 [-LoadBasedConfigScalingRule <IScalingRule[]>] [-LogAnalyticProfileEnabled]
 [-LogAnalyticProfileMetricsEnabled] [-PrometheuProfileEnabled] [-RangerAdmin <String[]>]
 [-RangerAuditStorageAccount <String>] [-RangerPluginProfileEnabled] [-RangerUsersyncEnabled]
 [-RangerUsersyncGroup <String[]>] [-RangerUsersyncMode <String>] [-RangerUsersyncUser <String[]>]
 [-RangerUsersyncUserMappingLocation <String>] [-ScheduleBasedConfigDefaultCount <Int32>]
 [-ScheduleBasedConfigSchedule <ISchedule[]>] [-ScheduleBasedConfigTimeZone <String>]
 [-SecretProfileKeyVaultResourceId <String>] [-SecretProfileSecret <ISecretReference[]>]
 [-SshProfileCount <Int32>] [-SshProfileVMSize <String>] [-StorageHivecatalogName <String>]
 [-StorageHivecatalogSchema <String>] [-StoragePartitionRetentionInDay <Int32>] [-StoragePath <String>]
 [-Tag <Hashtable>] [-UserPluginSpecPlugin <ITrinoUserPlugin[]>] [-WorkerDebugEnable]
 [-WorkerDebugPort <Int32>] [-WorkerDebugSuspend] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityClusterpool
```
Update-AzHdInsightOnAksCluster -Name <String> -ClusterpoolInputObject <IHdInsightOnAksIdentity>
 -ClusterPatchRequest <IClusterPatch> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-AzHdInsightOnAksCluster -Name <String> -PoolName <String> -ResourceGroupName <String>
 [-SubscriptionId <String>] -ClusterPatchRequest <IClusterPatch> [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzHdInsightOnAksCluster -InputObject <IHdInsightOnAksIdentity> [-ApplicationLogStdErrorEnabled]
 [-ApplicationLogStdOutEnabled] [-AuthorizationProfileGroupId <String[]>]
 [-AuthorizationProfileUserId <String[]>] [-AutoscaleProfileAutoscaleType <String>] [-AutoscaleProfileEnabled]
 [-AutoscaleProfileGracefulDecommissionTimeout <Int32>] [-CatalogOptionHive <IHiveCatalogOption[]>]
 [-ClusterProfileScriptActionProfile <IScriptActionProfile[]>]
 [-ClusterProfileServiceConfigsProfile <IClusterServiceConfigsProfile[]>] [-CoordinatorDebugEnable]
 [-CoordinatorDebugPort <Int32>] [-CoordinatorDebugSuspend] [-CoordinatorHighAvailabilityEnabled]
 [-DatabaseHost <String>] [-DatabaseName <String>] [-DatabasePasswordSecretRef <String>]
 [-DatabaseUsername <String>] [-LoadBasedConfigCooldownPeriod <Int32>] [-LoadBasedConfigMaxNode <Int32>]
 [-LoadBasedConfigMinNode <Int32>] [-LoadBasedConfigPollInterval <Int32>]
 [-LoadBasedConfigScalingRule <IScalingRule[]>] [-LogAnalyticProfileEnabled]
 [-LogAnalyticProfileMetricsEnabled] [-PrometheuProfileEnabled] [-RangerAdmin <String[]>]
 [-RangerAuditStorageAccount <String>] [-RangerPluginProfileEnabled] [-RangerUsersyncEnabled]
 [-RangerUsersyncGroup <String[]>] [-RangerUsersyncMode <String>] [-RangerUsersyncUser <String[]>]
 [-RangerUsersyncUserMappingLocation <String>] [-ScheduleBasedConfigDefaultCount <Int32>]
 [-ScheduleBasedConfigSchedule <ISchedule[]>] [-ScheduleBasedConfigTimeZone <String>]
 [-SecretProfileKeyVaultResourceId <String>] [-SecretProfileSecret <ISecretReference[]>]
 [-SshProfileCount <Int32>] [-SshProfileVMSize <String>] [-StorageHivecatalogName <String>]
 [-StorageHivecatalogSchema <String>] [-StoragePartitionRetentionInDay <Int32>] [-StoragePath <String>]
 [-Tag <Hashtable>] [-UserPluginSpecPlugin <ITrinoUserPlugin[]>] [-WorkerDebugEnable]
 [-WorkerDebugPort <Int32>] [-WorkerDebugSuspend] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-AzHdInsightOnAksCluster -InputObject <IHdInsightOnAksIdentity> -ClusterPatchRequest <IClusterPatch>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
update an existing Cluster.

## EXAMPLES

### Example 1: Update a cluster service config.
```powershell
$clusterResourceGroupName = "Group"
$clusterpoolName = "ps-test-pool"
$clusterName = "flinkcluster"
$coreSiteConfigFile = New-AzHdInsightOnAksClusterConfigFileObject -FileName "core-site.xml" -Value @{"testvalue1"="111"}
$yarnComponentConfig = New-AzHdInsightOnAksClusterServiceConfigObject -ComponentName "hadoop-config" -File $coreSiteConfigFile
$yarnServiceConfigProfile = New-AzHdInsightOnAksClusterServiceConfigsProfileObject -ServiceName "yarn-service" -Config $yarnComponentConfig

Update-AzHdInsightOnAksCluster -ResourceGroupName $clusterResourceGroupName -PoolName $clusterpoolName -Name $clusterName -ClusterProfileServiceConfigsProfile $yarnServiceConfigProfile
```

```output
ApplicationLogStdErrorEnabled               : False
ApplicationLogStdOutEnabled                 : False
AuthorizationProfileGroupId                 :
AuthorizationProfileUserId                  : {00000000-0000-0000-0000-000000000000}
AutoscaleProfileAutoscaleType               :
AutoscaleProfileEnabled                     : False
AutoscaleProfileGracefulDecommissionTimeout :
ClusterType                                 : Spark
ComputeProfileNode                          : {Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.NodeProfile, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.NodeProfile}
ConnectivityProfileSsh                      :
CoordinatorDebugEnable                      :
...
```

Add a key-value `"testvalue1"="111"` to the cluster config file `core-site.xml`.

## PARAMETERS

### -ApplicationLogStdErrorEnabled
True if stderror is enabled, otherwise false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationLogStdOutEnabled
True if stdout is enabled, otherwise false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthorizationProfileGroupId
AAD group Ids authorized for data plane access.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthorizationProfileUserId
AAD user Ids authorized for data plane access.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoscaleProfileAutoscaleType
User to specify which type of Autoscale to be implemented - Scheduled Based or Load Based.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoscaleProfileEnabled
This indicates whether auto scale is enabled on HDInsight on AKS cluster.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoscaleProfileGracefulDecommissionTimeout
This property is for graceful decommission timeout; It has a default setting of 3600 seconds before forced shutdown takes place.
This is the maximal time to wait for running containers and applications to complete before transition a DECOMMISSIONING node into DECOMMISSIONED.
The default value is 3600 seconds.
Negative value (like -1) is handled as infinite timeout.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CatalogOptionHive
hive catalog options.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IHiveCatalogOption[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterPatchRequest
The patch for a cluster.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPatch
Parameter Sets: UpdateViaIdentityClusterpool, Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClusterpoolInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IHdInsightOnAksIdentity
Parameter Sets: UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityClusterpool
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClusterProfileScriptActionProfile
The script action profile list.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IScriptActionProfile[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterProfileServiceConfigsProfile
The service configs profiles.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterServiceConfigsProfile[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinatorDebugEnable
The flag that if enable debug or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinatorDebugPort
The debug port.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinatorDebugSuspend
The flag that if suspend debug or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoordinatorHighAvailabilityEnabled
The flag that if enable coordinator HA, uses multiple coordinator replicas with auto failover, one per each head node.
Default: true.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseHost
The database URL

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseName
The database name

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabasePasswordSecretRef
Reference for the database password

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseUsername
The name of the database user

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IHdInsightOnAksIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Update operation

```yaml
Type: System.String
Parameter Sets: UpdateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Update operation

```yaml
Type: System.String
Parameter Sets: UpdateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadBasedConfigCooldownPeriod
This is a cool down period, this is a time period in seconds, which determines the amount of time that must elapse between a scaling activity started by a rule and the start of the next scaling activity, regardless of the rule that triggers it.
The default value is 300 seconds.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadBasedConfigMaxNode
User needs to set the maximum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadBasedConfigMinNode
User needs to set the minimum number of nodes for load based scaling, the load based scaling will use this to scale up and scale down between minimum and maximum number of nodes.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadBasedConfigPollInterval
User can specify the poll interval, this is the time period (in seconds) after which scaling metrics are polled for triggering a scaling operation.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadBasedConfigScalingRule
The scaling rules.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IScalingRule[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogAnalyticProfileEnabled
True if log analytics is enabled for the cluster, otherwise false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogAnalyticProfileMetricsEnabled
True if metrics are enabled, otherwise false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the HDInsight cluster.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaJsonString, UpdateViaJsonFilePath, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityClusterpool, Update
Aliases: ClusterName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PoolName
The name of the cluster pool.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaJsonString, UpdateViaJsonFilePath, Update
Aliases: ClusterPoolName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrometheuProfileEnabled
Enable Prometheus for cluster or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerAdmin
List of usernames that should be marked as ranger admins.
These usernames should match the user principal name (UPN) of the respective AAD users.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerAuditStorageAccount
Azure storage location of the blobs.
MSI should have read/write access to this Storage account.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerPluginProfileEnabled
Enable Ranger for cluster or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerUsersyncEnabled
Denotes whether usersync service should be enabled

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerUsersyncGroup
List of groups that should be synced.
These group names should match the object id of the respective AAD groups.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerUsersyncMode
User & groups can be synced automatically or via a static list that's refreshed.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerUsersyncUser
List of user names that should be synced.
These usernames should match the User principal name of the respective AAD users.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RangerUsersyncUserMappingLocation
Azure storage location of a mapping file that lists user & group associations.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaJsonString, UpdateViaJsonFilePath, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScheduleBasedConfigDefaultCount
Setting default node count of current schedule configuration.
Default node count specifies the number of nodes which are default when an specified scaling operation is executed (scale up/scale down)

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScheduleBasedConfigSchedule
This specifies the schedules where scheduled based Autoscale to be enabled, the user has a choice to set multiple rules within the schedule across days and times (start/end).

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ISchedule[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScheduleBasedConfigTimeZone
User has to specify the timezone on which the schedule has to be set for schedule based autoscale configuration.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecretProfileKeyVaultResourceId
Name of the user Key Vault where all the cluster specific user secrets are stored.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecretProfileSecret
Properties of Key Vault secret.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ISecretReference[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SshProfileCount
Number of ssh pods per cluster.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SshProfileVMSize
The virtual machine SKU.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageHivecatalogName
Hive Catalog name used to mount external tables on the logs written by trino, if not specified there tables are not created.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageHivecatalogSchema
Schema of the above catalog to use, to mount query logs as external tables, if not specified tables will be mounted under schema trinologs.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StoragePartitionRetentionInDay
Retention period for query log table partitions, this doesn't have any affect on actual data.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StoragePath
Azure storage location of the blobs.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaJsonString, UpdateViaJsonFilePath, Update
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPluginSpecPlugin
Trino user plugins.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ITrinoUserPlugin[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkerDebugEnable
The flag that if enable debug or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkerDebugPort
The debug port.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkerDebugSuspend
The flag that if suspend debug or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityClusterpoolExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPatch

### Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IHdInsightOnAksIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ICluster

## NOTES

## RELATED LINKS
