// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsCumPrincRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsCumPrincRequestBody
    {
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rate", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Nper.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nper", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Nper { get; set; }
    
        /// <summary>
        /// Gets or sets Pv.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pv", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Pv { get; set; }
    
        /// <summary>
        /// Gets or sets StartPeriod.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startPeriod", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken StartPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets EndPeriod.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endPeriod", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken EndPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Type { get; set; }
    
    }
}
