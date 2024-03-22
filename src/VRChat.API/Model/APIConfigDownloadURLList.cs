/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.7
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
    /// Download links for various development assets.
    /// </summary>
    [DataContract(Name = "APIConfigDownloadURLList")]
    public partial class APIConfigDownloadURLList : IEquatable<APIConfigDownloadURLList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigDownloadURLList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIConfigDownloadURLList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigDownloadURLList" /> class.
        /// </summary>
        /// <param name="sdk2">Download link for legacy SDK2 (required).</param>
        /// <param name="sdk3Avatars">Download link for SDK3 for Avatars (required).</param>
        /// <param name="sdk3Worlds">Download link for SDK3 for Worlds (required).</param>
        /// <param name="vcc">Download link for the Creator Companion (required).</param>
        /// <param name="bootstrap">Download link for ??? (required).</param>
        public APIConfigDownloadURLList(string sdk2 = default(string), string sdk3Avatars = default(string), string sdk3Worlds = default(string), string vcc = default(string), string bootstrap = default(string))
        {
            // to ensure "sdk2" is required (not null)
            if (sdk2 == null)
            {
                throw new ArgumentNullException("sdk2 is a required property for APIConfigDownloadURLList and cannot be null");
            }
            this.Sdk2 = sdk2;
            // to ensure "sdk3Avatars" is required (not null)
            if (sdk3Avatars == null)
            {
                throw new ArgumentNullException("sdk3Avatars is a required property for APIConfigDownloadURLList and cannot be null");
            }
            this.Sdk3Avatars = sdk3Avatars;
            // to ensure "sdk3Worlds" is required (not null)
            if (sdk3Worlds == null)
            {
                throw new ArgumentNullException("sdk3Worlds is a required property for APIConfigDownloadURLList and cannot be null");
            }
            this.Sdk3Worlds = sdk3Worlds;
            // to ensure "vcc" is required (not null)
            if (vcc == null)
            {
                throw new ArgumentNullException("vcc is a required property for APIConfigDownloadURLList and cannot be null");
            }
            this.Vcc = vcc;
            // to ensure "bootstrap" is required (not null)
            if (bootstrap == null)
            {
                throw new ArgumentNullException("bootstrap is a required property for APIConfigDownloadURLList and cannot be null");
            }
            this.Bootstrap = bootstrap;
        }

        /// <summary>
        /// Download link for legacy SDK2
        /// </summary>
        /// <value>Download link for legacy SDK2</value>
        [DataMember(Name = "sdk2", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string Sdk2 { get; set; }

        /// <summary>
        /// Download link for SDK3 for Avatars
        /// </summary>
        /// <value>Download link for SDK3 for Avatars</value>
        [DataMember(Name = "sdk3-avatars", IsRequired = true, EmitDefaultValue = true)]
        public string Sdk3Avatars { get; set; }

        /// <summary>
        /// Download link for SDK3 for Worlds
        /// </summary>
        /// <value>Download link for SDK3 for Worlds</value>
        [DataMember(Name = "sdk3-worlds", IsRequired = true, EmitDefaultValue = true)]
        public string Sdk3Worlds { get; set; }

        /// <summary>
        /// Download link for the Creator Companion
        /// </summary>
        /// <value>Download link for the Creator Companion</value>
        [DataMember(Name = "vcc", IsRequired = true, EmitDefaultValue = true)]
        public string Vcc { get; set; }

        /// <summary>
        /// Download link for ???
        /// </summary>
        /// <value>Download link for ???</value>
        [DataMember(Name = "bootstrap", IsRequired = true, EmitDefaultValue = true)]
        public string Bootstrap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigDownloadURLList {\n");
            sb.Append("  Sdk2: ").Append(Sdk2).Append("\n");
            sb.Append("  Sdk3Avatars: ").Append(Sdk3Avatars).Append("\n");
            sb.Append("  Sdk3Worlds: ").Append(Sdk3Worlds).Append("\n");
            sb.Append("  Vcc: ").Append(Vcc).Append("\n");
            sb.Append("  Bootstrap: ").Append(Bootstrap).Append("\n");
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
            return this.Equals(input as APIConfigDownloadURLList);
        }

        /// <summary>
        /// Returns true if APIConfigDownloadURLList instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigDownloadURLList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigDownloadURLList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sdk2 == input.Sdk2 ||
                    (this.Sdk2 != null &&
                    this.Sdk2.Equals(input.Sdk2))
                ) && 
                (
                    this.Sdk3Avatars == input.Sdk3Avatars ||
                    (this.Sdk3Avatars != null &&
                    this.Sdk3Avatars.Equals(input.Sdk3Avatars))
                ) && 
                (
                    this.Sdk3Worlds == input.Sdk3Worlds ||
                    (this.Sdk3Worlds != null &&
                    this.Sdk3Worlds.Equals(input.Sdk3Worlds))
                ) && 
                (
                    this.Vcc == input.Vcc ||
                    (this.Vcc != null &&
                    this.Vcc.Equals(input.Vcc))
                ) && 
                (
                    this.Bootstrap == input.Bootstrap ||
                    (this.Bootstrap != null &&
                    this.Bootstrap.Equals(input.Bootstrap))
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
                if (this.Sdk2 != null)
                {
                    hashCode = (hashCode * 59) + this.Sdk2.GetHashCode();
                }
                if (this.Sdk3Avatars != null)
                {
                    hashCode = (hashCode * 59) + this.Sdk3Avatars.GetHashCode();
                }
                if (this.Sdk3Worlds != null)
                {
                    hashCode = (hashCode * 59) + this.Sdk3Worlds.GetHashCode();
                }
                if (this.Vcc != null)
                {
                    hashCode = (hashCode * 59) + this.Vcc.GetHashCode();
                }
                if (this.Bootstrap != null)
                {
                    hashCode = (hashCode * 59) + this.Bootstrap.GetHashCode();
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
            // Sdk2 (string) minLength
            if (this.Sdk2 != null && this.Sdk2.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk2, length must be greater than 1.", new [] { "Sdk2" });
            }

            // Sdk3Avatars (string) minLength
            if (this.Sdk3Avatars != null && this.Sdk3Avatars.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk3Avatars, length must be greater than 1.", new [] { "Sdk3Avatars" });
            }

            // Sdk3Worlds (string) minLength
            if (this.Sdk3Worlds != null && this.Sdk3Worlds.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk3Worlds, length must be greater than 1.", new [] { "Sdk3Worlds" });
            }

            // Vcc (string) minLength
            if (this.Vcc != null && this.Vcc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Vcc, length must be greater than 1.", new [] { "Vcc" });
            }

            // Bootstrap (string) minLength
            if (this.Bootstrap != null && this.Bootstrap.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bootstrap, length must be greater than 1.", new [] { "Bootstrap" });
            }

            yield break;
        }
    }

}
