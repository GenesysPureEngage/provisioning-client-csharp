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
    /// ExportFileData
    /// </summary>
    [DataContract]
    public partial class ExportFileData :  IEquatable<ExportFileData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportFileData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportFileData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportFileData" /> class.
        /// </summary>
        /// <param name="Fields">Array of user property names to include  Effect: Only these names will be included in exported user structure  (required).</param>
        /// <param name="FileName">File Name to save exported users.  Effect: Controls the file name to save.  (required) (default to &quot;users.csv&quot;).</param>
        /// <param name="PersonDBIDs">List of User IDs to export  Effect: Controls which users will be exported.  (required).</param>
        /// <param name="FilterParameters">FilterParameters.</param>
        public ExportFileData(List<string> Fields = default(List<string>), string FileName = "users.csv", List<string> PersonDBIDs = default(List<string>), ExportFileDataFilterParameters FilterParameters = default(ExportFileDataFilterParameters))
        {
            // to ensure "Fields" is required (not null)
            if (Fields == null)
            {
                throw new InvalidDataException("Fields is a required property for ExportFileData and cannot be null");
            }
            else
            {
                this.Fields = Fields;
            }
            // to ensure "FileName" is required (not null)
            if (FileName == null)
            {
                throw new InvalidDataException("FileName is a required property for ExportFileData and cannot be null");
            }
            else
            {
                this.FileName = FileName;
            }
            // to ensure "PersonDBIDs" is required (not null)
            if (PersonDBIDs == null)
            {
                throw new InvalidDataException("PersonDBIDs is a required property for ExportFileData and cannot be null");
            }
            else
            {
                this.PersonDBIDs = PersonDBIDs;
            }
            this.FilterParameters = FilterParameters;
        }
        
        /// <summary>
        /// Array of user property names to include  Effect: Only these names will be included in exported user structure 
        /// </summary>
        /// <value>Array of user property names to include  Effect: Only these names will be included in exported user structure </value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// File Name to save exported users.  Effect: Controls the file name to save. 
        /// </summary>
        /// <value>File Name to save exported users.  Effect: Controls the file name to save. </value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// List of User IDs to export  Effect: Controls which users will be exported. 
        /// </summary>
        /// <value>List of User IDs to export  Effect: Controls which users will be exported. </value>
        [DataMember(Name="personDBIDs", EmitDefaultValue=false)]
        public List<string> PersonDBIDs { get; set; }

        /// <summary>
        /// Gets or Sets FilterParameters
        /// </summary>
        [DataMember(Name="filterParameters", EmitDefaultValue=false)]
        public ExportFileDataFilterParameters FilterParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportFileData {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  PersonDBIDs: ").Append(PersonDBIDs).Append("\n");
            sb.Append("  FilterParameters: ").Append(FilterParameters).Append("\n");
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
            return this.Equals(obj as ExportFileData);
        }

        /// <summary>
        /// Returns true if ExportFileData instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportFileData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportFileData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.PersonDBIDs == other.PersonDBIDs ||
                    this.PersonDBIDs != null &&
                    this.PersonDBIDs.SequenceEqual(other.PersonDBIDs)
                ) && 
                (
                    this.FilterParameters == other.FilterParameters ||
                    this.FilterParameters != null &&
                    this.FilterParameters.Equals(other.FilterParameters)
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
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                if (this.PersonDBIDs != null)
                    hash = hash * 59 + this.PersonDBIDs.GetHashCode();
                if (this.FilterParameters != null)
                    hash = hash * 59 + this.FilterParameters.GetHashCode();
                return hash;
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
