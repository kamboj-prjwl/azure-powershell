// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Profile for Windows VMs in the managed cluster.
    /// </summary>
    public partial class ManagedClusterWindowsProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterWindowsProfile class.
        /// </summary>
        public ManagedClusterWindowsProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterWindowsProfile class.
        /// </summary>

        /// <param name="adminUsername">Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Restriction:**
        /// Cannot end in &#34;.&#34; &lt;br&gt;&lt;br&gt; **Disallowed values:** &#34;administrator&#34;, &#34;admin&#34;,
        /// &#34;user&#34;, &#34;user1&#34;, &#34;test&#34;, &#34;user2&#34;, &#34;test1&#34;, &#34;user3&#34;, &#34;admin1&#34;, &#34;1&#34;, &#34;123&#34;,
        /// &#34;a&#34;, &#34;actuser&#34;, &#34;adm&#34;, &#34;admin2&#34;, &#34;aspnet&#34;, &#34;backup&#34;, &#34;console&#34;, &#34;david&#34;,
        /// &#34;guest&#34;, &#34;john&#34;, &#34;owner&#34;, &#34;root&#34;, &#34;server&#34;, &#34;sql&#34;, &#34;support&#34;,
        /// &#34;support_388945a0&#34;, &#34;sys&#34;, &#34;test2&#34;, &#34;test3&#34;, &#34;user4&#34;, &#34;user5&#34;. &lt;br&gt;&lt;br&gt;
        /// **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters
        /// </param>

        /// <param name="adminPassword">Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt;
        /// **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters
        /// &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to
        /// be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a
        /// digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt;
        /// **Disallowed values:** &#34;abc@123&#34;, &#34;P@$$w0rd&#34;, &#34;P@ssw0rd&#34;, &#34;P@ssword123&#34;,
        /// &#34;Pa$$word&#34;, &#34;pass@word1&#34;, &#34;Password!&#34;, &#34;Password1&#34;, &#34;Password22&#34;,
        /// &#34;iloveyou!&#34;
        /// </param>

        /// <param name="licenseType">The license type to use for Windows VMs. See [Azure Hybrid User
        /// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more
        /// details.
        /// Possible values include: &#39;None&#39;, &#39;Windows_Server&#39;</param>

        /// <param name="enableCsiProxy">For more details on CSI proxy, see the [CSI proxy GitHub
        /// repo](https://github.com/kubernetes-csi/csi-proxy).
        /// </param>

        /// <param name="gmsaProfile">The Windows gMSA Profile in the Managed Cluster.
        /// </param>
        public ManagedClusterWindowsProfile(string adminUsername, string adminPassword = default(string), string licenseType = default(string), bool? enableCsiProxy = default(bool?), WindowsGmsaProfile gmsaProfile = default(WindowsGmsaProfile))

        {
            this.AdminUsername = adminUsername;
            this.AdminPassword = adminPassword;
            this.LicenseType = licenseType;
            this.EnableCsiProxy = enableCsiProxy;
            this.GmsaProfile = gmsaProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifies the name of the administrator account. &lt;br&gt;&lt;br&gt;
        /// **Restriction:** Cannot end in &#34;.&#34; &lt;br&gt;&lt;br&gt; **Disallowed values:**
        /// &#34;administrator&#34;, &#34;admin&#34;, &#34;user&#34;, &#34;user1&#34;, &#34;test&#34;, &#34;user2&#34;, &#34;test1&#34;,
        /// &#34;user3&#34;, &#34;admin1&#34;, &#34;1&#34;, &#34;123&#34;, &#34;a&#34;, &#34;actuser&#34;, &#34;adm&#34;, &#34;admin2&#34;, &#34;aspnet&#34;,
        /// &#34;backup&#34;, &#34;console&#34;, &#34;david&#34;, &#34;guest&#34;, &#34;john&#34;, &#34;owner&#34;, &#34;root&#34;, &#34;server&#34;,
        /// &#34;sql&#34;, &#34;support&#34;, &#34;support_388945a0&#34;, &#34;sys&#34;, &#34;test2&#34;, &#34;test3&#34;, &#34;user4&#34;,
        /// &#34;user5&#34;. &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:**
        /// 20 characters
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername {get; set; }

        /// <summary>
        /// Gets or sets specifies the password of the administrator account. &lt;br&gt;&lt;br&gt;
        /// **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters
        /// &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to
        /// be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a
        /// digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt;
        /// **Disallowed values:** &#34;abc@123&#34;, &#34;P@$$w0rd&#34;, &#34;P@ssw0rd&#34;, &#34;P@ssword123&#34;,
        /// &#34;Pa$$word&#34;, &#34;pass@word1&#34;, &#34;Password!&#34;, &#34;Password1&#34;, &#34;Password22&#34;,
        /// &#34;iloveyou!&#34;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword {get; set; }

        /// <summary>
        /// Gets or sets the license type to use for Windows VMs. See [Azure Hybrid
        /// User Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for
        /// more details. Possible values include: &#39;None&#39;, &#39;Windows_Server&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "licenseType")]
        public string LicenseType {get; set; }

        /// <summary>
        /// Gets or sets for more details on CSI proxy, see the [CSI proxy GitHub
        /// repo](https://github.com/kubernetes-csi/csi-proxy).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableCSIProxy")]
        public bool? EnableCsiProxy {get; set; }

        /// <summary>
        /// Gets or sets the Windows gMSA Profile in the Managed Cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "gmsaProfile")]
        public WindowsGmsaProfile GmsaProfile {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.AdminUsername == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AdminUsername");
            }




        }
    }
}