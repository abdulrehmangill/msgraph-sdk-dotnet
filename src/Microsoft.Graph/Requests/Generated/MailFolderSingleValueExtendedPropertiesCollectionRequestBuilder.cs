// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type MailFolderSingleValueExtendedPropertiesCollectionRequestBuilder.
    /// </summary>
    public partial class MailFolderSingleValueExtendedPropertiesCollectionRequestBuilder : BaseRequestBuilder, IMailFolderSingleValueExtendedPropertiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new MailFolderSingleValueExtendedPropertiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MailFolderSingleValueExtendedPropertiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMailFolderSingleValueExtendedPropertiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMailFolderSingleValueExtendedPropertiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new MailFolderSingleValueExtendedPropertiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISingleValueLegacyExtendedPropertyRequestBuilder"/> for the specified MailFolderSingleValueLegacyExtendedProperty.
        /// </summary>
        /// <param name="id">The ID for the MailFolderSingleValueLegacyExtendedProperty.</param>
        /// <returns>The <see cref="ISingleValueLegacyExtendedPropertyRequestBuilder"/>.</returns>
        public ISingleValueLegacyExtendedPropertyRequestBuilder this[string id]
        {
            get
            {
                return new SingleValueLegacyExtendedPropertyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
