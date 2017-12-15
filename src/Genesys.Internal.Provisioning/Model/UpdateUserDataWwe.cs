/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.06.1248
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
    /// Properties related to Workspace Web Edition. 
    /// </summary>
    [DataContract]
    public partial class UpdateUserDataWwe :  IEquatable<UpdateUserDataWwe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserDataWwe" /> class.
        /// </summary>
        /// <param name="Roles">The roles that are added to the user. .</param>
        /// <param name="DeletedRoles">The roles that are removed from the user. .</param>
        public UpdateUserDataWwe(List<string> Roles = default(List<string>), List<string> DeletedRoles = default(List<string>))
        {
            this.Roles = Roles;
            this.DeletedRoles = DeletedRoles;
        }
        
        /// <summary>
        /// The roles that are added to the user. 
        /// </summary>
        /// <value>The roles that are added to the user. </value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// The roles that are removed from the user. 
        /// </summary>
        /// <value>The roles that are removed from the user. </value>
        [DataMember(Name="deletedRoles", EmitDefaultValue=false)]
        public List<string> DeletedRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserDataWwe {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  DeletedRoles: ").Append(DeletedRoles).Append("\n");
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
            return this.Equals(input as UpdateUserDataWwe);
        }

        /// <summary>
        /// Returns true if UpdateUserDataWwe instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUserDataWwe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUserDataWwe input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.DeletedRoles == input.DeletedRoles ||
                    this.DeletedRoles != null &&
                    this.DeletedRoles.SequenceEqual(input.DeletedRoles)
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
                if (this.DeletedRoles != null)
                    hashCode = hashCode * 59 + this.DeletedRoles.GetHashCode();
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
