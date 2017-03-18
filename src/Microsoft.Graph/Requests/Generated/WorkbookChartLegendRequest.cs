// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WorkbookChartLegendRequest.
    /// </summary>
    public partial class WorkbookChartLegendRequest : BaseRequest, IWorkbookChartLegendRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartLegendRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartLegendRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartLegend using POST.
        /// </summary>
        /// <param name="workbookChartLegendToCreate">The WorkbookChartLegend to create.</param>
        /// <returns>The created WorkbookChartLegend.</returns>
        public System.Threading.Tasks.Task<WorkbookChartLegend> CreateAsync(WorkbookChartLegend workbookChartLegendToCreate)
        {
            return this.CreateAsync(workbookChartLegendToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartLegend using POST.
        /// </summary>
        /// <param name="workbookChartLegendToCreate">The WorkbookChartLegend to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartLegend.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartLegend> CreateAsync(WorkbookChartLegend workbookChartLegendToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartLegend>(workbookChartLegendToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookChartLegend.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartLegend.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartLegend>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartLegend.
        /// </summary>
        /// <returns>The WorkbookChartLegend.</returns>
        public System.Threading.Tasks.Task<WorkbookChartLegend> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartLegend.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartLegend.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartLegend> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartLegend>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartLegend using PATCH.
        /// </summary>
        /// <param name="workbookChartLegendToUpdate">The WorkbookChartLegend to update.</param>
        /// <returns>The updated WorkbookChartLegend.</returns>
        public System.Threading.Tasks.Task<WorkbookChartLegend> UpdateAsync(WorkbookChartLegend workbookChartLegendToUpdate)
        {
            return this.UpdateAsync(workbookChartLegendToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartLegend using PATCH.
        /// </summary>
        /// <param name="workbookChartLegendToUpdate">The WorkbookChartLegend to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartLegend.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartLegend> UpdateAsync(WorkbookChartLegend workbookChartLegendToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartLegend>(workbookChartLegendToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartLegendRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartLegendRequest Expand(Expression<Func<WorkbookChartLegend, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartLegendRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartLegendRequest Select(Expression<Func<WorkbookChartLegend, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookChartLegendToInitialize">The <see cref="WorkbookChartLegend"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartLegend workbookChartLegendToInitialize)
        {

        }
    }
}
