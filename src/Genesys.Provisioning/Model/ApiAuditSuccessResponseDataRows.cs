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
    /// Object describing one audit line
    /// </summary>
    [DataContract]
    public partial class ApiAuditSuccessResponseDataRows :  IEquatable<ApiAuditSuccessResponseDataRows>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAuditSuccessResponseDataRows" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiAuditSuccessResponseDataRows() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAuditSuccessResponseDataRows" /> class.
        /// </summary>
        /// <param name="Id">Database ID of Audit log line (required).</param>
        /// <param name="Createdat">Audit log line create time (required).</param>
        /// <param name="Username">User name for audit action in domain\\login format (required).</param>
        /// <param name="Level">Audit level (info, error) (required) (default to &quot;info&quot;).</param>
        /// <param name="Msg">Audit message (required).</param>
        /// <param name="Extradata">Additional Audit data.</param>
        public ApiAuditSuccessResponseDataRows(decimal? Id = default(decimal?), string Createdat = default(string), string Username = default(string), string Level = "info", string Msg = default(string), Object Extradata = default(Object))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ApiAuditSuccessResponseDataRows and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Createdat" is required (not null)
            if (Createdat == null)
            {
                throw new InvalidDataException("Createdat is a required property for ApiAuditSuccessResponseDataRows and cannot be null");
            }
            else
            {
                this.Createdat = Createdat;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for ApiAuditSuccessResponseDataRows and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "Level" is required (not null)
            if (Level == null)
            {
                throw new InvalidDataException("Level is a required property for ApiAuditSuccessResponseDataRows and cannot be null");
            }
            else
            {
                this.Level = Level;
            }
            // to ensure "Msg" is required (not null)
            if (Msg == null)
            {
                throw new InvalidDataException("Msg is a required property for ApiAuditSuccessResponseDataRows and cannot be null");
            }
            else
            {
                this.Msg = Msg;
            }
            this.Extradata = Extradata;
        }
        
        /// <summary>
        /// Database ID of Audit log line
        /// </summary>
        /// <value>Database ID of Audit log line</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Audit log line create time
        /// </summary>
        /// <value>Audit log line create time</value>
        [DataMember(Name="createdat", EmitDefaultValue=false)]
        public string Createdat { get; set; }

        /// <summary>
        /// User name for audit action in domain\\login format
        /// </summary>
        /// <value>User name for audit action in domain\\login format</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Audit level (info, error)
        /// </summary>
        /// <value>Audit level (info, error)</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }

        /// <summary>
        /// Audit message
        /// </summary>
        /// <value>Audit message</value>
        [DataMember(Name="msg", EmitDefaultValue=false)]
        public string Msg { get; set; }

        /// <summary>
        /// Additional Audit data
        /// </summary>
        /// <value>Additional Audit data</value>
        [DataMember(Name="extradata", EmitDefaultValue=false)]
        public Object Extradata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiAuditSuccessResponseDataRows {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Createdat: ").Append(Createdat).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Extradata: ").Append(Extradata).Append("\n");
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
            return this.Equals(input as ApiAuditSuccessResponseDataRows);
        }

        /// <summary>
        /// Returns true if ApiAuditSuccessResponseDataRows instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiAuditSuccessResponseDataRows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiAuditSuccessResponseDataRows input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Createdat == input.Createdat ||
                    (this.Createdat != null &&
                    this.Createdat.Equals(input.Createdat))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.Extradata == input.Extradata ||
                    (this.Extradata != null &&
                    this.Extradata.Equals(input.Extradata))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Createdat != null)
                    hashCode = hashCode * 59 + this.Createdat.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Msg != null)
                    hashCode = hashCode * 59 + this.Msg.GetHashCode();
                if (this.Extradata != null)
                    hashCode = hashCode * 59 + this.Extradata.GetHashCode();
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
