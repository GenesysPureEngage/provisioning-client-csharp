/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.26.2572
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
    /// CreateUserSuccessResponseDataPersonCfgAgentInfo
    /// </summary>
    [DataContract]
    public partial class CreateUserSuccessResponseDataPersonCfgAgentInfo :  IEquatable<CreateUserSuccessResponseDataPersonCfgAgentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserSuccessResponseDataPersonCfgAgentInfo" /> class.
        /// </summary>
        /// <param name="PlaceDBID">PlaceDBID.</param>
        /// <param name="SiteDBID">SiteDBID.</param>
        /// <param name="ContractDBID">ContractDBID.</param>
        /// <param name="CapacityRuleDBID">CapacityRuleDBID.</param>
        public CreateUserSuccessResponseDataPersonCfgAgentInfo(string PlaceDBID = default(string), string SiteDBID = default(string), string ContractDBID = default(string), string CapacityRuleDBID = default(string))
        {
            this.PlaceDBID = PlaceDBID;
            this.SiteDBID = SiteDBID;
            this.ContractDBID = ContractDBID;
            this.CapacityRuleDBID = CapacityRuleDBID;
        }
        
        /// <summary>
        /// Gets or Sets PlaceDBID
        /// </summary>
        [DataMember(Name="placeDBID", EmitDefaultValue=false)]
        public string PlaceDBID { get; set; }

        /// <summary>
        /// Gets or Sets SiteDBID
        /// </summary>
        [DataMember(Name="siteDBID", EmitDefaultValue=false)]
        public string SiteDBID { get; set; }

        /// <summary>
        /// Gets or Sets ContractDBID
        /// </summary>
        [DataMember(Name="contractDBID", EmitDefaultValue=false)]
        public string ContractDBID { get; set; }

        /// <summary>
        /// Gets or Sets CapacityRuleDBID
        /// </summary>
        [DataMember(Name="capacityRuleDBID", EmitDefaultValue=false)]
        public string CapacityRuleDBID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserSuccessResponseDataPersonCfgAgentInfo {\n");
            sb.Append("  PlaceDBID: ").Append(PlaceDBID).Append("\n");
            sb.Append("  SiteDBID: ").Append(SiteDBID).Append("\n");
            sb.Append("  ContractDBID: ").Append(ContractDBID).Append("\n");
            sb.Append("  CapacityRuleDBID: ").Append(CapacityRuleDBID).Append("\n");
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
            return this.Equals(input as CreateUserSuccessResponseDataPersonCfgAgentInfo);
        }

        /// <summary>
        /// Returns true if CreateUserSuccessResponseDataPersonCfgAgentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserSuccessResponseDataPersonCfgAgentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserSuccessResponseDataPersonCfgAgentInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlaceDBID == input.PlaceDBID ||
                    (this.PlaceDBID != null &&
                    this.PlaceDBID.Equals(input.PlaceDBID))
                ) && 
                (
                    this.SiteDBID == input.SiteDBID ||
                    (this.SiteDBID != null &&
                    this.SiteDBID.Equals(input.SiteDBID))
                ) && 
                (
                    this.ContractDBID == input.ContractDBID ||
                    (this.ContractDBID != null &&
                    this.ContractDBID.Equals(input.ContractDBID))
                ) && 
                (
                    this.CapacityRuleDBID == input.CapacityRuleDBID ||
                    (this.CapacityRuleDBID != null &&
                    this.CapacityRuleDBID.Equals(input.CapacityRuleDBID))
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
                if (this.PlaceDBID != null)
                    hashCode = hashCode * 59 + this.PlaceDBID.GetHashCode();
                if (this.SiteDBID != null)
                    hashCode = hashCode * 59 + this.SiteDBID.GetHashCode();
                if (this.ContractDBID != null)
                    hashCode = hashCode * 59 + this.ContractDBID.GetHashCode();
                if (this.CapacityRuleDBID != null)
                    hashCode = hashCode * 59 + this.CapacityRuleDBID.GetHashCode();
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
