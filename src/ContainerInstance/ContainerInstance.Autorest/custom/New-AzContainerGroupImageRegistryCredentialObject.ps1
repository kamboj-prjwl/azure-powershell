
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the \"License\");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an \"AS IS\" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a in-memory object for ImageRegistryCredential
.Description
Create a in-memory object for ImageRegistryCredential
.Link
https://learn.microsoft.com/powershell/module/az.ContainerInstance/new-AzContainerGroupImageRegistryCredentialObject
#>
function New-AzContainerGroupImageRegistryCredentialObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ImageRegistryCredential')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The password for the private registry.")]
        [System.Security.SecureString]
        $Password,
        [Parameter(Mandatory, HelpMessage="The Docker image registry server without a protocol such as `"http`" and `"https`".")]
        [string]
        $Server,
        [Parameter(HelpMessage="The username for the private registry.")]
        [string]
        $Username,
        [Parameter(HelpMessage="The identity with access to the ACR.")]
        [string]
        $AcrIdentity
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ImageRegistryCredential]::New()
        if ($PSBoundParameters.ContainsKey('Password')) {
            $psTxt = . "$PSScriptRoot/../utils/Unprotect-SecureString.ps1" $PSBoundParameters['Password']
        }
        $Object.Password = $psTxt
        $Object.Server = $Server
        $Object.Username = $Username
        if ($PSBoundParameters.ContainsKey('AcrIdentity')) {
            $Object.Identity = $AcrIdentity
        }
        return $Object
    }
}

