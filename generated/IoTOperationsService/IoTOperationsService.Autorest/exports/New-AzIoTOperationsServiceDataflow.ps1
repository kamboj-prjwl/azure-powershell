
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
create a DataflowResource
.Description
create a DataflowResource
.Example
New-AzIoTOperationsServiceDataflow -InstanceName "aio-117832708" `
  -Name "dataflow-name" `
  -ProfileName "dataflowprofile-name" `
  -ResourceGroupName "aio-validation-117832708" `
  -ExtendedLocationName "/subscriptions/d4ccd08b-0809-446d-a8b7-7af8a90109cd/resourceGroups/aio-validation-117832708/providers/Microsoft.ExtendedLocation/customLocations/location-117832708" `
  -Mode "Enabled" `
  -Operation @(
    @{
      operationType = "Source"
      sourceSettings = @{
        endpointRef         = "default"
        assetRef            = "do-not-delete"
        serializationFormat = "Json"
        dataSources         = @("azure-iot-operations/data/do-not-delete")
      }
    },
    @{
      operationType = "BuiltInTransformation"
      builtInTransformationSettings = @{
        serializationFormat = "Json"
        datasets            = @()
        filter              = @()
        map                 = @(
          @{
            type    = "PassThrough"
            inputs  = @("*")
            output  = "*"
          }
        )
      }
    },
    @{
      operationType = "Destination"
      destinationSettings = @{
        endpointRef     = "default"
        dataDestination = "fgn"
      }
    }
  )


.Outputs
Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

OPERATION <IDataflowOperation[]>: List of operations including source and destination references as well as transformation.
  OperationType <String>: Type of operation.
  [BuiltInTransformationSettingDataset <List<IDataflowBuiltInTransformationDataset>>]: Enrich data from Broker State Store. Dataset references a key in Broker State Store.
    Input <List<String>>: List of fields for enriching from the Broker State Store.
    Key <String>: The key of the dataset.
    [Description <String>]: A user provided optional description of the dataset.
    [Expression <String>]: Condition to enrich data from Broker State Store. Example: $1 < 0 || $1 > $2 (Assuming inputs section $1 and $2 are provided)
    [SchemaRef <String>]: The reference to the schema that describes the dataset. Allowed: JSON Schema/draft-7.
  [BuiltInTransformationSettingFilter <List<IDataflowBuiltInTransformationFilter>>]: Filters input record or datapoints based on condition.
    Expression <String>: Condition to filter data. Can reference input fields with {n} where n is the index of the input field starting from 1. Example: $1 < 0 || $1 > $2 (Assuming inputs section $1 and $2 are provided)
    Input <List<String>>: List of fields for filtering in JSON path expression.
    [Description <String>]: A user provided optional description of the filter.
    [Type <String>]: The type of dataflow operation.
  [BuiltInTransformationSettingMap <List<IDataflowBuiltInTransformationMap>>]: Maps input to output message.
    Input <List<String>>: List of fields for mapping in JSON path expression.
    Output <String>: Where and how the input fields to be organized in the output record.
    [Description <String>]: A user provided optional description of the mapping function.
    [Expression <String>]: Modify the inputs field(s) to the final output field. Example: $1 * 2.2 (Assuming inputs section $1 is provided)
    [Type <String>]: Type of transformation.
  [BuiltInTransformationSettingSchemaRef <String>]: Reference to the schema that describes the output of the transformation.
  [BuiltInTransformationSettingSerializationFormat <String>]: Serialization format. Optional; defaults to JSON. Allowed value JSON Schema/draft-7, Parquet. Default: Json
  [DestinationSettingDataDestination <String>]: Destination location, can be a topic or table name. Supports dynamic values with $topic, $systemProperties, $userProperties, $payload, $context, and $subscription.
  [DestinationSettingEndpointRef <String>]: Reference to the Endpoint CR. Can be of Broker, Kafka, Fabric, ADLS, ADX type.
  [Name <String>]: Optional user provided name of the transformation.
  [SourceSettingAssetRef <String>]: Reference to the resource in Azure Device Registry where the data in the endpoint originates from.
  [SourceSettingDataSource <List<String>>]: List of source locations. Can be Broker or Kafka topics. Supports wildcards # and +.
  [SourceSettingEndpointRef <String>]: Reference to the Dataflow Endpoint resource. Can only be of Broker and Kafka type.
  [SourceSettingSchemaRef <String>]: Schema CR reference. Data will be deserialized according to the schema, and dropped if it doesn't match.
  [SourceSettingSerializationFormat <String>]: Content is a JSON Schema. Allowed: JSON Schema/draft-7.
.Link
https://learn.microsoft.com/powershell/module/az.iotoperationsservice/new-aziotoperationsservicedataflow
#>
function New-AzIoTOperationsServiceDataflow {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowResource])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Path')]
    [System.String]
    # Name of instance.
    ${InstanceName},

    [Parameter(Mandatory)]
    [Alias('DataflowName')]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Path')]
    [System.String]
    # Name of Instance dataflowProfile dataflow resource
    ${Name},

    [Parameter(Mandatory)]
    [Alias('DataflowProfileName')]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Path')]
    [System.String]
    # Name of Instance dataflowProfile resource
    ${ProfileName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Body')]
    [System.String]
    # The name of the extended location.
    ${ExtendedLocationName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Enabled", "Disabled")]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Body')]
    [System.String]
    # Mode for Dataflow.
    # Optional; defaults to Enabled.
    ${Mode},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowOperation[]]
    # List of operations including source and destination references as well as transformation.
    ${Operation},

    [Parameter(ParameterSetName='CreateViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Create operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='CreateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Body')]
    [System.String]
    # Json string supplied to the Create operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $context = Get-AzContext
        if (-not $context -and -not $testPlayback) {
            Write-Error "No Azure login detected. Please run 'Connect-AzAccount' to log in."
            exit
        }

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.IoTOperationsService.private\New-AzIoTOperationsServiceDataflow_CreateExpanded';
            CreateViaJsonFilePath = 'Az.IoTOperationsService.private\New-AzIoTOperationsServiceDataflow_CreateViaJsonFilePath';
            CreateViaJsonString = 'Az.IoTOperationsService.private\New-AzIoTOperationsServiceDataflow_CreateViaJsonString';
        }
        if (('CreateExpanded', 'CreateViaJsonFilePath', 'CreateViaJsonString') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
