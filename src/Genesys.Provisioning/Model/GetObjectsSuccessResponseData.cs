/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.869
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Genesys.Provisioning.Client.SwaggerDateConverter;

namespace Genesys.Provisioning.Model
{
    /// <summary>
    /// GetObjectsSuccessResponseData
    /// </summary>
    [DataContract]
    public partial class GetObjectsSuccessResponseData :  IEquatable<GetObjectsSuccessResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectsSuccessResponseData" /> class.
        /// </summary>
        /// <param name="Dns">List of DN objects fetched.</param>
        /// <param name="AgentGroups">List of Agent Group objects fetched..</param>
        /// <param name="TotalCount">Total number of object..</param>
        public GetObjectsSuccessResponseData(List<Object> Dns = default(List<Object>), List<Object> AgentGroups = default(List<Object>), int? TotalCount = default(int?))
        {
            this.Dns = Dns;
            this.AgentGroups = AgentGroups;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// List of DN objects fetched
        /// </summary>
        /// <value>List of DN objects fetched</value>
        [DataMember(Name="dns", EmitDefaultValue=false)]
        public List<Object> Dns { get; set; }

        /// <summary>
        /// List of Agent Group objects fetched.
        /// </summary>
        /// <value>List of Agent Group objects fetched.</value>
        [DataMember(Name="agent-groups", EmitDefaultValue=false)]
        public List<Object> AgentGroups { get; set; }

        /// <summary>
        /// Total number of object.
        /// </summary>
        /// <value>Total number of object.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetObjectsSuccessResponseData {\n");
            sb.Append("  Dns: ").Append(Dns).Append("\n");
            sb.Append("  AgentGroups: ").Append(AgentGroups).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GetObjectsSuccessResponseData);
        }

        /// <summary>
        /// Returns true if GetObjectsSuccessResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of GetObjectsSuccessResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetObjectsSuccessResponseData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dns == other.Dns ||
                    this.Dns != null &&
                    this.Dns.SequenceEqual(other.Dns)
                ) && 
                (
                    this.AgentGroups == other.AgentGroups ||
                    this.AgentGroups != null &&
                    this.AgentGroups.SequenceEqual(other.AgentGroups)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Dns != null)
                    hash = hash * 59 + this.Dns.GetHashCode();
                if (this.AgentGroups != null)
                    hash = hash * 59 + this.AgentGroups.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
