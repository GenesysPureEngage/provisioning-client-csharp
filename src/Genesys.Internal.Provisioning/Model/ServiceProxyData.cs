/* 
 * Provisioning API
 *
 * The provisioning service will be used to create objects in configuration server in a way that is consistent with the BEC model. The \"users\" resource will be used to perform CRUD operations on config server person objects. Note that this API will extend the low level configuration server API to add additional functionality that will allow persons to be created in a way that makes them immediately useable in BEC. Operations on this resource may result in other configuration objects being modified as well. 
 *
 * OpenAPI spec version: 9.0.000.25.2540
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
    /// ServiceProxyData
    /// </summary>
    [DataContract]
    public partial class ServiceProxyData :  IEquatable<ServiceProxyData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProxyData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceProxyData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProxyData" /> class.
        /// </summary>
        /// <param name="Service">Service name (required).</param>
        /// <param name="Method">Method name (required).</param>
        /// <param name="Args">Optional method arguments array.</param>
        public ServiceProxyData(string Service = default(string), string Method = default(string), Object Args = default(Object))
        {
            // to ensure "Service" is required (not null)
            if (Service == null)
            {
                throw new InvalidDataException("Service is a required property for ServiceProxyData and cannot be null");
            }
            else
            {
                this.Service = Service;
            }
            // to ensure "Method" is required (not null)
            if (Method == null)
            {
                throw new InvalidDataException("Method is a required property for ServiceProxyData and cannot be null");
            }
            else
            {
                this.Method = Method;
            }
            this.Args = Args;
        }
        
        /// <summary>
        /// Service name
        /// </summary>
        /// <value>Service name</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Method name
        /// </summary>
        /// <value>Method name</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Optional method arguments array
        /// </summary>
        /// <value>Optional method arguments array</value>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public Object Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceProxyData {\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
            return this.Equals(input as ServiceProxyData);
        }

        /// <summary>
        /// Returns true if ServiceProxyData instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceProxyData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceProxyData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Args == input.Args ||
                    (this.Args != null &&
                    this.Args.Equals(input.Args))
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
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
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
