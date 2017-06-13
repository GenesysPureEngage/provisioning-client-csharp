/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model.  The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.423
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// UsersGetResponseStatusSuccessDataSkills
    /// </summary>
    [DataContract]
    public partial class UsersGetResponseStatusSuccessDataSkills :  IEquatable<UsersGetResponseStatusSuccessDataSkills>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersGetResponseStatusSuccessDataSkills" /> class.
        /// </summary>
        /// <param name="DBID">DBID.</param>
        /// <param name="Name">Name.</param>
        public UsersGetResponseStatusSuccessDataSkills(string DBID = default(string), string Name = default(string))
        {
            this.DBID = DBID;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets DBID
        /// </summary>
        [DataMember(Name="DBID", EmitDefaultValue=false)]
        public string DBID { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersGetResponseStatusSuccessDataSkills {\n");
            sb.Append("  DBID: ").Append(DBID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as UsersGetResponseStatusSuccessDataSkills);
        }

        /// <summary>
        /// Returns true if UsersGetResponseStatusSuccessDataSkills instances are equal
        /// </summary>
        /// <param name="other">Instance of UsersGetResponseStatusSuccessDataSkills to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersGetResponseStatusSuccessDataSkills other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DBID == other.DBID ||
                    this.DBID != null &&
                    this.DBID.Equals(other.DBID)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.DBID != null)
                    hash = hash * 59 + this.DBID.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
