---
external help file: Az.RedisEnterpriseCache-help.xml
Module Name: Az.RedisEnterpriseCache
online version: https://learn.microsoft.com/powershell/module/az.redisenterprisecache/get-azredisenterprisecache
schema: 2.0.0
---

# Get-AzRedisEnterpriseCache

## SYNOPSIS
Gets information about a Redis Enterprise cluster and its associated databases.

## SYNTAX

### ListBySubscriptionId (Default)
```
Get-AzRedisEnterpriseCache [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzRedisEnterpriseCache [-SubscriptionId <String[]>] -ResourceGroupName <String> -ClusterName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListByResourceGroup
```
Get-AzRedisEnterpriseCache [-SubscriptionId <String[]>] -ResourceGroupName <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Gets information about a Redis Enterprise cluster and its associated databases.

## EXAMPLES

### Example 1: Get a Redis Enterprise cache by name
```powershell
Get-AzRedisEnterpriseCache -ResourceGroupName "MyGroup" -Name "MyCache"
```

```output
Location Name    Type                            Zone Database
-------- ----    ----                            ---- --------
West US  MyCache Microsoft.Cache/redisEnterprise      {default}
```

This command gets information about the Redis Enterprise cache named MyCache.

### Example 2: List every Redis Enterprise cache in a resource group
```powershell
Get-AzRedisEnterpriseCache -ResourceGroupName "MyGroup"
```

```output
Location Name     Type                            Zone      Database
-------- ----     ----                            ----      --------
East US  MyCache1 Microsoft.Cache/redisEnterprise           {default}
East US  MyCache2 Microsoft.Cache/redisEnterprise {1, 2, 3} {default}
```

This command gets information about every Redis Enterprise cache in the specified resource group.

### Example 3: List every Redis Enterprise cache in a subscription
```powershell
Get-AzRedisEnterpriseCache
```

```output
Location    Name     Type                            Zone      Database
--------    ----     ----                            ----      --------
East US     MyCache1 Microsoft.Cache/redisEnterprise           {default}
East US     MyCache2 Microsoft.Cache/redisEnterprise {1, 2, 3} {default}
West US     MyCache3 Microsoft.Cache/redisEnterprise           {default}
Central US  MyCache4 Microsoft.Cache/redisEnterprise {1, 2, 3} {default}
```

This command gets information about every Redis Enterprise cache in the current subscription.

## PARAMETERS

### -ClusterName
The name of the Redis Enterprise cluster.

```yaml
Type: System.String
Parameter Sets: Get
Aliases: Name

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

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

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get, ListByResourceGroup
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20250501Preview.ICluster

## NOTES

## RELATED LINKS
