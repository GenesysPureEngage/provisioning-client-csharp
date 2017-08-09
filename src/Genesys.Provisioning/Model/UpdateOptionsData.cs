/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.806
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
    /// UpdateOptionsData
    /// </summary>
    [DataContract]
    public partial class UpdateOptionsData :  IEquatable<UpdateOptionsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOptionsData" /> class.
        /// </summary>
        /// <param name="NewOptions">New CloudCluster app Options.  Effect: Adds sections, keys and values in CloudCluster/Options .</param>
        /// <param name="ChangedOptions">Changed CloudCluster app Options.  Effect: Updates existing values in CloudCluster/Options .</param>
        /// <param name="DeletedOptions">Deleted CloudCluster app Options.  Effect: Deletes sections, keys and values in CloudCluster/Options .</param>
        public UpdateOptionsData(Object NewOptions = default(Object), Object ChangedOptions = default(Object), Object DeletedOptions = default(Object))
        {
            this.NewOptions = NewOptions;
            this.ChangedOptions = ChangedOptions;
            this.DeletedOptions = DeletedOptions;
        }
        
        /// <summary>
        /// New CloudCluster app Options.  Effect: Adds sections, keys and values in CloudCluster/Options 
        /// </summary>
        /// <value>New CloudCluster app Options.  Effect: Adds sections, keys and values in CloudCluster/Options </value>
        [DataMember(Name="newOptions", EmitDefaultValue=false)]
        public Object NewOptions { get; set; }

        /// <summary>
        /// Changed CloudCluster app Options.  Effect: Updates existing values in CloudCluster/Options 
        /// </summary>
        /// <value>Changed CloudCluster app Options.  Effect: Updates existing values in CloudCluster/Options </value>
        [DataMember(Name="changedOptions", EmitDefaultValue=false)]
        public Object ChangedOptions { get; set; }

        /// <summary>
        /// Deleted CloudCluster app Options.  Effect: Deletes sections, keys and values in CloudCluster/Options 
        /// </summary>
        /// <value>Deleted CloudCluster app Options.  Effect: Deletes sections, keys and values in CloudCluster/Options </value>
        [DataMember(Name="deletedOptions", EmitDefaultValue=false)]
        public Object DeletedOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOptionsData {\n");
            sb.Append("  NewOptions: ").Append(NewOptions).Append("\n");
            sb.Append("  ChangedOptions: ").Append(ChangedOptions).Append("\n");
            sb.Append("  DeletedOptions: ").Append(DeletedOptions).Append("\n");
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
            return this.Equals(obj as UpdateOptionsData);
        }

        /// <summary>
        /// Returns true if UpdateOptionsData instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateOptionsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOptionsData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NewOptions == other.NewOptions ||
                    this.NewOptions != null &&
                    this.NewOptions.Equals(other.NewOptions)
                ) && 
                (
                    this.ChangedOptions == other.ChangedOptions ||
                    this.ChangedOptions != null &&
                    this.ChangedOptions.Equals(other.ChangedOptions)
                ) && 
                (
                    this.DeletedOptions == other.DeletedOptions ||
                    this.DeletedOptions != null &&
                    this.DeletedOptions.Equals(other.DeletedOptions)
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
                if (this.NewOptions != null)
                    hash = hash * 59 + this.NewOptions.GetHashCode();
                if (this.ChangedOptions != null)
                    hash = hash * 59 + this.ChangedOptions.GetHashCode();
                if (this.DeletedOptions != null)
                    hash = hash * 59 + this.DeletedOptions.GetHashCode();
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
