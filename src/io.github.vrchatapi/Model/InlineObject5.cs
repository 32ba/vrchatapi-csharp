/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # VRChat API Documentation This project is an [OPEN Open Source Project](https://openopensource.org)  Individuals making significant and valuable contributions are given commit-access to the project to contribute as they see fit. This project is more like an open wiki than a standard guarded open source project.  ## Disclaimer  This is the official response of the VRChat Team (from Tupper more specifically) on the usage of the VRChat API.  > **Use of the API using applications other than the approved methods (website, VRChat application) are not officially supported. You may use the API for your own application, but keep these guidelines in mind:** > * We do not provide documentation or support for the API. > * Do not make queries to the API more than once per 60 seconds. > * Abuse of the API may result in account termination. > * Access to API endpoints may break at any given time, with no warning.  As stated, this documentation was not created with the help of the official VRChat team. Therefore this documentation is not an official documentation of the VRChat API and may not be always up to date with the latest versions. If you find that a page or endpoint is not longer valid please create an issue and tell us so we can fix it.  ## Get in touch with us!  [https://discord.gg/qjZE9C9fkB#vrchat-api](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// InlineObject5
    /// </summary>
    [DataContract]
    public partial class InlineObject5 :  IEquatable<InlineObject5>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public Platform? Platform { get; set; }
        /// <summary>
        /// Gets or Sets ReleaseStatus
        /// </summary>
        [DataMember(Name="releaseStatus", EmitDefaultValue=false)]
        public ReleaseStatus? ReleaseStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject5" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject5() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject5" /> class.
        /// </summary>
        /// <param name="assetUrl">assetUrl (required).</param>
        /// <param name="assetVersion">assetVersion.</param>
        /// <param name="authorName">authorName.</param>
        /// <param name="capacity">capacity (default to 16).</param>
        /// <param name="description">description.</param>
        /// <param name="id">id.</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="platform">platform.</param>
        /// <param name="releaseStatus">releaseStatus.</param>
        /// <param name="tags">tags.</param>
        /// <param name="unityPackageUrl">unityPackageUrl.</param>
        /// <param name="unityVersion">unityVersion (default to &quot;5.3.4p1&quot;).</param>
        public InlineObject5(string assetUrl = default(string), string assetVersion = default(string), string authorName = default(string), int capacity = 16, string description = default(string), string id = default(string), string imageUrl = default(string), string name = default(string), Platform? platform = default(Platform?), ReleaseStatus? releaseStatus = default(ReleaseStatus?), List<string> tags = default(List<string>), string unityPackageUrl = default(string), string unityVersion = "5.3.4p1")
        {
            // to ensure "assetUrl" is required (not null)
            if (assetUrl == null)
            {
                throw new InvalidDataException("assetUrl is a required property for InlineObject5 and cannot be null");
            }
            else
            {
                this.AssetUrl = assetUrl;
            }

            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new InvalidDataException("imageUrl is a required property for InlineObject5 and cannot be null");
            }
            else
            {
                this.ImageUrl = imageUrl;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InlineObject5 and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.AssetVersion = assetVersion;
            this.AuthorName = authorName;
            // use default value if no "capacity" provided
            if (capacity == null)
            {
                this.Capacity = 16;
            }
            else
            {
                this.Capacity = capacity;
            }
            this.Description = description;
            this.Id = id;
            this.Platform = platform;
            this.ReleaseStatus = releaseStatus;
            this.Tags = tags;
            this.UnityPackageUrl = unityPackageUrl;
            // use default value if no "unityVersion" provided
            if (unityVersion == null)
            {
                this.UnityVersion = "5.3.4p1";
            }
            else
            {
                this.UnityVersion = unityVersion;
            }
        }

        /// <summary>
        /// Gets or Sets AssetUrl
        /// </summary>
        [DataMember(Name="assetUrl", EmitDefaultValue=true)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Gets or Sets AssetVersion
        /// </summary>
        [DataMember(Name="assetVersion", EmitDefaultValue=false)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// Gets or Sets AuthorId
        /// </summary>
        [DataMember(Name="authorId", EmitDefaultValue=false)]
        public string AuthorId { get; private set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name="authorName", EmitDefaultValue=false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets UnityPackageUrl
        /// </summary>
        [DataMember(Name="unityPackageUrl", EmitDefaultValue=false)]
        public string UnityPackageUrl { get; set; }

        /// <summary>
        /// Gets or Sets UnityVersion
        /// </summary>
        [DataMember(Name="unityVersion", EmitDefaultValue=false)]
        public string UnityVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject5 {\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  AssetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ReleaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UnityPackageUrl: ").Append(UnityPackageUrl).Append("\n");
            sb.Append("  UnityVersion: ").Append(UnityVersion).Append("\n");
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
            return this.Equals(input as InlineObject5);
        }

        /// <summary>
        /// Returns true if InlineObject5 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject5 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.AssetVersion == input.AssetVersion ||
                    (this.AssetVersion != null &&
                    this.AssetVersion.Equals(input.AssetVersion))
                ) && 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.ReleaseStatus == input.ReleaseStatus ||
                    (this.ReleaseStatus != null &&
                    this.ReleaseStatus.Equals(input.ReleaseStatus))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UnityPackageUrl == input.UnityPackageUrl ||
                    (this.UnityPackageUrl != null &&
                    this.UnityPackageUrl.Equals(input.UnityPackageUrl))
                ) && 
                (
                    this.UnityVersion == input.UnityVersion ||
                    (this.UnityVersion != null &&
                    this.UnityVersion.Equals(input.UnityVersion))
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
                if (this.AssetUrl != null)
                    hashCode = hashCode * 59 + this.AssetUrl.GetHashCode();
                if (this.AssetVersion != null)
                    hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.AuthorId != null)
                    hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.AuthorName != null)
                    hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.ReleaseStatus != null)
                    hashCode = hashCode * 59 + this.ReleaseStatus.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.UnityPackageUrl != null)
                    hashCode = hashCode * 59 + this.UnityPackageUrl.GetHashCode();
                if (this.UnityVersion != null)
                    hashCode = hashCode * 59 + this.UnityVersion.GetHashCode();
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

            // AssetUrl (string) minLength
            if(this.AssetUrl != null && this.AssetUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetUrl, length must be greater than 1.", new [] { "AssetUrl" });
            }
 

            // AssetVersion (string) minLength
            if(this.AssetVersion != null && this.AssetVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetVersion, length must be greater than 1.", new [] { "AssetVersion" });
            }
 

            // AuthorName (string) minLength
            if(this.AuthorName != null && this.AuthorName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorName, length must be greater than 1.", new [] { "AuthorName" });
            }
 

 
            // Capacity (int) maximum
            if(this.Capacity > (int)40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value less than or equal to 40.", new [] { "Capacity" });
            }

            // Capacity (int) minimum
            if(this.Capacity < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value greater than or equal to 1.", new [] { "Capacity" });
            }


 
            // Id (string) pattern
            Regex regexId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }


            // ImageUrl (string) minLength
            if(this.ImageUrl != null && this.ImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be greater than 1.", new [] { "ImageUrl" });
            }
 

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }
 

            // UnityPackageUrl (string) minLength
            if(this.UnityPackageUrl != null && this.UnityPackageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnityPackageUrl, length must be greater than 1.", new [] { "UnityPackageUrl" });
            }
 

            // UnityVersion (string) minLength
            if(this.UnityVersion != null && this.UnityVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnityVersion, length must be greater than 1.", new [] { "UnityVersion" });
            }
 
            yield break;
        }
    }

}
