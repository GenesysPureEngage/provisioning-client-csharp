/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.05.1220
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
    /// Properties related to Workspace Web Edition. 
    /// </summary>
    [DataContract]
    public partial class AddUserDataWwe :  IEquatable<AddUserDataWwe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserDataWwe" /> class.
        /// </summary>
        /// <param name="Roles">The roles that are added to the user. If **isAgent** is &#x60;true&#x60;, then you should set this field to &#x60;ROLE_AGENT&#x60;. .</param>
        public AddUserDataWwe(List<string> Roles = default(List<string>))
        {
            this.Roles = Roles;
        }
        
        /// <summary>
        /// The roles that are added to the user. If **isAgent** is &#x60;true&#x60;, then you should set this field to &#x60;ROLE_AGENT&#x60;. 
        /// </summary>
        /// <value>The roles that are added to the user. If **isAgent** is &#x60;true&#x60;, then you should set this field to &#x60;ROLE_AGENT&#x60;. </value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddUserDataWwe {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as AddUserDataWwe);
        }

        /// <summary>
        /// Returns true if AddUserDataWwe instances are equal
        /// </summary>
        /// <param name="input">Instance of AddUserDataWwe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddUserDataWwe input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
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
