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
    /// CreateUserSuccessResponseDataPerson
    /// </summary>
    [DataContract]
    public partial class CreateUserSuccessResponseDataPerson :  IEquatable<CreateUserSuccessResponseDataPerson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserSuccessResponseDataPerson" /> class.
        /// </summary>
        /// <param name="DBID">DBID.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IsAdmin">IsAdmin.</param>
        /// <param name="IsAgent">IsAgent.</param>
        /// <param name="IsExternalAuth">IsExternalAuth.</param>
        /// <param name="PasswordHashAlgorithm">PasswordHashAlgorithm.</param>
        /// <param name="PasswordUpdatingDate">PasswordUpdatingDate.</param>
        /// <param name="State">State.</param>
        /// <param name="EmployeeID">EmployeeID.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="Password">Password.</param>
        /// <param name="TenantDBID">TenantDBID.</param>
        /// <param name="ChangePasswordOnNextLogin">ChangePasswordOnNextLogin.</param>
        /// <param name="CfgAgentInfo">CfgAgentInfo.</param>
        public CreateUserSuccessResponseDataPerson(string DBID = default(string), string Id = default(string), string IsAdmin = default(string), string IsAgent = default(string), string IsExternalAuth = default(string), string PasswordHashAlgorithm = default(string), string PasswordUpdatingDate = default(string), string State = default(string), string EmployeeID = default(string), string FirstName = default(string), string LastName = default(string), string UserName = default(string), string EmailAddress = default(string), string Password = default(string), string TenantDBID = default(string), string ChangePasswordOnNextLogin = default(string), CreateUserSuccessResponseDataPersonCfgAgentInfo CfgAgentInfo = default(CreateUserSuccessResponseDataPersonCfgAgentInfo))
        {
            this.DBID = DBID;
            this.Id = Id;
            this.IsAdmin = IsAdmin;
            this.IsAgent = IsAgent;
            this.IsExternalAuth = IsExternalAuth;
            this.PasswordHashAlgorithm = PasswordHashAlgorithm;
            this.PasswordUpdatingDate = PasswordUpdatingDate;
            this.State = State;
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserName = UserName;
            this.EmailAddress = EmailAddress;
            this.Password = Password;
            this.TenantDBID = TenantDBID;
            this.ChangePasswordOnNextLogin = ChangePasswordOnNextLogin;
            this.CfgAgentInfo = CfgAgentInfo;
        }
        
        /// <summary>
        /// Gets or Sets DBID
        /// </summary>
        [DataMember(Name="DBID", EmitDefaultValue=false)]
        public string DBID { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name="isAdmin", EmitDefaultValue=false)]
        public string IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets IsAgent
        /// </summary>
        [DataMember(Name="isAgent", EmitDefaultValue=false)]
        public string IsAgent { get; set; }

        /// <summary>
        /// Gets or Sets IsExternalAuth
        /// </summary>
        [DataMember(Name="isExternalAuth", EmitDefaultValue=false)]
        public string IsExternalAuth { get; set; }

        /// <summary>
        /// Gets or Sets PasswordHashAlgorithm
        /// </summary>
        [DataMember(Name="passwordHashAlgorithm", EmitDefaultValue=false)]
        public string PasswordHashAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets PasswordUpdatingDate
        /// </summary>
        [DataMember(Name="PasswordUpdatingDate", EmitDefaultValue=false)]
        public string PasswordUpdatingDate { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeID
        /// </summary>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public string EmployeeID { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets TenantDBID
        /// </summary>
        [DataMember(Name="tenantDBID", EmitDefaultValue=false)]
        public string TenantDBID { get; set; }

        /// <summary>
        /// Gets or Sets ChangePasswordOnNextLogin
        /// </summary>
        [DataMember(Name="changePasswordOnNextLogin", EmitDefaultValue=false)]
        public string ChangePasswordOnNextLogin { get; set; }

        /// <summary>
        /// Gets or Sets CfgAgentInfo
        /// </summary>
        [DataMember(Name="CfgAgentInfo", EmitDefaultValue=false)]
        public CreateUserSuccessResponseDataPersonCfgAgentInfo CfgAgentInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserSuccessResponseDataPerson {\n");
            sb.Append("  DBID: ").Append(DBID).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  IsAgent: ").Append(IsAgent).Append("\n");
            sb.Append("  IsExternalAuth: ").Append(IsExternalAuth).Append("\n");
            sb.Append("  PasswordHashAlgorithm: ").Append(PasswordHashAlgorithm).Append("\n");
            sb.Append("  PasswordUpdatingDate: ").Append(PasswordUpdatingDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  TenantDBID: ").Append(TenantDBID).Append("\n");
            sb.Append("  ChangePasswordOnNextLogin: ").Append(ChangePasswordOnNextLogin).Append("\n");
            sb.Append("  CfgAgentInfo: ").Append(CfgAgentInfo).Append("\n");
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
            return this.Equals(input as CreateUserSuccessResponseDataPerson);
        }

        /// <summary>
        /// Returns true if CreateUserSuccessResponseDataPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserSuccessResponseDataPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserSuccessResponseDataPerson input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DBID == input.DBID ||
                    (this.DBID != null &&
                    this.DBID.Equals(input.DBID))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.IsAgent == input.IsAgent ||
                    (this.IsAgent != null &&
                    this.IsAgent.Equals(input.IsAgent))
                ) && 
                (
                    this.IsExternalAuth == input.IsExternalAuth ||
                    (this.IsExternalAuth != null &&
                    this.IsExternalAuth.Equals(input.IsExternalAuth))
                ) && 
                (
                    this.PasswordHashAlgorithm == input.PasswordHashAlgorithm ||
                    (this.PasswordHashAlgorithm != null &&
                    this.PasswordHashAlgorithm.Equals(input.PasswordHashAlgorithm))
                ) && 
                (
                    this.PasswordUpdatingDate == input.PasswordUpdatingDate ||
                    (this.PasswordUpdatingDate != null &&
                    this.PasswordUpdatingDate.Equals(input.PasswordUpdatingDate))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.TenantDBID == input.TenantDBID ||
                    (this.TenantDBID != null &&
                    this.TenantDBID.Equals(input.TenantDBID))
                ) && 
                (
                    this.ChangePasswordOnNextLogin == input.ChangePasswordOnNextLogin ||
                    (this.ChangePasswordOnNextLogin != null &&
                    this.ChangePasswordOnNextLogin.Equals(input.ChangePasswordOnNextLogin))
                ) && 
                (
                    this.CfgAgentInfo == input.CfgAgentInfo ||
                    (this.CfgAgentInfo != null &&
                    this.CfgAgentInfo.Equals(input.CfgAgentInfo))
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
                if (this.DBID != null)
                    hashCode = hashCode * 59 + this.DBID.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.IsAgent != null)
                    hashCode = hashCode * 59 + this.IsAgent.GetHashCode();
                if (this.IsExternalAuth != null)
                    hashCode = hashCode * 59 + this.IsExternalAuth.GetHashCode();
                if (this.PasswordHashAlgorithm != null)
                    hashCode = hashCode * 59 + this.PasswordHashAlgorithm.GetHashCode();
                if (this.PasswordUpdatingDate != null)
                    hashCode = hashCode * 59 + this.PasswordUpdatingDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.TenantDBID != null)
                    hashCode = hashCode * 59 + this.TenantDBID.GetHashCode();
                if (this.ChangePasswordOnNextLogin != null)
                    hashCode = hashCode * 59 + this.ChangePasswordOnNextLogin.GetHashCode();
                if (this.CfgAgentInfo != null)
                    hashCode = hashCode * 59 + this.CfgAgentInfo.GetHashCode();
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
