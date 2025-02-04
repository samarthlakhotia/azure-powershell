// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Properties of an allowed environment type.</summary>
    public partial class AllowedEnvironmentTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IAllowedEnvironmentTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IAllowedEnvironmentTypePropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IAllowedEnvironmentTypePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="AllowedEnvironmentTypeProperties" /> instance.</summary>
        public AllowedEnvironmentTypeProperties()
        {

        }
    }
    /// Properties of an allowed environment type.
    public partial interface IAllowedEnvironmentTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Properties of an allowed environment type.
    internal partial interface IAllowedEnvironmentTypePropertiesInternal

    {
        /// <summary>The provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}