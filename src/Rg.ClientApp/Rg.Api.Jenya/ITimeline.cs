﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Rg.ClientApp.Models;

namespace Rg.ClientApp
{
    public partial interface ITimeline
    {
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<TimelineEntryDetails>> GetByIdWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='since'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<TimelineEntryDetails>>> GetBySinceWithOperationResponseAsync(string since = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='createMessage'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PostByCreatemessageWithOperationResponseAsync(CreateTimelineEntry createMessage, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='entryId'>
        /// Required.
        /// </param>
        /// <param name='commentRequest'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PostCommentByEntryidAndCommentrequestWithOperationResponseAsync(int entryId, CommentRequest commentRequest, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='entryId'>
        /// Required.
        /// </param>
        /// <param name='likeRequest'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PostLikeByEntryidAndLikerequestWithOperationResponseAsync(int entryId, LikeRequest likeRequest, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
