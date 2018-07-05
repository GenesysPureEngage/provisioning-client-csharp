/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.22.2423
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
    /// ModifyOptionsDataData
    /// </summary>
    [DataContract]
    public partial class ModifyOptionsDataData :  IEquatable<ModifyOptionsDataData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyOptionsDataData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyOptionsDataData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyOptionsDataData" /> class.
        /// </summary>
        /// <param name="Application">The name of the application where the options should be updated. This value is set to CloudCluster by default. .</param>
        /// <param name="Options">The new options to add to the application.  (required).</param>
        public ModifyOptionsDataData(string Application = default(string), Object Options = default(Object))
        {
            // to ensure "Options" is required (not null)
            if (Options == null)
            {
                throw new InvalidDataException("Options is a required property for ModifyOptionsDataData and cannot be null");
            }
            else
            {
                this.Options = Options;
            }
            this.Application = Application;
        }
        
        /// <summary>
        /// The name of the application where the options should be updated. This value is set to CloudCluster by default. 
        /// </summary>
        /// <value>The name of the application where the options should be updated. This value is set to CloudCluster by default. </value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }

        /// <summary>
        /// The new options to add to the application. 
        /// </summary>
        /// <value>The new options to add to the application. </value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Object Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyOptionsDataData {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(obj as ModifyOptionsDataData);
        }

        /// <summary>
        /// Returns true if ModifyOptionsDataData instances are equal
        /// </summary>
        /// <param name="other">Instance of ModifyOptionsDataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyOptionsDataData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
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
                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
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
