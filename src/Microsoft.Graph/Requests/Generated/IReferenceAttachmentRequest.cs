// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IReferenceAttachmentRequest.
    /// </summary>
    public partial interface IReferenceAttachmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ReferenceAttachment using PUT.
        /// </summary>
        /// <param name="referenceAttachmentToCreate">The ReferenceAttachment to create.</param>
        /// <returns>The created ReferenceAttachment.</returns>
        System.Threading.Tasks.Task<ReferenceAttachment> CreateAsync(ReferenceAttachment referenceAttachmentToCreate);        /// <summary>
        /// Creates the specified ReferenceAttachment using PUT.
        /// </summary>
        /// <param name="referenceAttachmentToCreate">The ReferenceAttachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ReferenceAttachment.</returns>
        System.Threading.Tasks.Task<ReferenceAttachment> CreateAsync(ReferenceAttachment referenceAttachmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ReferenceAttachment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ReferenceAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ReferenceAttachment.
        /// </summary>
        /// <returns>The ReferenceAttachment.</returns>
        System.Threading.Tasks.Task<ReferenceAttachment> GetAsync();

        /// <summary>
        /// Gets the specified ReferenceAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ReferenceAttachment.</returns>
        System.Threading.Tasks.Task<ReferenceAttachment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ReferenceAttachment using PATCH.
        /// </summary>
        /// <param name="referenceAttachmentToUpdate">The ReferenceAttachment to update.</param>
        /// <returns>The updated ReferenceAttachment.</returns>
        System.Threading.Tasks.Task<ReferenceAttachment> UpdateAsync(ReferenceAttachment referenceAttachmentToUpdate);

        /// <summary>
        /// Updates the specified ReferenceAttachment using PATCH.
        /// </summary>
        /// <param name="referenceAttachmentToUpdate">The ReferenceAttachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ReferenceAttachment.</returns>
        System.Threading.Tasks.Task<ReferenceAttachment> UpdateAsync(ReferenceAttachment referenceAttachmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReferenceAttachmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IReferenceAttachmentRequest Expand(Expression<Func<ReferenceAttachment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReferenceAttachmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IReferenceAttachmentRequest Select(Expression<Func<ReferenceAttachment, object>> selectExpression);

    }
}
