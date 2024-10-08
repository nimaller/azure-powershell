// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>Details of a singular Update in HCI Cluster</summary>
    public partial class UpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json ? new UpdateProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._updateStateProperty ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) this._updateStateProperty.ToJson(null,serializationMode) : null, "updateStateProperties" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != this._installedDate ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._installedDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "installedDate" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._minSbeVersionRequired)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._minSbeVersionRequired.ToString()) : null, "minSbeVersionRequired" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            if (null != this._prerequisite)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.XNodeArray();
                foreach( var __x in this._prerequisite )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("prerequisites",__w);
            }
            if (null != this._componentVersion)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.XNodeArray();
                foreach( var __s in this._componentVersion )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("componentVersions",__r);
            }
            AddIf( null != (((object)this._rebootRequired)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._rebootRequired.ToString()) : null, "rebootRequired" ,container.Add );
            AddIf( null != (((object)this._healthState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._healthState.ToString()) : null, "healthState" ,container.Add );
            if (null != this._healthCheckResult)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.XNodeArray();
                foreach( var __n in this._healthCheckResult )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("healthCheckResult",__m);
            }
            AddIf( null != this._healthCheckDate ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._healthCheckDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "healthCheckDate" ,container.Add );
            AddIf( null != (((object)this._packagePath)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._packagePath.ToString()) : null, "packagePath" ,container.Add );
            AddIf( null != this._packageSizeInMb ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNumber((float)this._packageSizeInMb) : null, "packageSizeInMb" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            AddIf( null != (((object)this._releaseLink)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._releaseLink.ToString()) : null, "releaseLink" ,container.Add );
            AddIf( null != (((object)this._availabilityType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._availabilityType.ToString()) : null, "availabilityType" ,container.Add );
            AddIf( null != (((object)this._packageType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._packageType.ToString()) : null, "packageType" ,container.Add );
            AddIf( null != (((object)this._additionalProperty)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString(this._additionalProperty.ToString()) : null, "additionalProperties" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject into a new instance of <see cref="UpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_updateStateProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonObject>("updateStateProperties"), out var __jsonUpdateStateProperties) ? Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.UpdateStateProperties.FromJson(__jsonUpdateStateProperties) : UpdateStateProperty;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_installedDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("installedDate"), out var __jsonInstalledDate) ? global::System.DateTime.TryParse((string)__jsonInstalledDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonInstalledDateValue) ? __jsonInstalledDateValue : InstalledDate : InstalledDate;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_minSbeVersionRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("minSbeVersionRequired"), out var __jsonMinSbeVersionRequired) ? (string)__jsonMinSbeVersionRequired : (string)MinSbeVersionRequired;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_prerequisite = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray>("prerequisites"), out var __jsonPrerequisites) ? If( __jsonPrerequisites as Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdatePrerequisite[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdatePrerequisite) (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.UpdatePrerequisite.FromJson(__u) )) ))() : null : Prerequisite;}
            {_componentVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray>("componentVersions"), out var __jsonComponentVersions) ? If( __jsonComponentVersions as Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPackageVersionInfo[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPackageVersionInfo) (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.PackageVersionInfo.FromJson(__p) )) ))() : null : ComponentVersion;}
            {_rebootRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("rebootRequired"), out var __jsonRebootRequired) ? (string)__jsonRebootRequired : (string)RebootRequired;}
            {_healthState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("healthState"), out var __jsonHealthState) ? (string)__jsonHealthState : (string)HealthState;}
            {_healthCheckResult = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray>("healthCheckResult"), out var __jsonHealthCheckResult) ? If( __jsonHealthCheckResult as Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPrecheckResult[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPrecheckResult) (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.PrecheckResult.FromJson(__k) )) ))() : null : HealthCheckResult;}
            {_healthCheckDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("healthCheckDate"), out var __jsonHealthCheckDate) ? global::System.DateTime.TryParse((string)__jsonHealthCheckDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonHealthCheckDateValue) ? __jsonHealthCheckDateValue : HealthCheckDate : HealthCheckDate;}
            {_packagePath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("packagePath"), out var __jsonPackagePath) ? (string)__jsonPackagePath : (string)PackagePath;}
            {_packageSizeInMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNumber>("packageSizeInMb"), out var __jsonPackageSizeInMb) ? (float?)__jsonPackageSizeInMb : PackageSizeInMb;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)Publisher;}
            {_releaseLink = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("releaseLink"), out var __jsonReleaseLink) ? (string)__jsonReleaseLink : (string)ReleaseLink;}
            {_availabilityType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("availabilityType"), out var __jsonAvailabilityType) ? (string)__jsonAvailabilityType : (string)AvailabilityType;}
            {_packageType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("packageType"), out var __jsonPackageType) ? (string)__jsonPackageType : (string)PackageType;}
            {_additionalProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonString>("additionalProperties"), out var __jsonAdditionalProperties) ? (string)__jsonAdditionalProperties : (string)AdditionalProperty;}
            AfterFromJson(json);
        }
    }
}