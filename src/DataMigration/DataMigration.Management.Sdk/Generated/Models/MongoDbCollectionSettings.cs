// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Describes how an individual MongoDB collection should be migrated
    /// </summary>
    public partial class MongoDbCollectionSettings
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbCollectionSettings class.
        /// </summary>
        public MongoDbCollectionSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbCollectionSettings class.
        /// </summary>

        /// <param name="canDelete">Whether the migrator is allowed to drop the target collection in the course
        /// of performing a migration. The default is true.
        /// </param>

        /// <param name="shardKey">Describes a MongoDB shard key
        /// </param>

        /// <param name="targetRUs">The RUs that should be configured on a CosmosDB target, or null to use the
        /// default. This has no effect on non-CosmosDB targets.
        /// </param>
        public MongoDbCollectionSettings(bool? canDelete = default(bool?), MongoDbShardKeySetting shardKey = default(MongoDbShardKeySetting), int? targetRUs = default(int?))

        {
            this.CanDelete = canDelete;
            this.ShardKey = shardKey;
            this.TargetRUs = targetRUs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets whether the migrator is allowed to drop the target collection
        /// in the course of performing a migration. The default is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "canDelete")]
        public bool? CanDelete {get; set; }

        /// <summary>
        /// Gets or sets describes a MongoDB shard key
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "shardKey")]
        public MongoDbShardKeySetting ShardKey {get; set; }

        /// <summary>
        /// Gets or sets the RUs that should be configured on a CosmosDB target, or
        /// null to use the default. This has no effect on non-CosmosDB targets.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetRUs")]
        public int? TargetRUs {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ShardKey != null)
            {
                this.ShardKey.Validate();
            }
        }
    }
}