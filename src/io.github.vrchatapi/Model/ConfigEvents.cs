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
    /// ConfigEvents
    /// </summary>
    [DataContract]
    public partial class ConfigEvents :  IEquatable<ConfigEvents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConfigEvents()
        {
        }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="distanceClose", EmitDefaultValue=true)]
        public decimal DistanceClose { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="distanceFactor", EmitDefaultValue=true)]
        public decimal DistanceFactor { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="distanceFar", EmitDefaultValue=true)]
        public decimal DistanceFar { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="groupDistance", EmitDefaultValue=true)]
        public decimal GroupDistance { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="maximumBunchSize", EmitDefaultValue=true)]
        public decimal MaximumBunchSize { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="notVisibleFactor", EmitDefaultValue=true)]
        public decimal NotVisibleFactor { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="playerOrderBucketSize", EmitDefaultValue=true)]
        public decimal PlayerOrderBucketSize { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="playerOrderFactor", EmitDefaultValue=true)]
        public decimal PlayerOrderFactor { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="slowUpdateFactorThreshold", EmitDefaultValue=true)]
        public decimal SlowUpdateFactorThreshold { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name="viewSegmentLength", EmitDefaultValue=true)]
        public decimal ViewSegmentLength { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigEvents {\n");
            sb.Append("  DistanceClose: ").Append(DistanceClose).Append("\n");
            sb.Append("  DistanceFactor: ").Append(DistanceFactor).Append("\n");
            sb.Append("  DistanceFar: ").Append(DistanceFar).Append("\n");
            sb.Append("  GroupDistance: ").Append(GroupDistance).Append("\n");
            sb.Append("  MaximumBunchSize: ").Append(MaximumBunchSize).Append("\n");
            sb.Append("  NotVisibleFactor: ").Append(NotVisibleFactor).Append("\n");
            sb.Append("  PlayerOrderBucketSize: ").Append(PlayerOrderBucketSize).Append("\n");
            sb.Append("  PlayerOrderFactor: ").Append(PlayerOrderFactor).Append("\n");
            sb.Append("  SlowUpdateFactorThreshold: ").Append(SlowUpdateFactorThreshold).Append("\n");
            sb.Append("  ViewSegmentLength: ").Append(ViewSegmentLength).Append("\n");
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
            return this.Equals(input as ConfigEvents);
        }

        /// <summary>
        /// Returns true if ConfigEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigEvents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DistanceClose == input.DistanceClose ||
                    (this.DistanceClose != null &&
                    this.DistanceClose.Equals(input.DistanceClose))
                ) && 
                (
                    this.DistanceFactor == input.DistanceFactor ||
                    (this.DistanceFactor != null &&
                    this.DistanceFactor.Equals(input.DistanceFactor))
                ) && 
                (
                    this.DistanceFar == input.DistanceFar ||
                    (this.DistanceFar != null &&
                    this.DistanceFar.Equals(input.DistanceFar))
                ) && 
                (
                    this.GroupDistance == input.GroupDistance ||
                    (this.GroupDistance != null &&
                    this.GroupDistance.Equals(input.GroupDistance))
                ) && 
                (
                    this.MaximumBunchSize == input.MaximumBunchSize ||
                    (this.MaximumBunchSize != null &&
                    this.MaximumBunchSize.Equals(input.MaximumBunchSize))
                ) && 
                (
                    this.NotVisibleFactor == input.NotVisibleFactor ||
                    (this.NotVisibleFactor != null &&
                    this.NotVisibleFactor.Equals(input.NotVisibleFactor))
                ) && 
                (
                    this.PlayerOrderBucketSize == input.PlayerOrderBucketSize ||
                    (this.PlayerOrderBucketSize != null &&
                    this.PlayerOrderBucketSize.Equals(input.PlayerOrderBucketSize))
                ) && 
                (
                    this.PlayerOrderFactor == input.PlayerOrderFactor ||
                    (this.PlayerOrderFactor != null &&
                    this.PlayerOrderFactor.Equals(input.PlayerOrderFactor))
                ) && 
                (
                    this.SlowUpdateFactorThreshold == input.SlowUpdateFactorThreshold ||
                    (this.SlowUpdateFactorThreshold != null &&
                    this.SlowUpdateFactorThreshold.Equals(input.SlowUpdateFactorThreshold))
                ) && 
                (
                    this.ViewSegmentLength == input.ViewSegmentLength ||
                    (this.ViewSegmentLength != null &&
                    this.ViewSegmentLength.Equals(input.ViewSegmentLength))
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
                if (this.DistanceClose != null)
                    hashCode = hashCode * 59 + this.DistanceClose.GetHashCode();
                if (this.DistanceFactor != null)
                    hashCode = hashCode * 59 + this.DistanceFactor.GetHashCode();
                if (this.DistanceFar != null)
                    hashCode = hashCode * 59 + this.DistanceFar.GetHashCode();
                if (this.GroupDistance != null)
                    hashCode = hashCode * 59 + this.GroupDistance.GetHashCode();
                if (this.MaximumBunchSize != null)
                    hashCode = hashCode * 59 + this.MaximumBunchSize.GetHashCode();
                if (this.NotVisibleFactor != null)
                    hashCode = hashCode * 59 + this.NotVisibleFactor.GetHashCode();
                if (this.PlayerOrderBucketSize != null)
                    hashCode = hashCode * 59 + this.PlayerOrderBucketSize.GetHashCode();
                if (this.PlayerOrderFactor != null)
                    hashCode = hashCode * 59 + this.PlayerOrderFactor.GetHashCode();
                if (this.SlowUpdateFactorThreshold != null)
                    hashCode = hashCode * 59 + this.SlowUpdateFactorThreshold.GetHashCode();
                if (this.ViewSegmentLength != null)
                    hashCode = hashCode * 59 + this.ViewSegmentLength.GetHashCode();
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
