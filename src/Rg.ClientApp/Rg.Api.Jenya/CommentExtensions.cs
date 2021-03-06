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
    public static partial class CommentExtensions
    {
        /// <param name='operations'>
        /// Reference to the Rg.ClientApp.IComment.
        /// </param>
        /// <param name='commentId'>
        /// Required.
        /// </param>
        /// <param name='likeRequest'>
        /// Required.
        /// </param>
        public static object PostLikeByCommentidAndLikerequest(this IComment operations, int commentId, LikeRequest likeRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IComment)s).PostLikeByCommentidAndLikerequestAsync(commentId, likeRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Rg.ClientApp.IComment.
        /// </param>
        /// <param name='commentId'>
        /// Required.
        /// </param>
        /// <param name='likeRequest'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PostLikeByCommentidAndLikerequestAsync(this IComment operations, int commentId, LikeRequest likeRequest, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PostLikeByCommentidAndLikerequestWithOperationResponseAsync(commentId, likeRequest, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
