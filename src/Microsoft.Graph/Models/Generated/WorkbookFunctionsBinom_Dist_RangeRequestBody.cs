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
    /// The type WorkbookFunctionsBinom_Dist_RangeRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsBinom_Dist_RangeRequestBody
    {
    
        /// <summary>
        /// Gets or sets Trials.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trials", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Trials { get; set; }
    
        /// <summary>
        /// Gets or sets ProbabilityS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "probabilityS", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken ProbabilityS { get; set; }
    
        /// <summary>
        /// Gets or sets NumberS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numberS", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken NumberS { get; set; }
    
        /// <summary>
        /// Gets or sets NumberS2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numberS2", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken NumberS2 { get; set; }
    
    }
}
