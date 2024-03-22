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
    /// UpdateFavoriteGroupRequest
    /// </summary>
    [DataContract(Name = "UpdateFavoriteGroupRequest")]
    public partial class UpdateFavoriteGroupRequest : IEquatable<UpdateFavoriteGroupRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public FavoriteGroupVisibility? Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFavoriteGroupRequest" /> class.
        /// </summary>
        /// <param name="displayName">displayName.</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="tags">Tags on FavoriteGroups are believed to do nothing..</param>
        public UpdateFavoriteGroupRequest(string displayName = default(string), FavoriteGroupVisibility? visibility = default(FavoriteGroupVisibility?), List<string> tags = default(List<string>))
        {
            this.DisplayName = displayName;
            this.Visibility = visibility;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Tags on FavoriteGroups are believed to do nothing.
        /// </summary>
        /// <value>Tags on FavoriteGroups are believed to do nothing.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateFavoriteGroupRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as UpdateFavoriteGroupRequest);
        }

        /// <summary>
        /// Returns true if UpdateFavoriteGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFavoriteGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFavoriteGroupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.Equals(input.Visibility)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
            yield break;
        }
    }

}
