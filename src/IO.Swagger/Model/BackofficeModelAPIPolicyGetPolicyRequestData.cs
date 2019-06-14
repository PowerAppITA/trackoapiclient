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
    /// BackofficeModelAPIPolicyGetPolicyRequestData
    /// </summary>
    [DataContract]
    public partial class BackofficeModelAPIPolicyGetPolicyRequestData :  IEquatable<BackofficeModelAPIPolicyGetPolicyRequestData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackofficeModelAPIPolicyGetPolicyRequestData" /> class.
        /// </summary>
        /// <param name="typeId">typeId.</param>
        /// <param name="linguaId">linguaId.</param>
        /// <param name="sorgenteId">sorgenteId.</param>
        /// <param name="clienteId">clienteId.</param>
        public BackofficeModelAPIPolicyGetPolicyRequestData(int? typeId = default(int?), int? linguaId = default(int?), int? sorgenteId = default(int?), string clienteId = default(string))
        {
            this.TypeId = typeId;
            this.LinguaId = linguaId;
            this.SorgenteId = sorgenteId;
            this.ClienteId = clienteId;
        }
        
        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name="typeId", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Gets or Sets LinguaId
        /// </summary>
        [DataMember(Name="linguaId", EmitDefaultValue=false)]
        public int? LinguaId { get; set; }

        /// <summary>
        /// Gets or Sets SorgenteId
        /// </summary>
        [DataMember(Name="sorgenteId", EmitDefaultValue=false)]
        public int? SorgenteId { get; set; }

        /// <summary>
        /// Gets or Sets ClienteId
        /// </summary>
        [DataMember(Name="clienteId", EmitDefaultValue=false)]
        public string ClienteId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackofficeModelAPIPolicyGetPolicyRequestData {\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  LinguaId: ").Append(LinguaId).Append("\n");
            sb.Append("  SorgenteId: ").Append(SorgenteId).Append("\n");
            sb.Append("  ClienteId: ").Append(ClienteId).Append("\n");
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
            return this.Equals(input as BackofficeModelAPIPolicyGetPolicyRequestData);
        }

        /// <summary>
        /// Returns true if BackofficeModelAPIPolicyGetPolicyRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of BackofficeModelAPIPolicyGetPolicyRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackofficeModelAPIPolicyGetPolicyRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.LinguaId == input.LinguaId ||
                    (this.LinguaId != null &&
                    this.LinguaId.Equals(input.LinguaId))
                ) && 
                (
                    this.SorgenteId == input.SorgenteId ||
                    (this.SorgenteId != null &&
                    this.SorgenteId.Equals(input.SorgenteId))
                ) && 
                (
                    this.ClienteId == input.ClienteId ||
                    (this.ClienteId != null &&
                    this.ClienteId.Equals(input.ClienteId))
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
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.LinguaId != null)
                    hashCode = hashCode * 59 + this.LinguaId.GetHashCode();
                if (this.SorgenteId != null)
                    hashCode = hashCode * 59 + this.SorgenteId.GetHashCode();
                if (this.ClienteId != null)
                    hashCode = hashCode * 59 + this.ClienteId.GetHashCode();
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
