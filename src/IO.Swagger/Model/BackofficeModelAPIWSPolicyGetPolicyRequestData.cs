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
    /// BackofficeModelAPIWSPolicyGetPolicyRequestData
    /// </summary>
    [DataContract]
    public partial class BackofficeModelAPIWSPolicyGetPolicyRequestData :  IEquatable<BackofficeModelAPIWSPolicyGetPolicyRequestData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackofficeModelAPIWSPolicyGetPolicyRequestData" /> class.
        /// </summary>
        /// <param name="lang">lang.</param>
        /// <param name="sourceName">sourceName.</param>
        /// <param name="typeId">typeId.</param>
        /// <param name="tokenAPI">tokenAPI.</param>
        public BackofficeModelAPIWSPolicyGetPolicyRequestData(string lang = default(string), string sourceName = default(string), int? typeId = default(int?), string tokenAPI = default(string))
        {
            this.Lang = lang;
            this.SourceName = sourceName;
            this.TypeId = typeId;
            this.TokenAPI = tokenAPI;
        }
        
        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [DataMember(Name="Lang", EmitDefaultValue=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or Sets SourceName
        /// </summary>
        [DataMember(Name="SourceName", EmitDefaultValue=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name="TypeId", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Gets or Sets TokenAPI
        /// </summary>
        [DataMember(Name="TokenAPI", EmitDefaultValue=false)]
        public string TokenAPI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackofficeModelAPIWSPolicyGetPolicyRequestData {\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  TokenAPI: ").Append(TokenAPI).Append("\n");
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
            return this.Equals(input as BackofficeModelAPIWSPolicyGetPolicyRequestData);
        }

        /// <summary>
        /// Returns true if BackofficeModelAPIWSPolicyGetPolicyRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of BackofficeModelAPIWSPolicyGetPolicyRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackofficeModelAPIWSPolicyGetPolicyRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                ) && 
                (
                    this.SourceName == input.SourceName ||
                    (this.SourceName != null &&
                    this.SourceName.Equals(input.SourceName))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.TokenAPI == input.TokenAPI ||
                    (this.TokenAPI != null &&
                    this.TokenAPI.Equals(input.TokenAPI))
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
                if (this.Lang != null)
                    hashCode = hashCode * 59 + this.Lang.GetHashCode();
                if (this.SourceName != null)
                    hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.TokenAPI != null)
                    hashCode = hashCode * 59 + this.TokenAPI.GetHashCode();
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
