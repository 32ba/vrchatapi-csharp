/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.17.0
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
    /// InfoPushData
    /// </summary>
    [DataContract(Name = "InfoPushData")]
    public partial class InfoPushData : IEquatable<InfoPushData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class.
        /// </summary>
        /// <param name="contentList">contentList.</param>
        /// <param name="description">description.</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="name">name.</param>
        /// <param name="onPressed">onPressed.</param>
        /// <param name="template">template.</param>
        /// <param name="version">version.</param>
        /// <param name="article">article.</param>
        public InfoPushData(DynamicContentRow contentList = default(DynamicContentRow), string description = default(string), string imageUrl = default(string), string name = default(string), InfoPushDataClickable onPressed = default(InfoPushDataClickable), string template = default(string), string version = default(string), InfoPushDataArticle article = default(InfoPushDataArticle))
        {
            this.ContentList = contentList;
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.Name = name;
            this.OnPressed = onPressed;
            this.Template = template;
            this._Version = version;
            this.Article = article;
        }

        /// <summary>
        /// Gets or Sets ContentList
        /// </summary>
        [DataMember(Name = "contentList", EmitDefaultValue = false)]
        public DynamicContentRow ContentList { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OnPressed
        /// </summary>
        [DataMember(Name = "onPressed", EmitDefaultValue = false)]
        public InfoPushDataClickable OnPressed { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name = "article", EmitDefaultValue = false)]
        public InfoPushDataArticle Article { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushData {\n");
            sb.Append("  ContentList: ").Append(ContentList).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnPressed: ").Append(OnPressed).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
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
            return this.Equals(input as InfoPushData);
        }

        /// <summary>
        /// Returns true if InfoPushData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentList == input.ContentList ||
                    (this.ContentList != null &&
                    this.ContentList.Equals(input.ContentList))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OnPressed == input.OnPressed ||
                    (this.OnPressed != null &&
                    this.OnPressed.Equals(input.OnPressed))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Article == input.Article ||
                    (this.Article != null &&
                    this.Article.Equals(input.Article))
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
                if (this.ContentList != null)
                {
                    hashCode = (hashCode * 59) + this.ContentList.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OnPressed != null)
                {
                    hashCode = (hashCode * 59) + this.OnPressed.GetHashCode();
                }
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Article != null)
                {
                    hashCode = (hashCode * 59) + this.Article.GetHashCode();
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
            // ImageUrl (string) minLength
            if (this.ImageUrl != null && this.ImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be greater than 1.", new [] { "ImageUrl" });
            }

            // _Version (string) minLength
            if (this._Version != null && this._Version.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Version, length must be greater than 1.", new [] { "_Version" });
            }

            yield break;
        }
    }

}
