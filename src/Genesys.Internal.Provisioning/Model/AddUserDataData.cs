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
    /// AddUserDataData
    /// </summary>
    [DataContract]
    public partial class AddUserDataData :  IEquatable<AddUserDataData>, IValidatableObject
    {
        /// <summary>
        /// Specifies the SIP phone type if you set the **supportSoftPhone** parameter to &#x60;true&#x60;. This specifies the SIP phone type and corresponding annex to be written to the DN&#39;s \&quot;TServer\&quot; section. 
        /// </summary>
        /// <value>Specifies the SIP phone type if you set the **supportSoftPhone** parameter to &#x60;true&#x60;. This specifies the SIP phone type and corresponding annex to be written to the DN&#39;s \&quot;TServer\&quot; section. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SipPhoneTypeEnum
        {
            
            /// <summary>
            /// Enum DISABLECTI for value: DISABLE_CTI
            /// </summary>
            [EnumMember(Value = "DISABLE_CTI")]
            DISABLECTI = 1,
            
            /// <summary>
            /// Enum GENESYSSOFTPHONE for value: GENESYS_SOFTPHONE
            /// </summary>
            [EnumMember(Value = "GENESYS_SOFTPHONE")]
            GENESYSSOFTPHONE = 2,
            
            /// <summary>
            /// Enum GENESYS420HTAUDIOCODES4xxHD for value: GENESYS_420HT_AUDIOCODES_4xxHD
            /// </summary>
            [EnumMember(Value = "GENESYS_420HT_AUDIOCODES_4xxHD")]
            GENESYS420HTAUDIOCODES4xxHD = 3,
            
            /// <summary>
            /// Enum GENERICPHONE for value: GENERIC_PHONE
            /// </summary>
            [EnumMember(Value = "GENERIC_PHONE")]
            GENERICPHONE = 4
        }

        /// <summary>
        /// Specifies the SIP phone type if you set the **supportSoftPhone** parameter to &#x60;true&#x60;. This specifies the SIP phone type and corresponding annex to be written to the DN&#39;s \&quot;TServer\&quot; section. 
        /// </summary>
        /// <value>Specifies the SIP phone type if you set the **supportSoftPhone** parameter to &#x60;true&#x60;. This specifies the SIP phone type and corresponding annex to be written to the DN&#39;s \&quot;TServer\&quot; section. </value>
        [DataMember(Name="sipPhoneType", EmitDefaultValue=false)]
        public SipPhoneTypeEnum? SipPhoneType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserDataData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddUserDataData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserDataData" /> class.
        /// </summary>
        /// <param name="ChangePasswordOnNextLogin">Specifies whether to ask the user to change their password the first time they login. The default is &#x60;false&#x60;. .</param>
        /// <param name="EmailAddress">The user&#39;s email address. .</param>
        /// <param name="EmployeeID">The user&#39;s employee ID. .</param>
        /// <param name="ExternalID">The user&#39;s external ID. .</param>
        /// <param name="Enabled">Specifies whether the user is enabled. .</param>
        /// <param name="Folder">The location where the Provisioning API should create the user. This is where the API creates the user, DNs, places, agent logins and so on. If not specified, the API creates the user in a root folder. .</param>
        /// <param name="UserName">The user&#39;s unique login.  (required).</param>
        /// <param name="FirstName">The user&#39;s first name.  (required).</param>
        /// <param name="LastName">The user&#39;s last name.  (required).</param>
        /// <param name="LoginCode">The user&#39;s login code. This creates a corresponding [CfgAgentLogin](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgAgentLogin) on all switches in the **switchNames** collection. It&#39;s then assigned to the CfgPerson being created. .</param>
        /// <param name="Password">The user&#39;s password as plain text.  (required).</param>
        /// <param name="PlaceNames">A list of places (phones) available to the user (for multimedia only users). The list is written to the current ([CfgPerson&#39;s](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgPerson)) \&quot;htcc\&quot; annex. For example, CfgPerson/userProperties/htcc/place &#x3D; p1, p2, p3. .</param>
        /// <param name="IsAgent">Specifies if the user is an agent (default &#39;true&#39;). .</param>
        /// <param name="Wwe">Wwe.</param>
        /// <param name="SwitchNames">The switch names the user will work on (where their DNs, agent logins and so on are created). .</param>
        /// <param name="Phones">A list of phone number descriptors used to create the user&#39;s DNs. For each phone number, a corresponding DN is created on all switches specified by **switchNames** and assigned to the specified place. .</param>
        /// <param name="SupportSoftPhone">Specifies whether to enable a SIP phone. This writes the corresponding information to the T-Server annex of the created DNs (see **sipPhoneType** below). .</param>
        /// <param name="SipPhoneType">Specifies the SIP phone type if you set the **supportSoftPhone** parameter to &#x60;true&#x60;. This specifies the SIP phone type and corresponding annex to be written to the DN&#39;s \&quot;TServer\&quot; section. .</param>
        /// <param name="Skills">A list of skills to assign to the user. If the Provisioning API finds the corresponding skill, it assigns it to the user with the specified level. If not found, the API creates the skill and assigns it to the user. .</param>
        /// <param name="AgentGroups">A list of agent groups that the user should be assigned to. If a group doesn&#39;t exist, it&#39;s created by the Provisioning API. .</param>
        /// <param name="AccessGroups">A list of access groups that the user should belong to. If a group doesn&#39;t exist, it is **NOT** created by the Provisioning API. .</param>
        /// <param name="VoiceMail">The user&#39;s voice mail. This is written to the user&#39;s CfgAgentLogin.userProperties.TServer.gvm_mailbox. .</param>
        /// <param name="WrapUpTime">The user&#39;s Wrap Up Time. This is configured for each [CfgAgentLogin](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgAgentLogin). .</param>
        public AddUserDataData(bool? ChangePasswordOnNextLogin = default(bool?), string EmailAddress = default(string), string EmployeeID = default(string), string ExternalID = default(string), bool? Enabled = default(bool?), string Folder = default(string), string UserName = default(string), string FirstName = default(string), string LastName = default(string), string LoginCode = default(string), string Password = default(string), List<string> PlaceNames = default(List<string>), bool? IsAgent = default(bool?), AddUserDataDataWwe Wwe = default(AddUserDataDataWwe), List<string> SwitchNames = default(List<string>), List<Extension> Phones = default(List<Extension>), bool? SupportSoftPhone = default(bool?), SipPhoneTypeEnum? SipPhoneType = default(SipPhoneTypeEnum?), List<Skill> Skills = default(List<Skill>), List<string> AgentGroups = default(List<string>), List<string> AccessGroups = default(List<string>), int? VoiceMail = default(int?), string WrapUpTime = default(string))
        {
            // to ensure "UserName" is required (not null)
            if (UserName == null)
            {
                throw new InvalidDataException("UserName is a required property for AddUserDataData and cannot be null");
            }
            else
            {
                this.UserName = UserName;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for AddUserDataData and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for AddUserDataData and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for AddUserDataData and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            this.ChangePasswordOnNextLogin = ChangePasswordOnNextLogin;
            this.EmailAddress = EmailAddress;
            this.EmployeeID = EmployeeID;
            this.ExternalID = ExternalID;
            this.Enabled = Enabled;
            this.Folder = Folder;
            this.LoginCode = LoginCode;
            this.PlaceNames = PlaceNames;
            this.IsAgent = IsAgent;
            this.Wwe = Wwe;
            this.SwitchNames = SwitchNames;
            this.Phones = Phones;
            this.SupportSoftPhone = SupportSoftPhone;
            this.SipPhoneType = SipPhoneType;
            this.Skills = Skills;
            this.AgentGroups = AgentGroups;
            this.AccessGroups = AccessGroups;
            this.VoiceMail = VoiceMail;
            this.WrapUpTime = WrapUpTime;
        }
        
        /// <summary>
        /// Specifies whether to ask the user to change their password the first time they login. The default is &#x60;false&#x60;. 
        /// </summary>
        /// <value>Specifies whether to ask the user to change their password the first time they login. The default is &#x60;false&#x60;. </value>
        [DataMember(Name="changePasswordOnNextLogin", EmitDefaultValue=false)]
        public bool? ChangePasswordOnNextLogin { get; set; }

        /// <summary>
        /// The user&#39;s email address. 
        /// </summary>
        /// <value>The user&#39;s email address. </value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s employee ID. 
        /// </summary>
        /// <value>The user&#39;s employee ID. </value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public string EmployeeID { get; set; }

        /// <summary>
        /// The user&#39;s external ID. 
        /// </summary>
        /// <value>The user&#39;s external ID. </value>
        [DataMember(Name="externalID", EmitDefaultValue=false)]
        public string ExternalID { get; set; }

        /// <summary>
        /// Specifies whether the user is enabled. 
        /// </summary>
        /// <value>Specifies whether the user is enabled. </value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The location where the Provisioning API should create the user. This is where the API creates the user, DNs, places, agent logins and so on. If not specified, the API creates the user in a root folder. 
        /// </summary>
        /// <value>The location where the Provisioning API should create the user. This is where the API creates the user, DNs, places, agent logins and so on. If not specified, the API creates the user in a root folder. </value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public string Folder { get; set; }

        /// <summary>
        /// The user&#39;s unique login. 
        /// </summary>
        /// <value>The user&#39;s unique login. </value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The user&#39;s first name. 
        /// </summary>
        /// <value>The user&#39;s first name. </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user&#39;s last name. 
        /// </summary>
        /// <value>The user&#39;s last name. </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The user&#39;s login code. This creates a corresponding [CfgAgentLogin](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgAgentLogin) on all switches in the **switchNames** collection. It&#39;s then assigned to the CfgPerson being created. 
        /// </summary>
        /// <value>The user&#39;s login code. This creates a corresponding [CfgAgentLogin](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgAgentLogin) on all switches in the **switchNames** collection. It&#39;s then assigned to the CfgPerson being created. </value>
        [DataMember(Name="loginCode", EmitDefaultValue=false)]
        public string LoginCode { get; set; }

        /// <summary>
        /// The user&#39;s password as plain text. 
        /// </summary>
        /// <value>The user&#39;s password as plain text. </value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// A list of places (phones) available to the user (for multimedia only users). The list is written to the current ([CfgPerson&#39;s](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgPerson)) \&quot;htcc\&quot; annex. For example, CfgPerson/userProperties/htcc/place &#x3D; p1, p2, p3. 
        /// </summary>
        /// <value>A list of places (phones) available to the user (for multimedia only users). The list is written to the current ([CfgPerson&#39;s](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgPerson)) \&quot;htcc\&quot; annex. For example, CfgPerson/userProperties/htcc/place &#x3D; p1, p2, p3. </value>
        [DataMember(Name="placeNames", EmitDefaultValue=false)]
        public List<string> PlaceNames { get; set; }

        /// <summary>
        /// Specifies if the user is an agent (default &#39;true&#39;). 
        /// </summary>
        /// <value>Specifies if the user is an agent (default &#39;true&#39;). </value>
        [DataMember(Name="isAgent", EmitDefaultValue=false)]
        public bool? IsAgent { get; set; }

        /// <summary>
        /// Gets or Sets Wwe
        /// </summary>
        [DataMember(Name="wwe", EmitDefaultValue=false)]
        public AddUserDataDataWwe Wwe { get; set; }

        /// <summary>
        /// The switch names the user will work on (where their DNs, agent logins and so on are created). 
        /// </summary>
        /// <value>The switch names the user will work on (where their DNs, agent logins and so on are created). </value>
        [DataMember(Name="switchNames", EmitDefaultValue=false)]
        public List<string> SwitchNames { get; set; }

        /// <summary>
        /// A list of phone number descriptors used to create the user&#39;s DNs. For each phone number, a corresponding DN is created on all switches specified by **switchNames** and assigned to the specified place. 
        /// </summary>
        /// <value>A list of phone number descriptors used to create the user&#39;s DNs. For each phone number, a corresponding DN is created on all switches specified by **switchNames** and assigned to the specified place. </value>
        [DataMember(Name="phones", EmitDefaultValue=false)]
        public List<Extension> Phones { get; set; }

        /// <summary>
        /// Specifies whether to enable a SIP phone. This writes the corresponding information to the T-Server annex of the created DNs (see **sipPhoneType** below). 
        /// </summary>
        /// <value>Specifies whether to enable a SIP phone. This writes the corresponding information to the T-Server annex of the created DNs (see **sipPhoneType** below). </value>
        [DataMember(Name="supportSoftPhone", EmitDefaultValue=false)]
        public bool? SupportSoftPhone { get; set; }


        /// <summary>
        /// A list of skills to assign to the user. If the Provisioning API finds the corresponding skill, it assigns it to the user with the specified level. If not found, the API creates the skill and assigns it to the user. 
        /// </summary>
        /// <value>A list of skills to assign to the user. If the Provisioning API finds the corresponding skill, it assigns it to the user with the specified level. If not found, the API creates the skill and assigns it to the user. </value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<Skill> Skills { get; set; }

        /// <summary>
        /// A list of agent groups that the user should be assigned to. If a group doesn&#39;t exist, it&#39;s created by the Provisioning API. 
        /// </summary>
        /// <value>A list of agent groups that the user should be assigned to. If a group doesn&#39;t exist, it&#39;s created by the Provisioning API. </value>
        [DataMember(Name="agentGroups", EmitDefaultValue=false)]
        public List<string> AgentGroups { get; set; }

        /// <summary>
        /// A list of access groups that the user should belong to. If a group doesn&#39;t exist, it is **NOT** created by the Provisioning API. 
        /// </summary>
        /// <value>A list of access groups that the user should belong to. If a group doesn&#39;t exist, it is **NOT** created by the Provisioning API. </value>
        [DataMember(Name="accessGroups", EmitDefaultValue=false)]
        public List<string> AccessGroups { get; set; }

        /// <summary>
        /// The user&#39;s voice mail. This is written to the user&#39;s CfgAgentLogin.userProperties.TServer.gvm_mailbox. 
        /// </summary>
        /// <value>The user&#39;s voice mail. This is written to the user&#39;s CfgAgentLogin.userProperties.TServer.gvm_mailbox. </value>
        [DataMember(Name="voiceMail", EmitDefaultValue=false)]
        public int? VoiceMail { get; set; }

        /// <summary>
        /// The user&#39;s Wrap Up Time. This is configured for each [CfgAgentLogin](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgAgentLogin). 
        /// </summary>
        /// <value>The user&#39;s Wrap Up Time. This is configured for each [CfgAgentLogin](https://docs.genesys.com/Documentation/PSDK/latest/ConfigLayerRef/CfgAgentLogin). </value>
        [DataMember(Name="wrapUpTime", EmitDefaultValue=false)]
        public string WrapUpTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddUserDataData {\n");
            sb.Append("  ChangePasswordOnNextLogin: ").Append(ChangePasswordOnNextLogin).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LoginCode: ").Append(LoginCode).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PlaceNames: ").Append(PlaceNames).Append("\n");
            sb.Append("  IsAgent: ").Append(IsAgent).Append("\n");
            sb.Append("  Wwe: ").Append(Wwe).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddUserDataData);
        }

        /// <summary>
        /// Returns true if AddUserDataData instances are equal
        /// </summary>
        /// <param name="input">Instance of AddUserDataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddUserDataData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChangePasswordOnNextLogin == input.ChangePasswordOnNextLogin ||
                    (this.ChangePasswordOnNextLogin != null &&
                    this.ChangePasswordOnNextLogin.Equals(input.ChangePasswordOnNextLogin))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.ExternalID == input.ExternalID ||
                    (this.ExternalID != null &&
                    this.ExternalID.Equals(input.ExternalID))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Folder == input.Folder ||
                    (this.Folder != null &&
                    this.Folder.Equals(input.Folder))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                    this.LoginCode == input.LoginCode ||
                    (this.LoginCode != null &&
                    this.LoginCode.Equals(input.LoginCode))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PlaceNames == input.PlaceNames ||
                    this.PlaceNames != null &&
                    this.PlaceNames.SequenceEqual(input.PlaceNames)
                ) && 
                (
                    this.IsAgent == input.IsAgent ||
                    (this.IsAgent != null &&
                    this.IsAgent.Equals(input.IsAgent))
                ) && 
                (
                    this.Wwe == input.Wwe ||
                    (this.Wwe != null &&
                    this.Wwe.Equals(input.Wwe))
                ) && 
                (
                    this.SwitchNames == input.SwitchNames ||
                    this.SwitchNames != null &&
                    this.SwitchNames.SequenceEqual(input.SwitchNames)
                ) && 
                (
                    this.Phones == input.Phones ||
                    this.Phones != null &&
                    this.Phones.SequenceEqual(input.Phones)
                ) && 
                (
                    this.SupportSoftPhone == input.SupportSoftPhone ||
                    (this.SupportSoftPhone != null &&
                    this.SupportSoftPhone.Equals(input.SupportSoftPhone))
                ) && 
                (
                    this.SipPhoneType == input.SipPhoneType ||
                    (this.SipPhoneType != null &&
                    this.SipPhoneType.Equals(input.SipPhoneType))
                ) && 
                (
                    this.Skills == input.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(input.Skills)
                ) && 
                (
                    this.AgentGroups == input.AgentGroups ||
                    this.AgentGroups != null &&
                    this.AgentGroups.SequenceEqual(input.AgentGroups)
                ) && 
                (
                    this.AccessGroups == input.AccessGroups ||
                    this.AccessGroups != null &&
                    this.AccessGroups.SequenceEqual(input.AccessGroups)
                ) && 
                (
                    this.VoiceMail == input.VoiceMail ||
                    (this.VoiceMail != null &&
                    this.VoiceMail.Equals(input.VoiceMail))
                ) && 
                (
                    this.WrapUpTime == input.WrapUpTime ||
                    (this.WrapUpTime != null &&
                    this.WrapUpTime.Equals(input.WrapUpTime))
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
                if (this.ChangePasswordOnNextLogin != null)
                    hashCode = hashCode * 59 + this.ChangePasswordOnNextLogin.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.ExternalID != null)
                    hashCode = hashCode * 59 + this.ExternalID.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Folder != null)
                    hashCode = hashCode * 59 + this.Folder.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.LoginCode != null)
                    hashCode = hashCode * 59 + this.LoginCode.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PlaceNames != null)
                    hashCode = hashCode * 59 + this.PlaceNames.GetHashCode();
                if (this.IsAgent != null)
                    hashCode = hashCode * 59 + this.IsAgent.GetHashCode();
                if (this.Wwe != null)
                    hashCode = hashCode * 59 + this.Wwe.GetHashCode();
                if (this.SwitchNames != null)
                    hashCode = hashCode * 59 + this.SwitchNames.GetHashCode();
                if (this.Phones != null)
                    hashCode = hashCode * 59 + this.Phones.GetHashCode();
                if (this.SupportSoftPhone != null)
                    hashCode = hashCode * 59 + this.SupportSoftPhone.GetHashCode();
                if (this.SipPhoneType != null)
                    hashCode = hashCode * 59 + this.SipPhoneType.GetHashCode();
                if (this.Skills != null)
                    hashCode = hashCode * 59 + this.Skills.GetHashCode();
                if (this.AgentGroups != null)
                    hashCode = hashCode * 59 + this.AgentGroups.GetHashCode();
                if (this.AccessGroups != null)
                    hashCode = hashCode * 59 + this.AccessGroups.GetHashCode();
                if (this.VoiceMail != null)
                    hashCode = hashCode * 59 + this.VoiceMail.GetHashCode();
                if (this.WrapUpTime != null)
                    hashCode = hashCode * 59 + this.WrapUpTime.GetHashCode();
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
