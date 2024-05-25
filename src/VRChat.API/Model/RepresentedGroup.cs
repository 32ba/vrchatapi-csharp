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
    /// RepresentedGroup
    /// </summary>
    [DataContract(Name = "representedGroup")]
    public partial class RepresentedGroup : IEquatable<RepresentedGroup>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public GroupPrivacy? Privacy { get; set; }

        /// <summary>
        /// Gets or Sets MemberVisibility
        /// </summary>
        [DataMember(Name = "memberVisibility", EmitDefaultValue = false)]
        public GroupUserVisibility? MemberVisibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentedGroup" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="shortCode">shortCode.</param>
        /// <param name="discriminator">discriminator.</param>
        /// <param name="description">description.</param>
        /// <param name="iconId">iconId.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="bannerId">bannerId.</param>
        /// <param name="bannerUrl">bannerUrl.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="ownerId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="memberCount">memberCount.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="memberVisibility">memberVisibility.</param>
        /// <param name="isRepresenting">isRepresenting.</param>
        public RepresentedGroup(string name = default(string), string shortCode = default(string), string discriminator = default(string), string description = default(string), string iconId = default(string), string iconUrl = default(string), string bannerId = default(string), string bannerUrl = default(string), GroupPrivacy? privacy = default(GroupPrivacy?), string ownerId = default(string), int memberCount = default(int), string groupId = default(string), GroupUserVisibility? memberVisibility = default(GroupUserVisibility?), bool isRepresenting = default(bool))
        {
            this.Name = name;
            this.ShortCode = shortCode;
            this.Discriminator = discriminator;
            this.Description = description;
            this.IconId = iconId;
            this.IconUrl = iconUrl;
            this.BannerId = bannerId;
            this.BannerUrl = bannerUrl;
            this.Privacy = privacy;
            this.OwnerId = ownerId;
            this.MemberCount = memberCount;
            this.GroupId = groupId;
            this.MemberVisibility = memberVisibility;
            this.IsRepresenting = isRepresenting;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name = "shortCode", EmitDefaultValue = false)]
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", EmitDefaultValue = false)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [DataMember(Name = "iconId", EmitDefaultValue = true)]
        public string IconId { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name = "iconUrl", EmitDefaultValue = true)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets BannerId
        /// </summary>
        [DataMember(Name = "bannerId", EmitDefaultValue = true)]
        public string BannerId { get; set; }

        /// <summary>
        /// Gets or Sets BannerUrl
        /// </summary>
        [DataMember(Name = "bannerUrl", EmitDefaultValue = true)]
        public string BannerUrl { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name = "memberCount", EmitDefaultValue = false)]
        public int MemberCount { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets IsRepresenting
        /// </summary>
        [DataMember(Name = "isRepresenting", EmitDefaultValue = true)]
        public bool IsRepresenting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RepresentedGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("  BannerUrl: ").Append(BannerUrl).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  MemberVisibility: ").Append(MemberVisibility).Append("\n");
            sb.Append("  IsRepresenting: ").Append(IsRepresenting).Append("\n");
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
            return this.Equals(input as RepresentedGroup);
        }

        /// <summary>
        /// Returns true if RepresentedGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of RepresentedGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepresentedGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.Discriminator == input.Discriminator ||
                    (this.Discriminator != null &&
                    this.Discriminator.Equals(input.Discriminator))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.BannerUrl == input.BannerUrl ||
                    (this.BannerUrl != null &&
                    this.BannerUrl.Equals(input.BannerUrl))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    this.MemberCount.Equals(input.MemberCount)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.MemberVisibility == input.MemberVisibility ||
                    this.MemberVisibility.Equals(input.MemberVisibility)
                ) && 
                (
                    this.IsRepresenting == input.IsRepresenting ||
                    this.IsRepresenting.Equals(input.IsRepresenting)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ShortCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCode.GetHashCode();
                }
                if (this.Discriminator != null)
                {
                    hashCode = (hashCode * 59) + this.Discriminator.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IconId != null)
                {
                    hashCode = (hashCode * 59) + this.IconId.GetHashCode();
                }
                if (this.IconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconUrl.GetHashCode();
                }
                if (this.BannerId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerId.GetHashCode();
                }
                if (this.BannerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Privacy.GetHashCode();
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MemberCount.GetHashCode();
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MemberVisibility.GetHashCode();
                hashCode = (hashCode * 59) + this.IsRepresenting.GetHashCode();
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
