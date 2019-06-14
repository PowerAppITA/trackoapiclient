/* 
 * Tracko
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem
    /// </summary>
    [DataContract]
    public partial class BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem :  IEquatable<BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem" /> class.
        /// </summary>
        /// <param name="systemName">systemName.</param>
        /// <param name="value">value.</param>
        public BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem(string systemName = default(string), bool? value = default(bool?))
        {
            this.SystemName = systemName;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets SystemName
        /// </summary>
        [DataMember(Name="SystemName", EmitDefaultValue=false)]
        public string SystemName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public bool? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem {\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem);
        }

        /// <summary>
        /// Returns true if BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackofficeModelAPIWSContactUpdateMultipleRequestStatusRequestDataItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
