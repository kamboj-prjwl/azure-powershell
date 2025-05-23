
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
Updates an existing CDN profile with the specified profile name under the specified subscription and resource group.
.Description
Updates an existing CDN profile with the specified profile name under the specified subscription and resource group.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ICdnIdentity>: Identity Parameter
  [CustomDomainName <String>]: Name of the domain under the profile which is unique globally.
  [EndpointName <String>]: Name of the endpoint under the profile which is unique globally.
  [Id <String>]: Resource identity path
  [OriginGroupName <String>]: Name of the origin group which is unique within the endpoint.
  [OriginName <String>]: Name of the origin which is unique within the profile.
  [PolicyName <String>]: The name of the CdnWebApplicationFirewallPolicy.
  [ProfileName <String>]: Name of the CDN profile which is unique within the resource group.
  [ResourceGroupName <String>]: Name of the Resource group within the Azure subscription.
  [RouteName <String>]: Name of the routing rule.
  [RuleName <String>]: Name of the delivery rule which is unique within the endpoint.
  [RuleSetName <String>]: Name of the rule set under the profile which is unique globally.
  [SecretName <String>]: Name of the Secret under the profile.
  [SecurityPolicyName <String>]: Name of the security policy under the profile.
  [SubscriptionId <String>]: Azure Subscription ID.
.Link
https://learn.microsoft.com/powershell/module/az.cdn/update-azcdnprofile
#>
function Update-AzCdnProfile {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Alias('ProfileName')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the CDN profile which is unique within the resource group.
        ${Name},
    
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Resource group within the Azure subscription.
        ${ResourceGroupName},
    
        [Parameter(ParameterSetName='UpdateExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Azure Subscription ID.
        ${SubscriptionId},
    
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.Int32]
        # Send and receive timeout on forwarding request to the origin.
        # When timeout is reached, the request fails and returns.
        ${OriginResponseTimeoutSecond},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileUpdateParametersTags]))]
        [System.Collections.Hashtable]
        # Profile tags
        ${Tag},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        $hasTag = $PSBoundParameters.Remove('Tag')
        $hasOriginResponseTimeout = $PSBoundParameters.Remove('OriginResponseTimeoutSecond')
        $hasAsJob = $PSBoundParameters.Remove('AsJob')
        $hasNoWait = $PSBoundParameters.Remove('NoWait')

        if ($PSCmdlet.ParameterSetName -eq 'UpdateExpanded') {
            $cdnProfile = Get-AzCdnProfile @PSBoundParameters
        } elseif ($PSCmdlet.ParameterSetName -eq 'UpdateViaIdentityExpanded') {
            $cdnProfile = Get-AzCdnProfile @PSBoundParameters
        } else {
            throw "Not supported ParameterSetName."
        }

        if ($null -eq $cdnProfile) {
            throw "Provided cdnProfile does not exist."
        } else {
            if ($hasTag) {
                $PSBoundParameters.Add('Tag', ${Tag})
            }

            if ($hasOriginResponseTimeout) {
                $PSBoundParameters.Add('OriginResponseTimeoutSecond', ${OriginResponseTimeoutSecond})
            }

            if ($hasAsJob) {
                $PSBoundParameters.Add('AsJob', ${AsJob})
            }

            if ($hasNoWait) {
                $PSBoundParameters.Add('NoWait', ${NoWait})
            }

            if (-Not (ISFrontDoorCdnProfile($cdnProfile.SkuName))){
                Az.Cdn.internal\Update-AzCdnProfile @PSBoundParameters
            } else {
                throw "Provided cdnProfile does not exist."
            }
        }
    }
}
    