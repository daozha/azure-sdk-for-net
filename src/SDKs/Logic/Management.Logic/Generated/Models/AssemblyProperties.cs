// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The assembly properties definition.
    /// </summary>
    public partial class AssemblyProperties : ArtifactContentPropertiesDefinition
    {
        /// <summary>
        /// Initializes a new instance of the AssemblyProperties class.
        /// </summary>
        public AssemblyProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssemblyProperties class.
        /// </summary>
        /// <param name="assemblyName">The assembly name.</param>
        /// <param name="createdTime">The artifact creation time.</param>
        /// <param name="changedTime">The artifact changed time.</param>
        /// <param name="contentType">The content type.</param>
        /// <param name="contentLink">The content link.</param>
        /// <param name="assemblyVersion">The assembly version.</param>
        /// <param name="assemblyCulture">The assembly culture.</param>
        /// <param name="assemblyPublicKeyToken">The assembly public key
        /// token.</param>
        public AssemblyProperties(string assemblyName, System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), object metadata = default(object), object content = default(object), string contentType = default(string), ContentLink contentLink = default(ContentLink), string assemblyVersion = default(string), string assemblyCulture = default(string), string assemblyPublicKeyToken = default(string))
            : base(createdTime, changedTime, metadata, content, contentType, contentLink)
        {
            AssemblyName = assemblyName;
            AssemblyVersion = assemblyVersion;
            AssemblyCulture = assemblyCulture;
            AssemblyPublicKeyToken = assemblyPublicKeyToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the assembly name.
        /// </summary>
        [JsonProperty(PropertyName = "assemblyName")]
        public string AssemblyName { get; set; }

        /// <summary>
        /// Gets or sets the assembly version.
        /// </summary>
        [JsonProperty(PropertyName = "assemblyVersion")]
        public string AssemblyVersion { get; set; }

        /// <summary>
        /// Gets or sets the assembly culture.
        /// </summary>
        [JsonProperty(PropertyName = "assemblyCulture")]
        public string AssemblyCulture { get; set; }

        /// <summary>
        /// Gets or sets the assembly public key token.
        /// </summary>
        [JsonProperty(PropertyName = "assemblyPublicKeyToken")]
        public string AssemblyPublicKeyToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AssemblyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssemblyName");
            }
        }
    }
}
