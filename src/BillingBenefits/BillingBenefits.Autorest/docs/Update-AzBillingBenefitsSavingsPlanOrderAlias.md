---
external help file:
Module Name: Az.BillingBenefits
online version: https://learn.microsoft.com/powershell/module/az.billingbenefits/update-azbillingbenefitssavingsplanorderalias
schema: 2.0.0
---

# Update-AzBillingBenefitsSavingsPlanOrderAlias

## SYNOPSIS
update a savings plan.
Learn more about permissions needed at https://go.microsoft.com/fwlink/?linkid=2215851

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzBillingBenefitsSavingsPlanOrderAlias -Name <String> [-AppliedScopePropertyDisplayName <String>]
 [-AppliedScopePropertyManagementGroupId <String>] [-AppliedScopePropertyResourceGroupId <String>]
 [-AppliedScopePropertySubscriptionId <String>] [-AppliedScopePropertyTenantId <String>]
 [-AppliedScopeType <String>] [-BillingPlan <String>] [-BillingScopeId <String>] [-CommitmentAmount <Double>]
 [-CommitmentCurrencyCode <String>] [-CommitmentGrain <String>] [-DisplayName <String>] [-Kind <String>]
 [-SkuName <String>] [-Term <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzBillingBenefitsSavingsPlanOrderAlias -InputObject <IBillingBenefitsIdentity>
 [-AppliedScopePropertyDisplayName <String>] [-AppliedScopePropertyManagementGroupId <String>]
 [-AppliedScopePropertyResourceGroupId <String>] [-AppliedScopePropertySubscriptionId <String>]
 [-AppliedScopePropertyTenantId <String>] [-AppliedScopeType <String>] [-BillingPlan <String>]
 [-BillingScopeId <String>] [-CommitmentAmount <Double>] [-CommitmentCurrencyCode <String>]
 [-CommitmentGrain <String>] [-DisplayName <String>] [-Kind <String>] [-SkuName <String>] [-Term <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
update a savings plan.
Learn more about permissions needed at https://go.microsoft.com/fwlink/?linkid=2215851

## EXAMPLES

### Example 1: Update a savings plan.
```powershell
Update-AzBillingBenefitsSavingsPlanOrderAlias -Name "PSTest1" -AppliedScopeType "Shared" -BillingPlan "P1M" `
-BillingScopeId "/subscriptions/eef82110-c91b-4395-9420-fcfcbefc5a47" -CommitmentAmount 0.001 -CommitmentCurrencyCode "USD" -CommitmentGrain "Hourly" -SkuName "Compute_Savings_Plan" -DisplayName "PSTest199" -Term "P3Y"
```

```output
Name    DisplayName SkuName              CommitmentAmount CommitmentCurrencyCode CommitmentGrain SavingsPlanOrderId                                                                          ProvisioningState BillingScopeId
----    ----------- -------              ---------------- ---------------------- --------------- ------------------                                                                          ----------------- --------------
PSTest1 PSTest1     Compute_Savings_Plan 0.001            USD                    Hourly          /providers/Microsoft.BillingBenefits/savingsPlanOrders/955e24a7-6672-4038-9961-619a75c2acf4 Created           /subscriptions/eef82110-c91b-4395-9420…
```

update a savings plan.
Learn more about permissions needed at https://go.microsoft.com/fwlink/?linkid=2215851

## PARAMETERS

### -AppliedScopePropertyDisplayName
Display name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliedScopePropertyManagementGroupId
Fully-qualified identifier of the management group where the benefit must be applied.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliedScopePropertyResourceGroupId
Fully-qualified identifier of the resource group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliedScopePropertySubscriptionId
Fully-qualified identifier of the subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliedScopePropertyTenantId
Tenant ID where the benefit is applied.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliedScopeType
Type of the Applied Scope.

```yaml
Type: System.String
Parameter Sets: (All)
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

### -BillingPlan
Represents the billing plan in ISO 8601 format.
Required only for monthly billing plans.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BillingScopeId
Subscription that will be charged for purchasing the benefit

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommitmentAmount
.

```yaml
Type: System.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommitmentCurrencyCode
The ISO 4217 3-letter currency code for the currency used by this purchase record.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommitmentGrain
Commitment grain.

```yaml
Type: System.String
Parameter Sets: (All)
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

### -DisplayName
Display name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Kind
Resource provider kind

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the savings plan order alias

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases: SavingsPlanOrderAliasName

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

### -SkuName
Name of the SKU to be applied

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Term
Represent benefit term in ISO 8601 format.

```yaml
Type: System.String
Parameter Sets: (All)
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

### Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanOrderAliasModel

## NOTES

## RELATED LINKS

[https://go.microsoft.com/fwlink/?linkid=2215851/](https://go.microsoft.com/fwlink/?linkid=2215851/)

