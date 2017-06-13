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
    /// UsersPost
    /// </summary>
    [DataContract]
    public partial class UsersPost :  IEquatable<UsersPost>, IValidatableObject
    {
        /// <summary>
        /// Specifies the sip phone typed if supportSoftPhone = true.  Effect: Specifies  the sip phone type and corresponding annex to be written to the DN's \"TServer\" section 
        /// </summary>
        /// <value>Specifies the sip phone typed if supportSoftPhone = true.  Effect: Specifies  the sip phone type and corresponding annex to be written to the DN's \"TServer\" section </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SipPhoneTypeEnum
        {
            
            /// <summary>
            /// Enum DISABLECTI for "DISABLE_CTI"
            /// </summary>
            [EnumMember(Value = "DISABLE_CTI")]
            DISABLECTI,
            
            /// <summary>
            /// Enum GENESYSSOFTPHONE for "GENESYS_SOFTPHONE"
            /// </summary>
            [EnumMember(Value = "GENESYS_SOFTPHONE")]
            GENESYSSOFTPHONE,
            
            /// <summary>
            /// Enum GENESYS420HTAUDIOCODES4xxHD for "GENESYS_420HT_AUDIOCODES_4xxHD"
            /// </summary>
            [EnumMember(Value = "GENESYS_420HT_AUDIOCODES_4xxHD")]
            GENESYS420HTAUDIOCODES4xxHD,
            
            /// <summary>
            /// Enum GENERICPHONE for "GENERIC_PHONE"
            /// </summary>
            [EnumMember(Value = "GENERIC_PHONE")]
            GENERICPHONE
        }

        /// <summary>
        /// Specifies the sip phone typed if supportSoftPhone = true.  Effect: Specifies  the sip phone type and corresponding annex to be written to the DN's \"TServer\" section 
        /// </summary>
        /// <value>Specifies the sip phone typed if supportSoftPhone = true.  Effect: Specifies  the sip phone type and corresponding annex to be written to the DN's \"TServer\" section </value>
        [DataMember(Name="sipPhoneType", EmitDefaultValue=false)]
        public SipPhoneTypeEnum? SipPhoneType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsersPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersPost" /> class.
        /// </summary>
        /// <param name="ChangePasswordOnNextLogin">if &#39;true&#39;, user will be asked to change password on first login.  Effect: Controls the value of the corresponding CfgPerson attribute  (default to false).</param>
        /// <param name="EmailAddress">User&#39;s email.  Effect: Controls the value of the corresponding CfgPerson attribute  (default to &quot;test@email.com&quot;).</param>
        /// <param name="EmployeeID">user&#39;s Employee ID.  Effect: Controls the value of the corresponding CfgPerson attribute  (default to &quot;empid123&quot;).</param>
        /// <param name="ExternalID">External ID.  Effect: Controls the value of the corresponding CfgPerson attribute  (default to &quot;extid123&quot;).</param>
        /// <param name="Enabled">User is enabled or disabled.  Effect: Controls the value of the corresponding CfgPerson attribute  (default to true).</param>
        /// <param name="UserName">User unique login.  Effect: Controls the value of the corresponding CfgPerson attribute  (required) (default to &quot;username123&quot;).</param>
        /// <param name="FirstName">User&#39;s first name.  Effect: Controls the value of the corresponding CfgPerson attribute  (required) (default to &quot;firstname123&quot;).</param>
        /// <param name="LastName">User&#39;s last name.  Effect: Controls the value of the corresponding CfgPerson attribute  (required) (default to &quot;lastname123&quot;).</param>
        /// <param name="LoginCode">The user&#39;s login code.  Effect: A corresponding CfgAgentLogin will be created on all switches in the \&quot;switchNames\&quot; collection. It will then be assigned to the CfgPerson that&#39;s being created. .</param>
        /// <param name="Password">Password as plain text.  Effect: Controls the value of the corresponding CfgPerson attribute  (required) (default to &quot;usefname123&quot;).</param>
        /// <param name="MultimediaPlaceName">Place name for multimedia-only agents .</param>
        /// <param name="PlaceNames">A list of places available to the user (for multimedia only users). Effect: The list is written to the current CfgPerson&#39;s \&quot;htcc\&quot; annex. e.g. CfgPerson/userProperties/htcc/place &#x3D; p1, p2, p3 .</param>
        /// <param name="Roles">The roles that will be added to the user. .</param>
        /// <param name="SwitchNames">The switch names that the user will work on.  Effect: A list of switches where the user&#39;s telephony objects will be created (i.e. dns, agent logins) .</param>
        /// <param name="Phones">A list of phone number descriptors used to create the user&#39;s DNs.  Effect: For each phone number, a corresponding DN will be created on all of the switches specified by \&quot;switchNames\&quot; and assigned to the specified place. .</param>
        /// <param name="SupportSoftPhone">Enable SIP Phone, true/false.  Effect: Writes corresponding information to the TServer annex of the created DNs (see sipPhoneType)  (default to false).</param>
        /// <param name="SipPhoneType">Specifies the sip phone typed if supportSoftPhone &#x3D; true.  Effect: Specifies  the sip phone type and corresponding annex to be written to the DN&#39;s \&quot;TServer\&quot; section  (default to SipPhoneTypeEnum.DISABLECTI).</param>
        /// <param name="Skills">List of Skills to assign to the user.  Effect: The list contains a collection of skill descriptors. If the corresponding skill is found, it is assigned to the user with the specified level. If it is not found, the skill is created and then assigned. .</param>
        /// <param name="AgentGroups">List of agent groups that the user should be assigned to.  Effect: The user will be assigned to each group that already exists. If a particular group is not already in the system it will be created. .</param>
        /// <param name="AccessGroups">List of access groups that the user should belong to.  Effect: The user will be assigned to each group that can be located. If a group does not already exist, it will NOT be created. .</param>
        /// <param name="VoiceMail">User&#39;s Voice Mail. Effect: Written to the user&#39;s CfgAgentLogin.userProperties.TServer.gvm_mailbox .</param>
        /// <param name="WrapUpTime">User&#39;s Wrap Up Time.  Effect: Configured for each CfgAgentLogin  (default to &quot;123&quot;).</param>
        public UsersPost(bool? ChangePasswordOnNextLogin = false, string EmailAddress = "test@email.com", string EmployeeID = "empid123", string ExternalID = "extid123", bool? Enabled = true, string UserName = "username123", string FirstName = "firstname123", string LastName = "lastname123", string LoginCode = default(string), string Password = "usefname123", string MultimediaPlaceName = default(string), List<string> PlaceNames = default(List<string>), List<string> Roles = default(List<string>), List<string> SwitchNames = default(List<string>), List<Extension> Phones = default(List<Extension>), bool? SupportSoftPhone = false, SipPhoneTypeEnum? SipPhoneType = SipPhoneTypeEnum.DISABLECTI, List<Skill> Skills = default(List<Skill>), List<string> AgentGroups = default(List<string>), List<string> AccessGroups = default(List<string>), decimal? VoiceMail = default(decimal?), string WrapUpTime = "123")
        {
            // to ensure "UserName" is required (not null)
            if (UserName == null)
            {
                throw new InvalidDataException("UserName is a required property for UsersPost and cannot be null");
            }
            else
            {
                this.UserName = UserName;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for UsersPost and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for UsersPost and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for UsersPost and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // use default value if no "ChangePasswordOnNextLogin" provided
            if (ChangePasswordOnNextLogin == null)
            {
                this.ChangePasswordOnNextLogin = false;
            }
            else
            {
                this.ChangePasswordOnNextLogin = ChangePasswordOnNextLogin;
            }
            // use default value if no "EmailAddress" provided
            if (EmailAddress == null)
            {
                this.EmailAddress = "test@email.com";
            }
            else
            {
                this.EmailAddress = EmailAddress;
            }
            // use default value if no "EmployeeID" provided
            if (EmployeeID == null)
            {
                this.EmployeeID = "empid123";
            }
            else
            {
                this.EmployeeID = EmployeeID;
            }
            // use default value if no "ExternalID" provided
            if (ExternalID == null)
            {
                this.ExternalID = "extid123";
            }
            else
            {
                this.ExternalID = ExternalID;
            }
            // use default value if no "Enabled" provided
            if (Enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = Enabled;
            }
            this.LoginCode = LoginCode;
            this.MultimediaPlaceName = MultimediaPlaceName;
            this.PlaceNames = PlaceNames;
            this.Roles = Roles;
            this.SwitchNames = SwitchNames;
            this.Phones = Phones;
            // use default value if no "SupportSoftPhone" provided
            if (SupportSoftPhone == null)
            {
                this.SupportSoftPhone = false;
            }
            else
            {
                this.SupportSoftPhone = SupportSoftPhone;
            }
            // use default value if no "SipPhoneType" provided
            if (SipPhoneType == null)
            {
                this.SipPhoneType = SipPhoneTypeEnum.DISABLECTI;
            }
            else
            {
                this.SipPhoneType = SipPhoneType;
            }
            this.Skills = Skills;
            this.AgentGroups = AgentGroups;
            this.AccessGroups = AccessGroups;
            this.VoiceMail = VoiceMail;
            // use default value if no "WrapUpTime" provided
            if (WrapUpTime == null)
            {
                this.WrapUpTime = "123";
            }
            else
            {
                this.WrapUpTime = WrapUpTime;
            }
        }
        
        /// <summary>
        /// if &#39;true&#39;, user will be asked to change password on first login.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>if &#39;true&#39;, user will be asked to change password on first login.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="changePasswordOnNextLogin", EmitDefaultValue=false)]
        public bool? ChangePasswordOnNextLogin { get; set; }
        /// <summary>
        /// User&#39;s email.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>User&#39;s email.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// user&#39;s Employee ID.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>user&#39;s Employee ID.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public string EmployeeID { get; set; }
        /// <summary>
        /// External ID.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>External ID.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="externalID", EmitDefaultValue=false)]
        public string ExternalID { get; set; }
        /// <summary>
        /// User is enabled or disabled.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>User is enabled or disabled.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// User unique login.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>User unique login.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// User&#39;s first name.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>User&#39;s first name.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// User&#39;s last name.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>User&#39;s last name.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// The user&#39;s login code.  Effect: A corresponding CfgAgentLogin will be created on all switches in the \&quot;switchNames\&quot; collection. It will then be assigned to the CfgPerson that&#39;s being created. 
        /// </summary>
        /// <value>The user&#39;s login code.  Effect: A corresponding CfgAgentLogin will be created on all switches in the \&quot;switchNames\&quot; collection. It will then be assigned to the CfgPerson that&#39;s being created. </value>
        [DataMember(Name="loginCode", EmitDefaultValue=false)]
        public string LoginCode { get; set; }
        /// <summary>
        /// Password as plain text.  Effect: Controls the value of the corresponding CfgPerson attribute 
        /// </summary>
        /// <value>Password as plain text.  Effect: Controls the value of the corresponding CfgPerson attribute </value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Place name for multimedia-only agents 
        /// </summary>
        /// <value>Place name for multimedia-only agents </value>
        [DataMember(Name="multimediaPlaceName", EmitDefaultValue=false)]
        public string MultimediaPlaceName { get; set; }
        /// <summary>
        /// A list of places available to the user (for multimedia only users). Effect: The list is written to the current CfgPerson&#39;s \&quot;htcc\&quot; annex. e.g. CfgPerson/userProperties/htcc/place &#x3D; p1, p2, p3 
        /// </summary>
        /// <value>A list of places available to the user (for multimedia only users). Effect: The list is written to the current CfgPerson&#39;s \&quot;htcc\&quot; annex. e.g. CfgPerson/userProperties/htcc/place &#x3D; p1, p2, p3 </value>
        [DataMember(Name="placeNames", EmitDefaultValue=false)]
        public List<string> PlaceNames { get; set; }
        /// <summary>
        /// The roles that will be added to the user. 
        /// </summary>
        /// <value>The roles that will be added to the user. </value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// The switch names that the user will work on.  Effect: A list of switches where the user&#39;s telephony objects will be created (i.e. dns, agent logins) 
        /// </summary>
        /// <value>The switch names that the user will work on.  Effect: A list of switches where the user&#39;s telephony objects will be created (i.e. dns, agent logins) </value>
        [DataMember(Name="switchNames", EmitDefaultValue=false)]
        public List<string> SwitchNames { get; set; }
        /// <summary>
        /// A list of phone number descriptors used to create the user&#39;s DNs.  Effect: For each phone number, a corresponding DN will be created on all of the switches specified by \&quot;switchNames\&quot; and assigned to the specified place. 
        /// </summary>
        /// <value>A list of phone number descriptors used to create the user&#39;s DNs.  Effect: For each phone number, a corresponding DN will be created on all of the switches specified by \&quot;switchNames\&quot; and assigned to the specified place. </value>
        [DataMember(Name="phones", EmitDefaultValue=false)]
        public List<Extension> Phones { get; set; }
        /// <summary>
        /// Enable SIP Phone, true/false.  Effect: Writes corresponding information to the TServer annex of the created DNs (see sipPhoneType) 
        /// </summary>
        /// <value>Enable SIP Phone, true/false.  Effect: Writes corresponding information to the TServer annex of the created DNs (see sipPhoneType) </value>
        [DataMember(Name="supportSoftPhone", EmitDefaultValue=false)]
        public bool? SupportSoftPhone { get; set; }
        /// <summary>
        /// List of Skills to assign to the user.  Effect: The list contains a collection of skill descriptors. If the corresponding skill is found, it is assigned to the user with the specified level. If it is not found, the skill is created and then assigned. 
        /// </summary>
        /// <value>List of Skills to assign to the user.  Effect: The list contains a collection of skill descriptors. If the corresponding skill is found, it is assigned to the user with the specified level. If it is not found, the skill is created and then assigned. </value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<Skill> Skills { get; set; }
        /// <summary>
        /// List of agent groups that the user should be assigned to.  Effect: The user will be assigned to each group that already exists. If a particular group is not already in the system it will be created. 
        /// </summary>
        /// <value>List of agent groups that the user should be assigned to.  Effect: The user will be assigned to each group that already exists. If a particular group is not already in the system it will be created. </value>
        [DataMember(Name="agentGroups", EmitDefaultValue=false)]
        public List<string> AgentGroups { get; set; }
        /// <summary>
        /// List of access groups that the user should belong to.  Effect: The user will be assigned to each group that can be located. If a group does not already exist, it will NOT be created. 
        /// </summary>
        /// <value>List of access groups that the user should belong to.  Effect: The user will be assigned to each group that can be located. If a group does not already exist, it will NOT be created. </value>
        [DataMember(Name="accessGroups", EmitDefaultValue=false)]
        public List<string> AccessGroups { get; set; }
        /// <summary>
        /// User&#39;s Voice Mail. Effect: Written to the user&#39;s CfgAgentLogin.userProperties.TServer.gvm_mailbox 
        /// </summary>
        /// <value>User&#39;s Voice Mail. Effect: Written to the user&#39;s CfgAgentLogin.userProperties.TServer.gvm_mailbox </value>
        [DataMember(Name="voiceMail", EmitDefaultValue=false)]
        public decimal? VoiceMail { get; set; }
        /// <summary>
        /// User&#39;s Wrap Up Time.  Effect: Configured for each CfgAgentLogin 
        /// </summary>
        /// <value>User&#39;s Wrap Up Time.  Effect: Configured for each CfgAgentLogin </value>
        [DataMember(Name="wrapUpTime", EmitDefaultValue=false)]
        public string WrapUpTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersPost {\n");
            sb.Append("  ChangePasswordOnNextLogin: ").Append(ChangePasswordOnNextLogin).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LoginCode: ").Append(LoginCode).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  MultimediaPlaceName: ").Append(MultimediaPlaceName).Append("\n");
            sb.Append("  PlaceNames: ").Append(PlaceNames).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  SwitchNames: ").Append(SwitchNames).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  SupportSoftPhone: ").Append(SupportSoftPhone).Append("\n");
            sb.Append("  SipPhoneType: ").Append(SipPhoneType).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  AgentGroups: ").Append(AgentGroups).Append("\n");
            sb.Append("  AccessGroups: ").Append(AccessGroups).Append("\n");
            sb.Append("  VoiceMail: ").Append(VoiceMail).Append("\n");
            sb.Append("  WrapUpTime: ").Append(WrapUpTime).Append("\n");
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
            return this.Equals(obj as UsersPost);
        }

        /// <summary>
        /// Returns true if UsersPost instances are equal
        /// </summary>
        /// <param name="other">Instance of UsersPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersPost other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChangePasswordOnNextLogin == other.ChangePasswordOnNextLogin ||
                    this.ChangePasswordOnNextLogin != null &&
                    this.ChangePasswordOnNextLogin.Equals(other.ChangePasswordOnNextLogin)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.EmployeeID == other.EmployeeID ||
                    this.EmployeeID != null &&
                    this.EmployeeID.Equals(other.EmployeeID)
                ) && 
                (
                    this.ExternalID == other.ExternalID ||
                    this.ExternalID != null &&
                    this.ExternalID.Equals(other.ExternalID)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.LoginCode == other.LoginCode ||
                    this.LoginCode != null &&
                    this.LoginCode.Equals(other.LoginCode)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.MultimediaPlaceName == other.MultimediaPlaceName ||
                    this.MultimediaPlaceName != null &&
                    this.MultimediaPlaceName.Equals(other.MultimediaPlaceName)
                ) && 
                (
                    this.PlaceNames == other.PlaceNames ||
                    this.PlaceNames != null &&
                    this.PlaceNames.SequenceEqual(other.PlaceNames)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    this.SwitchNames == other.SwitchNames ||
                    this.SwitchNames != null &&
                    this.SwitchNames.SequenceEqual(other.SwitchNames)
                ) && 
                (
                    this.Phones == other.Phones ||
                    this.Phones != null &&
                    this.Phones.SequenceEqual(other.Phones)
                ) && 
                (
                    this.SupportSoftPhone == other.SupportSoftPhone ||
                    this.SupportSoftPhone != null &&
                    this.SupportSoftPhone.Equals(other.SupportSoftPhone)
                ) && 
                (
                    this.SipPhoneType == other.SipPhoneType ||
                    this.SipPhoneType != null &&
                    this.SipPhoneType.Equals(other.SipPhoneType)
                ) && 
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) && 
                (
                    this.AgentGroups == other.AgentGroups ||
                    this.AgentGroups != null &&
                    this.AgentGroups.SequenceEqual(other.AgentGroups)
                ) && 
                (
                    this.AccessGroups == other.AccessGroups ||
                    this.AccessGroups != null &&
                    this.AccessGroups.SequenceEqual(other.AccessGroups)
                ) && 
                (
                    this.VoiceMail == other.VoiceMail ||
                    this.VoiceMail != null &&
                    this.VoiceMail.Equals(other.VoiceMail)
                ) && 
                (
                    this.WrapUpTime == other.WrapUpTime ||
                    this.WrapUpTime != null &&
                    this.WrapUpTime.Equals(other.WrapUpTime)
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
                if (this.ChangePasswordOnNextLogin != null)
                    hash = hash * 59 + this.ChangePasswordOnNextLogin.GetHashCode();
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.EmployeeID != null)
                    hash = hash * 59 + this.EmployeeID.GetHashCode();
                if (this.ExternalID != null)
                    hash = hash * 59 + this.ExternalID.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.LoginCode != null)
                    hash = hash * 59 + this.LoginCode.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.MultimediaPlaceName != null)
                    hash = hash * 59 + this.MultimediaPlaceName.GetHashCode();
                if (this.PlaceNames != null)
                    hash = hash * 59 + this.PlaceNames.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.SwitchNames != null)
                    hash = hash * 59 + this.SwitchNames.GetHashCode();
                if (this.Phones != null)
                    hash = hash * 59 + this.Phones.GetHashCode();
                if (this.SupportSoftPhone != null)
                    hash = hash * 59 + this.SupportSoftPhone.GetHashCode();
                if (this.SipPhoneType != null)
                    hash = hash * 59 + this.SipPhoneType.GetHashCode();
                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();
                if (this.AgentGroups != null)
                    hash = hash * 59 + this.AgentGroups.GetHashCode();
                if (this.AccessGroups != null)
                    hash = hash * 59 + this.AccessGroups.GetHashCode();
                if (this.VoiceMail != null)
                    hash = hash * 59 + this.VoiceMail.GetHashCode();
                if (this.WrapUpTime != null)
                    hash = hash * 59 + this.WrapUpTime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
