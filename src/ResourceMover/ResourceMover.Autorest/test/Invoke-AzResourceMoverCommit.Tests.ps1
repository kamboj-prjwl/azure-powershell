$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzResourceMoverCommit.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-AzResourceMoverCommit' {
    It 'CommitExpanded' {
           $commitResponse = Invoke-AzResourceMoverCommit -SubscriptionId $env.SubscriptionId -ResourceGroupName $env.moveCollectionMetadataRG -MoveCollectionName $env.moveCollectionName -MoveResource "/subscriptions/e80eb9fa-c996-4435-aa32-5af6f3d3077c/resourcegroups/demo-RG-rms/providers/Microsoft.Network/networkSecurityGroups/demo-NSG-rms" -MoveResourceInputType "MoveResourceSourceId"
           $commitResponse.Status | Should -Be "Succeeded"
    }
}