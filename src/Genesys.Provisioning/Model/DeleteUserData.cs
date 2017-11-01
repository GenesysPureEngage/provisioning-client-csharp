/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.877
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
    /// DeleteUserData
    /// </summary>
    [DataContract]
    public partial class DeleteUserData :  IEquatable<DeleteUserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserData" /> class.
        /// </summary>
        /// <param name="KeepPlaces">if &#39;true&#39; or absent, user&#39;s places and their DNs will not be deleted  Effect: Controls if user&#39;s places and their DNs will be deleted .</param>
        public DeleteUserData(bool? KeepPlaces = default(bool?))
        {
            this.KeepPlaces = KeepPlaces;
        }
        
        /// <summary>
        /// if &#39;true&#39; or absent, user&#39;s places and their DNs will not be deleted  Effect: Controls if user&#39;s places and their DNs will be deleted 
        /// </summary>
        /// <value>if &#39;true&#39; or absent, user&#39;s places and their DNs will not be deleted  Effect: Controls if user&#39;s places and their DNs will be deleted </value>
        [DataMember(Name="keep_places", EmitDefaultValue=false)]
        public bool? KeepPlaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteUserData {\n");
            sb.Append("  KeepPlaces: ").Append(KeepPlaces).Append("\n");
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
            return this.Equals(input as DeleteUserData);
        }

        /// <summary>
        /// Returns true if DeleteUserData instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteUserData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeepPlaces == input.KeepPlaces ||
                    (this.KeepPlaces != null &&
                    this.KeepPlaces.Equals(input.KeepPlaces))
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
                if (this.KeepPlaces != null)
                    hashCode = hashCode * 59 + this.KeepPlaces.GetHashCode();
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
