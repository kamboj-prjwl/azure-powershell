
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
Start JFR
.Description
Start JFR
.Example
Start-AzSpringCloudAppDeploymentJfr -ResourceGroupName spring-cloud-rg -ServiceName spring-cloud-service -AppName gateway -Name default 
.Example
Get-AzSpringCloudAppDeployment -ResourceGroupName spring-cloud-rg -ServiceName spring-cloud-service -AppName gateway -Name default | Start-AzSpringCloudAppDeployment

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDiagnosticParameters
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

APPINPUTOBJECT <ISpringCloudIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the build service agent pool resource.
  [AppName <String>]: The name of the App resource.
  [BindingName <String>]: The name of the Binding resource.
  [BuildName <String>]: The name of the build resource.
  [BuildResultName <String>]: The name of the build result resource.
  [BuildServiceName <String>]: The name of the build service resource.
  [BuilderName <String>]: The name of the builder resource.
  [BuildpackBindingName <String>]: The name of the Buildpack Binding Name
  [BuildpackName <String>]: The name of the buildpack resource.
  [CertificateName <String>]: The name of the certificate resource.
  [ConfigurationServiceName <String>]: The name of Application Configuration Service.
  [DeploymentName <String>]: The name of the Deployment resource.
  [DomainName <String>]: The name of the custom domain resource.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ServiceName <String>]: The name of the Service resource.
  [ServiceRegistryName <String>]: The name of Service Registry.
  [StackName <String>]: The name of the stack resource.
  [SubscriptionId <String>]: Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

DIAGNOSTICPARAMETER <IDiagnosticParameters>: Diagnostic parameters of diagnostic operations
  [AppInstance <String>]: App instance name
  [Duration <String>]: Duration of your JFR. 1 min can be represented by 1m or 60s.
  [FilePath <String>]: Your target file path in your own BYOS

INPUTOBJECT <ISpringCloudIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the build service agent pool resource.
  [AppName <String>]: The name of the App resource.
  [BindingName <String>]: The name of the Binding resource.
  [BuildName <String>]: The name of the build resource.
  [BuildResultName <String>]: The name of the build result resource.
  [BuildServiceName <String>]: The name of the build service resource.
  [BuilderName <String>]: The name of the builder resource.
  [BuildpackBindingName <String>]: The name of the Buildpack Binding Name
  [BuildpackName <String>]: The name of the buildpack resource.
  [CertificateName <String>]: The name of the certificate resource.
  [ConfigurationServiceName <String>]: The name of Application Configuration Service.
  [DeploymentName <String>]: The name of the Deployment resource.
  [DomainName <String>]: The name of the custom domain resource.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ServiceName <String>]: The name of the Service resource.
  [ServiceRegistryName <String>]: The name of Service Registry.
  [StackName <String>]: The name of the stack resource.
  [SubscriptionId <String>]: Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

SPRINGINPUTOBJECT <ISpringCloudIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the build service agent pool resource.
  [AppName <String>]: The name of the App resource.
  [BindingName <String>]: The name of the Binding resource.
  [BuildName <String>]: The name of the build resource.
  [BuildResultName <String>]: The name of the build result resource.
  [BuildServiceName <String>]: The name of the build service resource.
  [BuilderName <String>]: The name of the builder resource.
  [BuildpackBindingName <String>]: The name of the Buildpack Binding Name
  [BuildpackName <String>]: The name of the buildpack resource.
  [CertificateName <String>]: The name of the certificate resource.
  [ConfigurationServiceName <String>]: The name of Application Configuration Service.
  [DeploymentName <String>]: The name of the Deployment resource.
  [DomainName <String>]: The name of the custom domain resource.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ServiceName <String>]: The name of the Service resource.
  [ServiceRegistryName <String>]: The name of Service Registry.
  [StackName <String>]: The name of the stack resource.
  [SubscriptionId <String>]: Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://learn.microsoft.com/powershell/module/az.springcloud/start-azspringcloudappdeploymentjfr
#>
function Start-AzSpringCloudAppDeploymentJfr {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='StartExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='StartExpanded', Mandatory)]
    [Parameter(ParameterSetName='StartViaIdentitySpring', Mandatory)]
    [Parameter(ParameterSetName='StartViaIdentitySpringExpanded', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the App resource.
    ${AppName},

    [Parameter(ParameterSetName='StartExpanded', Mandatory)]
    [Parameter(ParameterSetName='StartViaIdentityApp', Mandatory)]
    [Parameter(ParameterSetName='StartViaIdentityAppExpanded', Mandatory)]
    [Parameter(ParameterSetName='StartViaIdentitySpring', Mandatory)]
    [Parameter(ParameterSetName='StartViaIdentitySpringExpanded', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the Deployment resource.
    ${Name},

    [Parameter(ParameterSetName='StartExpanded', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='StartExpanded', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='StartViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the Service resource.
    ${ServiceName},

    [Parameter(ParameterSetName='StartExpanded')]
    [Parameter(ParameterSetName='StartViaJsonFilePath')]
    [Parameter(ParameterSetName='StartViaJsonString')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription ID which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='StartViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='StartViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='StartViaIdentityApp', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='StartViaIdentityAppExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity]
    # Identity Parameter
    ${AppInputObject},

    [Parameter(ParameterSetName='StartViaIdentitySpring', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='StartViaIdentitySpringExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity]
    # Identity Parameter
    ${SpringInputObject},

    [Parameter(ParameterSetName='StartExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityAppExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityExpanded')]
    [Parameter(ParameterSetName='StartViaIdentitySpringExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # App instance name
    ${AppInstance},

    [Parameter(ParameterSetName='StartExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityAppExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityExpanded')]
    [Parameter(ParameterSetName='StartViaIdentitySpringExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # Duration of your JFR.
    # 1 min can be represented by 1m or 60s.
    ${Duration},

    [Parameter(ParameterSetName='StartExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityAppExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityExpanded')]
    [Parameter(ParameterSetName='StartViaIdentitySpringExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # Your target file path in your own BYOS
    ${FilePath},

    [Parameter(ParameterSetName='StartViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='StartViaIdentityApp', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='StartViaIdentitySpring', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDiagnosticParameters]
    # Diagnostic parameters of diagnostic operations
    ${DiagnosticParameter},

    [Parameter(ParameterSetName='StartViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Start operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='StartViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # Json string supplied to the Start operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
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
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

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
            [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            StartExpanded = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartExpanded';
            StartViaIdentity = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaIdentity';
            StartViaIdentityApp = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaIdentityApp';
            StartViaIdentityAppExpanded = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaIdentityAppExpanded';
            StartViaIdentityExpanded = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaIdentityExpanded';
            StartViaIdentitySpring = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaIdentitySpring';
            StartViaIdentitySpringExpanded = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaIdentitySpringExpanded';
            StartViaJsonFilePath = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaJsonFilePath';
            StartViaJsonString = 'Az.SpringCloud.private\Start-AzSpringCloudAppDeploymentJfr_StartViaJsonString';
        }
        if (('StartExpanded', 'StartViaJsonFilePath', 'StartViaJsonString') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
