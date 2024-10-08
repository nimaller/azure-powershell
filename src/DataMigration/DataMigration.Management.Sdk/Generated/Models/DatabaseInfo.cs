// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Project Database Details
    /// </summary>
    public partial class DatabaseInfo
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseInfo class.
        /// </summary>
        public DatabaseInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseInfo class.
        /// </summary>

        /// <param name="sourceDatabaseName">Name of the database
        /// </param>
        public DatabaseInfo(string sourceDatabaseName)

        {
            this.SourceDatabaseName = sourceDatabaseName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the database
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceDatabaseName")]
        public string SourceDatabaseName {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SourceDatabaseName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SourceDatabaseName");
            }

        }
    }
}