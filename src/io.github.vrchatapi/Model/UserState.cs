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
    /// * \&quot;online\&quot; User is online in VRChat * \&quot;active\&quot; User is online, but not in VRChat * \&quot;offline\&quot; User is offline
    /// </summary>
    /// <value>* \&quot;online\&quot; User is online in VRChat * \&quot;active\&quot; User is online, but not in VRChat * \&quot;offline\&quot; User is offline</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UserState
    {
        /// <summary>
        /// Enum Offline for value: offline
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline = 1,

        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 2,

        /// <summary>
        /// Enum Online for value: online
        /// </summary>
        [EnumMember(Value = "online")]
        Online = 3

    }

}
