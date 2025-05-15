Invoke-LiveTestScenario -Name "List ContainerApp" -Description "Test listing ContainerApp" -PowerShellVersion "5.1", "Latest" -ScenarioScript `
{
    param ($rg)
    $rgName = $rg.ResourceGroupName
    $location = "westus"

    $vnetName = New-LiveTestResourceName
    $snetName = New-LiveTestResourceName
    $nsgName = New-LiveTestResourceName
    $natName = New-LiveTestResourceName
    $pipName = New-LiveTestResourceName
    $delName = New-LiveTestResourceName
    $wsName = New-LiveTestResourceName

    $pflName = New-LiveTestResourceName
    $envName = New-LiveTestResourceName
    $tplName = New-LiveTestResourceName
    $daprName = New-LiveTestResourceName
    $appName = New-LiveTestResourceName
    $workspaceName = New-LiveTestResourceName
    $envName = New-LiveTestResourceName
    $appLocation = "northcentralusstage"
    $location = "eastus"

    $null = New-AzOperationalInsightsWorkspace -ResourceGroupName $rgName -Name $workspaceName -Sku PerGB2018 -Location $location -PublicNetworkAccessForIngestion "Enabled" -PublicNetworkAccessForQuery "Enabled"
    $CustomId = (Get-AzOperationalInsightsWorkspace -ResourceGroupName $rgName -Name $workspaceName).CustomerId
    $SharedKey = (Get-AzOperationalInsightsWorkspaceSharedKey -ResourceGroupName $rgName -Name $workspaceName).PrimarySharedKey
    $workloadProfile = New-AzContainerAppWorkloadProfileObject -Name "Consumption" -Type "Consumption"
    $null = New-AzContainerAppManagedEnv -EnvName $envName -ResourceGroupName $rgName -Location $appLocation -AppLogConfigurationDestination "log-analytics" -LogAnalyticConfigurationCustomerId $CustomId -LogAnalyticConfigurationSharedKey $SharedKey -VnetConfigurationInternal:$false -WorkloadProfile $workloadProfile
    $EnvId = (Get-AzContainerAppManagedEnv -ResourceGroupName $rgName -EnvName $envName).Id
    $secretObject = New-AzContainerAppSecretObject -Name "redis-config" -Value "redis-password"
    $probeHttpGetHttpHeader = New-AzContainerAppProbeHeaderObject -Name "Custom-Header" -Value "Awesome"
    $probe = New-AzContainerAppProbeObject -HttpGetPath "/health" -HttpGetPort 8080 -InitialDelaySecond 3 -PeriodSecond 3 -Type Liveness -HttpGetHttpHeader $probeHttpGetHttpHeader
    $temp = New-AzContainerAppTemplateObject -Name $appName -Image "mcr.microsoft.com/k8se/quickstart-jobs:latest" -Probe $probe -ResourceCpu 0.25 -ResourceMemory "0.5Gi"
    $configuration = New-AzContainerAppConfigurationObject -DaprEnabled:$True -DaprAppPort 3000 -DaprAppProtocol "http" -DaprHttpReadBufferSize 30 -DaprHttpMaxRequestSize 10 -DaprLogLevel "debug" -DaprEnableApiLogging:$True -MaxInactiveRevision 10 -ServiceType "redis" -Secret $secretObject

    # Test creating AzContainerApp
    $actual = New-AzContainerApp -Name $appName -ResourceGroupName $rgName -Location $appLocation -Configuration $configuration -TemplateContainer $temp -EnvironmentId $EnvId
    Assert-AreEqual $appName $actual.Name
    Assert-AreEqual "Succeeded" $actual.ProvisioningState
    Assert-AreEqual $envId $actual.EnvironmentId
    Assert-AreEqual $appTemplate.Image $actual.TemplateContainer[0].Image
    Assert-AreEqual $appTemplate.ResourceCpu $actual.TemplateContainer[0].ResourceCpu
    Assert-AreEqual $appTemplate.ResourceMemory $actual.TemplateContainer[0].ResourceMemory
    Assert-NotNull $actual.TemplateContainer[0].Probe
    Assert-AreEqual $daprName $actual.Configuration.DaprAppId
    Assert-AreEqual $appConfig.DaprAppProtocol $actual.Configuration.DaprAppProtocol
    Assert-AreEqual 3000 $actual.Configuration.DaprAppPort
    Assert-AreEqual 30 $actual.Configuration.DaprHttpReadBufferSize
    Assert-AreEqual 100 $actual.Configuration.DaprHttpMaxRequestSize
    Assert-AreEqual 50 $actual.Configuration.MaxInactiveRevision
    Assert-AreEqual $appConfig.DaprLogLevel $actual.Configuration.DaprLogLevel
    Assert-AreEqual $true $actual.Configuration.DaprEnabled
    Assert-AreEqual $true $actual.Configuration.DaprEnableApiLogging
    Assert-AreEqual $appSecretName $actual.Configuration.Secret[0].Name
    Assert-Null $actual.Configuration.Secret[0].Value

    $env = Get-AzContainerAppManagedEnv -ResourceGroupName $rgName -Name $envName

    Assert-NotNull $env
    Assert-AreEqual $rgName $env.ResourceGroupName
    Assert-AreEqual $envName $env.Name
    Assert-AreEqual "Succeeded" $env.ProvisioningState
    Assert-AreEqual "log-analytics" $env.AppLogConfigurationDestination
    Assert-AreEqual $custId $env.LogAnalyticConfigurationCustomerId
    Assert-Null $env.LogAnalyticConfigurationSharedKey
    Assert-AreEqual $snet.Id $env.VnetConfigurationInfrastructureSubnetId

    $workloadProfile = $env.WorkloadProfile | Where-Object { $_.Name -eq $pflName }

    Assert-NotNull $workloadProfile
    Assert-AreEqual $pflName $workloadProfile.Name
    Assert-AreEqual $wlProfile.Type $workloadProfile.Type
    Assert-AreEqual $wlProfile.MinimumCount $workloadProfile.MinimumCount
    Assert-AreEqual $wlProfile.MaximumCount $workloadProfile.MaximumCount

    $app = Get-AzContainerApp -ResourceGroupName $rgName -Name $appName

    Assert-NotNull $app
    Assert-AreEqual $rgName $app.ResourceGroupName
    Assert-AreEqual $appName $app.Name
    Assert-AreEqual "Succeeded" $app.ProvisioningState
    Assert-AreEqual $envId $app.EnvironmentId
    Assert-AreEqual $appTemplate.Image $app.TemplateContainer[0].Image
    Assert-AreEqual $appTemplate.ResourceCpu $app.TemplateContainer[0].ResourceCpu
    Assert-AreEqual $appTemplate.ResourceMemory $app.TemplateContainer[0].ResourceMemory
    Assert-NotNull $app.TemplateContainer[0].Probe
    Assert-AreEqual $daprName $app.Configuration.DaprAppId
    Assert-AreEqual $appConfig.DaprAppProtocol $app.Configuration.DaprAppProtocol
    Assert-AreEqual 3000 $app.Configuration.DaprAppPort
    Assert-AreEqual 30 $app.Configuration.DaprHttpReadBufferSize
    Assert-AreEqual 100 $app.Configuration.DaprHttpMaxRequestSize
    Assert-AreEqual 50 $app.Configuration.MaxInactiveRevision
    Assert-AreEqual $appConfig.DaprLogLevel $app.Configuration.DaprLogLevel
    Assert-AreEqual $true $app.Configuration.DaprEnabled
    Assert-AreEqual $true $app.Configuration.DaprEnableApiLogging
    Assert-AreEqual $appSecretName $app.Configuration.Secret[0].Name
    Assert-Null $app.Configuration.Secret[0].Value

    $appConfig.DaprHttpReadBufferSize = 50
    $appConfig.DaprHttpMaxRequestSize = 50
    $appConfig.DaprEnableApiLogging = $false

    Update-AzContainerApp -Name $appName -ResourceGroupName $rgName -Configuration $appConfig -Tag @{ "testtag" = "testval" }

    $app = Get-AzContainerApp -ResourceGroupName $rgName -Name $appName

    Assert-NotNull $app
    Assert-AreEqual $rgName $app.ResourceGroupName
    Assert-AreEqual $appName $app.Name
    Assert-AreEqual "Succeeded" $app.ProvisioningState
    Assert-AreEqual $envId $app.EnvironmentId
    Assert-AreEqual $appTemplate.Image $app.TemplateContainer[0].Image
    Assert-AreEqual $appTemplate.ResourceCpu $app.TemplateContainer[0].ResourceCpu
    Assert-AreEqual $appTemplate.ResourceMemory $app.TemplateContainer[0].ResourceMemory
    Assert-NotNull $app.TemplateContainer[0].Probe
    Assert-AreEqual $daprName $app.Configuration.DaprAppId
    Assert-AreEqual $appConfig.DaprAppProtocol $app.Configuration.DaprAppProtocol
    Assert-AreEqual 3000 $app.Configuration.DaprAppPort
    Assert-AreEqual 50 $app.Configuration.DaprHttpReadBufferSize
    Assert-AreEqual 50 $app.Configuration.DaprHttpMaxRequestSize
    Assert-AreEqual 50 $app.Configuration.MaxInactiveRevision
    Assert-AreEqual $appConfig.DaprLogLevel $app.Configuration.DaprLogLevel
    Assert-AreEqual $true $app.Configuration.DaprEnabled
    Assert-AreEqual $false $app.Configuration.DaprEnableApiLogging
    Assert-AreEqual $appSecretName $app.Configuration.Secret[0].Name
    Assert-Null $app.Configuration.Secret[0].Value
    Assert-NotNull $app.Tag
    Assert-AreEqual 1 $app.Tag.Count
    Assert-AreEqual "testval" $app.Tag["testtag"]

    Remove-AzContainerApp -ResourceGroupName $rgName -Name $appName
    $app = Get-AzContainerApp -ResourceGroupName $rgName -Name $appName -ErrorAction SilentlyContinue
    Assert-Null $app
}
