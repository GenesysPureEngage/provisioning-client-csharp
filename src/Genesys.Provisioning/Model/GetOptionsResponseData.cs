/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.00.813
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

namespace Genesys.Provisioning.Model
{
    /// <summary>
    /// GetOptionsResponseData
    /// </summary>
    [DataContract]
    public partial class GetOptionsResponseData :  IEquatable<GetOptionsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOptionsResponseData" /> class.
        /// </summary>
        /// <param name="CmeAppDBID">DBID of the CME App..</param>
        /// <param name="Options">Sections, keys and values of CloudCluster/Options..</param>
        /// <param name="CmeAppName">Name of the CME App (CloudCluster by default)..</param>
        public GetOptionsResponseData(string CmeAppDBID = default(string), Object Options = default(Object), string CmeAppName = default(string))
        {
            this.CmeAppDBID = CmeAppDBID;
            this.Options = Options;
            this.CmeAppName = CmeAppName;
        }
        
        /// <summary>
        /// DBID of the CME App.
        /// </summary>
        /// <value>DBID of the CME App.</value>
        [DataMember(Name="cmeAppDBID", EmitDefaultValue=false)]
        public string CmeAppDBID { get; set; }
        /// <summary>
        /// Sections, keys and values of CloudCluster/Options.
        /// </summary>
        /// <value>Sections, keys and values of CloudCluster/Options.</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Object Options { get; set; }
        /// <summary>
        /// Name of the CME App (CloudCluster by default).
        /// </summary>
        /// <value>Name of the CME App (CloudCluster by default).</value>
        [DataMember(Name="cmeAppName", EmitDefaultValue=false)]
        public string CmeAppName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOptionsResponseData {\n");
            sb.Append("  CmeAppDBID: ").Append(CmeAppDBID).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  CmeAppName: ").Append(CmeAppName).Append("\n");
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
            return this.Equals(obj as GetOptionsResponseData);
        }

        /// <summary>
        /// Returns true if GetOptionsResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of GetOptionsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOptionsResponseData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CmeAppDBID == other.CmeAppDBID ||
                    this.CmeAppDBID != null &&
                    this.CmeAppDBID.Equals(other.CmeAppDBID)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.CmeAppName == other.CmeAppName ||
                    this.CmeAppName != null &&
                    this.CmeAppName.Equals(other.CmeAppName)
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
                if (this.CmeAppDBID != null)
                    hash = hash * 59 + this.CmeAppDBID.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.CmeAppName != null)
                    hash = hash * 59 + this.CmeAppName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
