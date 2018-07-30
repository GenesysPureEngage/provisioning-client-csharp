/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.24.2505
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
using SwaggerDateConverter = Genesys.Internal.Provisioning.Client.SwaggerDateConverter;

namespace Genesys.Internal.Provisioning.Model
{
    /// <summary>
    /// A map containing parameters to filter and sort users. Only users that match the filter are exported. 
    /// </summary>
    [DataContract]
    public partial class ExportFileDataFilterParameters :  IEquatable<ExportFileDataFilterParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportFileDataFilterParameters" /> class.
        /// </summary>
        /// <param name="AgentGroupFilter">An array of agent group names in which the user is included..</param>
        /// <param name="Order">The sort order, either Ascending or Descending..</param>
        /// <param name="SortBy">A comma-separated list of fields used to sort the exported users..</param>
        /// <param name="Subresources">A comma-separated list of subresources (for example, skills) to include in the export. (default to &quot;skills,devices&quot;).</param>
        public ExportFileDataFilterParameters(List<string> AgentGroupFilter = default(List<string>), string Order = default(string), List<string> SortBy = default(List<string>), string Subresources = "skills,devices")
        {
            this.AgentGroupFilter = AgentGroupFilter;
            this.Order = Order;
            this.SortBy = SortBy;
            // use default value if no "Subresources" provided
            if (Subresources == null)
            {
                this.Subresources = "skills,devices";
            }
            else
            {
                this.Subresources = Subresources;
            }
        }
        
        /// <summary>
        /// An array of agent group names in which the user is included.
        /// </summary>
        /// <value>An array of agent group names in which the user is included.</value>
        [DataMember(Name="agentGroupFilter", EmitDefaultValue=false)]
        public List<string> AgentGroupFilter { get; set; }

        /// <summary>
        /// The sort order, either Ascending or Descending.
        /// </summary>
        /// <value>The sort order, either Ascending or Descending.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }

        /// <summary>
        /// A comma-separated list of fields used to sort the exported users.
        /// </summary>
        /// <value>A comma-separated list of fields used to sort the exported users.</value>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public List<string> SortBy { get; set; }

        /// <summary>
        /// A comma-separated list of subresources (for example, skills) to include in the export.
        /// </summary>
        /// <value>A comma-separated list of subresources (for example, skills) to include in the export.</value>
        [DataMember(Name="subresources", EmitDefaultValue=false)]
        public string Subresources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportFileDataFilterParameters {\n");
            sb.Append("  AgentGroupFilter: ").Append(AgentGroupFilter).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  Subresources: ").Append(Subresources).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportFileDataFilterParameters);
        }

        /// <summary>
        /// Returns true if ExportFileDataFilterParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportFileDataFilterParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportFileDataFilterParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentGroupFilter == input.AgentGroupFilter ||
                    this.AgentGroupFilter != null &&
                    this.AgentGroupFilter.SequenceEqual(input.AgentGroupFilter)
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.SequenceEqual(input.SortBy)
                ) && 
                (
                    this.Subresources == input.Subresources ||
                    (this.Subresources != null &&
                    this.Subresources.Equals(input.Subresources))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AgentGroupFilter != null)
                    hashCode = hashCode * 59 + this.AgentGroupFilter.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.Subresources != null)
                    hashCode = hashCode * 59 + this.Subresources.GetHashCode();
                return hashCode;
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
