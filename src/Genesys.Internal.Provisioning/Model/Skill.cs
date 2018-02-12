/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.08.1664
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
    /// Skill
    /// </summary>
    [DataContract]
    public partial class Skill :  IEquatable<Skill>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Skill" /> class.
        /// </summary>
        /// <param name="Level">The user&#39;s skill level. This should be a positive integer in numeric or string format. If the level is equal to &#39;&#39; the skill is unassigned..</param>
        /// <param name="Name">The name of the skill..</param>
        public Skill(int? Level = default(int?), string Name = default(string))
        {
            this.Level = Level;
            this.Name = Name;
        }
        
        /// <summary>
        /// The user&#39;s skill level. This should be a positive integer in numeric or string format. If the level is equal to &#39;&#39; the skill is unassigned.
        /// </summary>
        /// <value>The user&#39;s skill level. This should be a positive integer in numeric or string format. If the level is equal to &#39;&#39; the skill is unassigned.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public int? Level { get; set; }

        /// <summary>
        /// The name of the skill.
        /// </summary>
        /// <value>The name of the skill.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Skill {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Skill);
        }

        /// <summary>
        /// Returns true if Skill instances are equal
        /// </summary>
        /// <param name="input">Instance of Skill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Skill input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
