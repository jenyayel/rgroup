﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Rg.ClientApp;
using Rg.ClientApp.Models;

namespace Rg.ClientApp
{
    public static partial class SearchExtensions
    {
        /// <param name='operations'>
        /// Reference to the Rg.ClientApp.ISearch.
        /// </param>
        /// <param name='term'>
        /// Required.
        /// </param>
        public static SearchResults GetByTerm(this ISearch operations, string term)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISearch)s).GetByTermAsync(term);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Rg.ClientApp.ISearch.
        /// </param>
        /// <param name='term'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<SearchResults> GetByTermAsync(this ISearch operations, string term, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Rg.ClientApp.Models.SearchResults> result = await operations.GetByTermWithOperationResponseAsync(term, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
