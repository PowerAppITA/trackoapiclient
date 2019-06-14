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
    /// BackofficeModelAPIWSPolicyGetPolicyResponseData
    /// </summary>
    [DataContract]
    public partial class BackofficeModelAPIWSPolicyGetPolicyResponseData :  IEquatable<BackofficeModelAPIWSPolicyGetPolicyResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackofficeModelAPIWSPolicyGetPolicyResponseData" /> class.
        /// </summary>
        /// <param name="policyHTML">policyHTML.</param>
        /// <param name="lastUpdateDate">lastUpdateDate.</param>
        /// <param name="errorText">errorText.</param>
        /// <param name="status">status.</param>
        /// <param name="title">title.</param>
        /// <param name="text">text.</param>
        /// <param name="url">url.</param>
        /// <param name="id">id.</param>
        public BackofficeModelAPIWSPolicyGetPolicyResponseData(string policyHTML = default(string), DateTime? lastUpdateDate = default(DateTime?), string errorText = default(string), int? status = default(int?), string title = default(string), string text = default(string), string url = default(string), int? id = default(int?))
        {
            this.PolicyHTML = policyHTML;
            this.LastUpdateDate = lastUpdateDate;
            this.ErrorText = errorText;
            this.Status = status;
            this.Title = title;
            this.Text = text;
            this.Url = url;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets PolicyHTML
        /// </summary>
        [DataMember(Name="PolicyHTML", EmitDefaultValue=false)]
        public string PolicyHTML { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdateDate
        /// </summary>
        [DataMember(Name="LastUpdateDate", EmitDefaultValue=false)]
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Gets or Sets ErrorText
        /// </summary>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackofficeModelAPIWSPolicyGetPolicyResponseData {\n");
            sb.Append("  PolicyHTML: ").Append(PolicyHTML).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as BackofficeModelAPIWSPolicyGetPolicyResponseData);
        }

        /// <summary>
        /// Returns true if BackofficeModelAPIWSPolicyGetPolicyResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of BackofficeModelAPIWSPolicyGetPolicyResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackofficeModelAPIWSPolicyGetPolicyResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyHTML == input.PolicyHTML ||
                    (this.PolicyHTML != null &&
                    this.PolicyHTML.Equals(input.PolicyHTML))
                ) && 
                (
                    this.LastUpdateDate == input.LastUpdateDate ||
                    (this.LastUpdateDate != null &&
                    this.LastUpdateDate.Equals(input.LastUpdateDate))
                ) && 
                (
                    this.ErrorText == input.ErrorText ||
                    (this.ErrorText != null &&
                    this.ErrorText.Equals(input.ErrorText))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.PolicyHTML != null)
                    hashCode = hashCode * 59 + this.PolicyHTML.GetHashCode();
                if (this.LastUpdateDate != null)
                    hashCode = hashCode * 59 + this.LastUpdateDate.GetHashCode();
                if (this.ErrorText != null)
                    hashCode = hashCode * 59 + this.ErrorText.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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