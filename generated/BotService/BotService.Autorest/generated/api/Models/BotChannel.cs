// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>Bot channel resource definition</summary>
    public partial class BotChannel :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotChannel,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotChannelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Resource();

        /// <summary>The channel name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string ChannelName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).Name = value ?? null; }

        /// <summary>Entity Tag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Etag = value ?? null; }

        /// <summary>Specifies the resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Id; }

        /// <summary>Required. Gets or sets the Kind of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Kind = value ?? null; }

        /// <summary>Specifies the location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for PropertiesProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotChannelInternal.PropertiesProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannel Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IBotChannelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Channel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISku Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal.Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Sku = value; }

        /// <summary>Internal Acessors for SkuTier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal.SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).SkuTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).SkuTier = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Zone</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal.Zone { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Zone = value; }

        /// <summary>Specifies the name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Name; }

        /// <summary>Entity Tag of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string PropertiesEtag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).Etag = value ?? null; }

        /// <summary>Specifies the location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string PropertiesLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).Location = value ?? null; }

        /// <summary>Provisioning state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string PropertiesProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannel _property;

        /// <summary>The set of properties specific to bot channel resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Channel()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Gets or sets the SKU of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISku Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Sku = value ?? null /* model class */; }

        /// <summary>The sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).SkuName = value ?? null; }

        /// <summary>Gets the sku tier. This is based on the SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).SkuTier; }

        /// <summary>Contains resource tags defined as key/value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Specifies the type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Type; }

        /// <summary>Entity zones</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> Zone { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal)__resource).Zone; }

        /// <summary>Creates an new <see cref="BotChannel" /> instance.</summary>
        public BotChannel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Bot channel resource definition
    public partial interface IBotChannel :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResource
    {
        /// <summary>The channel name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The channel name",
        SerializedName = @"channelName",
        PossibleTypes = new [] { typeof(string) })]
        string ChannelName { get; set; }
        /// <summary>Entity Tag of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Entity Tag of the resource",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesEtag { get; set; }
        /// <summary>Specifies the location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesLocation { get; set; }
        /// <summary>Provisioning state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesProvisioningState { get;  }

    }
    /// Bot channel resource definition
    internal partial interface IBotChannelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IResourceInternal
    {
        /// <summary>The channel name</summary>
        string ChannelName { get; set; }
        /// <summary>Entity Tag of the resource</summary>
        string PropertiesEtag { get; set; }
        /// <summary>Specifies the location of the resource.</summary>
        string PropertiesLocation { get; set; }
        /// <summary>Provisioning state of the resource</summary>
        string PropertiesProvisioningState { get; set; }
        /// <summary>The set of properties specific to bot channel resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannel Property { get; set; }

    }
}