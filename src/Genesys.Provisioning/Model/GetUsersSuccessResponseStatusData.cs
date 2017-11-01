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
    /// GetUsersSuccessResponseStatusData
    /// </summary>
    [DataContract]
    public partial class GetUsersSuccessResponseStatusData :  IEquatable<GetUsersSuccessResponseStatusData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersSuccessResponseStatusData" /> class.
        /// </summary>
        /// <param name="Users">List of user objects fetched if dbid parameter is absent..</param>
        /// <param name="User">User object fetched if dbid parameter is a person DBID or &#39;me&#39;..</param>
        /// <param name="TotalCount">Total number of users. Available if dbid parameter is absent..</param>
        public GetUsersSuccessResponseStatusData(List<Object> Users = default(List<Object>), Object User = default(Object), int? TotalCount = default(int?))
        {
            this.Users = Users;
            this.User = User;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// List of user objects fetched if dbid parameter is absent.
        /// </summary>
        /// <value>List of user objects fetched if dbid parameter is absent.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<Object> Users { get; set; }

        /// <summary>
        /// User object fetched if dbid parameter is a person DBID or &#39;me&#39;.
        /// </summary>
        /// <value>User object fetched if dbid parameter is a person DBID or &#39;me&#39;.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public Object User { get; set; }

        /// <summary>
        /// Total number of users. Available if dbid parameter is absent.
        /// </summary>
        /// <value>Total number of users. Available if dbid parameter is absent.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUsersSuccessResponseStatusData {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetUsersSuccessResponseStatusData);
        }

        /// <summary>
        /// Returns true if GetUsersSuccessResponseStatusData instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUsersSuccessResponseStatusData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUsersSuccessResponseStatusData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
