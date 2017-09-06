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
    /// GetImportStatusResponseData
    /// </summary>
    [DataContract]
    public partial class GetImportStatusResponseData :  IEquatable<GetImportStatusResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImportStatusResponseData" /> class.
        /// </summary>
        /// <param name="ActiveImporters">Active importers IDs..</param>
        /// <param name="AdminName">Admin login..</param>
        /// <param name="Failed">Array of errors during import..</param>
        /// <param name="LastEntity">Last object name processed..</param>
        /// <param name="Operation">Current operation..</param>
        /// <param name="SheetName">Sheet name processed..</param>
        /// <param name="StopRequested">true if user pressed Stop Import.</param>
        /// <param name="Stopped">true if import stopped..</param>
        /// <param name="SucceedCount">Number of records processed succesfully..</param>
        /// <param name="TotalCount">Number of records processed total..</param>
        public GetImportStatusResponseData(List<string> ActiveImporters = default(List<string>), string AdminName = default(string), List<string> Failed = default(List<string>), string LastEntity = default(string), string Operation = default(string), string SheetName = default(string), bool? StopRequested = default(bool?), bool? Stopped = default(bool?), decimal? SucceedCount = default(decimal?), decimal? TotalCount = default(decimal?))
        {
            this.ActiveImporters = ActiveImporters;
            this.AdminName = AdminName;
            this.Failed = Failed;
            this.LastEntity = LastEntity;
            this.Operation = Operation;
            this.SheetName = SheetName;
            this.StopRequested = StopRequested;
            this.Stopped = Stopped;
            this.SucceedCount = SucceedCount;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// Active importers IDs.
        /// </summary>
        /// <value>Active importers IDs.</value>
        [DataMember(Name="activeImporters", EmitDefaultValue=false)]
        public List<string> ActiveImporters { get; set; }

        /// <summary>
        /// Admin login.
        /// </summary>
        /// <value>Admin login.</value>
        [DataMember(Name="adminName", EmitDefaultValue=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// Array of errors during import.
        /// </summary>
        /// <value>Array of errors during import.</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public List<string> Failed { get; set; }

        /// <summary>
        /// Last object name processed.
        /// </summary>
        /// <value>Last object name processed.</value>
        [DataMember(Name="lastEntity", EmitDefaultValue=false)]
        public string LastEntity { get; set; }

        /// <summary>
        /// Current operation.
        /// </summary>
        /// <value>Current operation.</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Sheet name processed.
        /// </summary>
        /// <value>Sheet name processed.</value>
        [DataMember(Name="sheetName", EmitDefaultValue=false)]
        public string SheetName { get; set; }

        /// <summary>
        /// true if user pressed Stop Import
        /// </summary>
        /// <value>true if user pressed Stop Import</value>
        [DataMember(Name="stopRequested", EmitDefaultValue=false)]
        public bool? StopRequested { get; set; }

        /// <summary>
        /// true if import stopped.
        /// </summary>
        /// <value>true if import stopped.</value>
        [DataMember(Name="stopped", EmitDefaultValue=false)]
        public bool? Stopped { get; set; }

        /// <summary>
        /// Number of records processed succesfully.
        /// </summary>
        /// <value>Number of records processed succesfully.</value>
        [DataMember(Name="succeedCount", EmitDefaultValue=false)]
        public decimal? SucceedCount { get; set; }

        /// <summary>
        /// Number of records processed total.
        /// </summary>
        /// <value>Number of records processed total.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public decimal? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetImportStatusResponseData {\n");
            sb.Append("  ActiveImporters: ").Append(ActiveImporters).Append("\n");
            sb.Append("  AdminName: ").Append(AdminName).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  LastEntity: ").Append(LastEntity).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  SheetName: ").Append(SheetName).Append("\n");
            sb.Append("  StopRequested: ").Append(StopRequested).Append("\n");
            sb.Append("  Stopped: ").Append(Stopped).Append("\n");
            sb.Append("  SucceedCount: ").Append(SucceedCount).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GetImportStatusResponseData);
        }

        /// <summary>
        /// Returns true if GetImportStatusResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of GetImportStatusResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetImportStatusResponseData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActiveImporters == other.ActiveImporters ||
                    this.ActiveImporters != null &&
                    this.ActiveImporters.SequenceEqual(other.ActiveImporters)
                ) && 
                (
                    this.AdminName == other.AdminName ||
                    this.AdminName != null &&
                    this.AdminName.Equals(other.AdminName)
                ) && 
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.SequenceEqual(other.Failed)
                ) && 
                (
                    this.LastEntity == other.LastEntity ||
                    this.LastEntity != null &&
                    this.LastEntity.Equals(other.LastEntity)
                ) && 
                (
                    this.Operation == other.Operation ||
                    this.Operation != null &&
                    this.Operation.Equals(other.Operation)
                ) && 
                (
                    this.SheetName == other.SheetName ||
                    this.SheetName != null &&
                    this.SheetName.Equals(other.SheetName)
                ) && 
                (
                    this.StopRequested == other.StopRequested ||
                    this.StopRequested != null &&
                    this.StopRequested.Equals(other.StopRequested)
                ) && 
                (
                    this.Stopped == other.Stopped ||
                    this.Stopped != null &&
                    this.Stopped.Equals(other.Stopped)
                ) && 
                (
                    this.SucceedCount == other.SucceedCount ||
                    this.SucceedCount != null &&
                    this.SucceedCount.Equals(other.SucceedCount)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
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
                if (this.ActiveImporters != null)
                    hash = hash * 59 + this.ActiveImporters.GetHashCode();
                if (this.AdminName != null)
                    hash = hash * 59 + this.AdminName.GetHashCode();
                if (this.Failed != null)
                    hash = hash * 59 + this.Failed.GetHashCode();
                if (this.LastEntity != null)
                    hash = hash * 59 + this.LastEntity.GetHashCode();
                if (this.Operation != null)
                    hash = hash * 59 + this.Operation.GetHashCode();
                if (this.SheetName != null)
                    hash = hash * 59 + this.SheetName.GetHashCode();
                if (this.StopRequested != null)
                    hash = hash * 59 + this.StopRequested.GetHashCode();
                if (this.Stopped != null)
                    hash = hash * 59 + this.Stopped.GetHashCode();
                if (this.SucceedCount != null)
                    hash = hash * 59 + this.SucceedCount.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
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
