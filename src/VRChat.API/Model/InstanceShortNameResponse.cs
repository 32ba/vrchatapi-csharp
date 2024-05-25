/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.17.5
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// InstanceShortNameResponse
    /// </summary>
    [DataContract(Name = "InstanceShortNameResponse")]
    public partial class InstanceShortNameResponse : IEquatable<InstanceShortNameResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceShortNameResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstanceShortNameResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceShortNameResponse" /> class.
        /// </summary>
        /// <param name="secureName">secureName (required).</param>
        /// <param name="shortName">shortName.</param>
        public InstanceShortNameResponse(string secureName = default(string), string shortName = default(string))
        {
            // to ensure "secureName" is required (not null)
            if (secureName == null)
            {
                throw new ArgumentNullException("secureName is a required property for InstanceShortNameResponse and cannot be null");
            }
            this.SecureName = secureName;
            this.ShortName = shortName;
        }

        /// <summary>
        /// Gets or Sets SecureName
        /// </summary>
        [DataMember(Name = "secureName", IsRequired = true, EmitDefaultValue = true)]
        public string SecureName { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstanceShortNameResponse {\n");
            sb.Append("  SecureName: ").Append(SecureName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceShortNameResponse);
        }

        /// <summary>
        /// Returns true if InstanceShortNameResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InstanceShortNameResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceShortNameResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SecureName == input.SecureName ||
                    (this.SecureName != null &&
                    this.SecureName.Equals(input.SecureName))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
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
                if (this.SecureName != null)
                {
                    hashCode = (hashCode * 59) + this.SecureName.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // SecureName (string) minLength
            if (this.SecureName != null && this.SecureName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecureName, length must be greater than 1.", new [] { "SecureName" });
            }

            // ShortName (string) minLength
            if (this.ShortName != null && this.ShortName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortName, length must be greater than 1.", new [] { "ShortName" });
            }

            yield break;
        }
    }

}
