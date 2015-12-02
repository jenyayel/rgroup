﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;
using Rg.ClientApp.Models;

namespace Rg.ClientApp.Models
{
    public partial class TimelineEntryDetails
    {
        private string _avatarUrl;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string AvatarUrl
        {
            get { return this._avatarUrl; }
            set { this._avatarUrl = value; }
        }
        
        private IList<CommentDetails> _comments;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<CommentDetails> Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }
        
        private string _commentUrl;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string CommentUrl
        {
            get { return this._commentUrl; }
            set { this._commentUrl = value; }
        }
        
        private string _dateTime;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string DateTime
        {
            get { return this._dateTime; }
            set { this._dateTime = value; }
        }
        
        private IList<LikeGroup> _likeGroups;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<LikeGroup> LikeGroups
        {
            get { return this._likeGroups; }
            set { this._likeGroups = value; }
        }
        
        private string _likeUrl;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string LikeUrl
        {
            get { return this._likeUrl; }
            set { this._likeUrl = value; }
        }
        
        private IList<string> _mediaUrls;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> MediaUrls
        {
            get { return this._mediaUrls; }
            set { this._mediaUrls = value; }
        }
        
        private string _message;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _userId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }
        
        private string _userName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TimelineEntryDetails class.
        /// </summary>
        public TimelineEntryDetails()
        {
            this.Comments = new LazyList<CommentDetails>();
            this.LikeGroups = new LazyList<LikeGroup>();
            this.MediaUrls = new LazyList<string>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken avatarUrlValue = inputObject["AvatarUrl"];
                if (avatarUrlValue != null && avatarUrlValue.Type != JTokenType.Null)
                {
                    this.AvatarUrl = ((string)avatarUrlValue);
                }
                JToken commentsSequence = ((JToken)inputObject["Comments"]);
                if (commentsSequence != null && commentsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken commentsValue in ((JArray)commentsSequence))
                    {
                        CommentDetails commentDetails = new CommentDetails();
                        commentDetails.DeserializeJson(commentsValue);
                        this.Comments.Add(commentDetails);
                    }
                }
                JToken commentUrlValue = inputObject["CommentUrl"];
                if (commentUrlValue != null && commentUrlValue.Type != JTokenType.Null)
                {
                    this.CommentUrl = ((string)commentUrlValue);
                }
                JToken dateTimeValue = inputObject["DateTime"];
                if (dateTimeValue != null && dateTimeValue.Type != JTokenType.Null)
                {
                    this.DateTime = ((string)dateTimeValue);
                }
                JToken likeGroupsSequence = ((JToken)inputObject["LikeGroups"]);
                if (likeGroupsSequence != null && likeGroupsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken likeGroupsValue in ((JArray)likeGroupsSequence))
                    {
                        LikeGroup likeGroup = new LikeGroup();
                        likeGroup.DeserializeJson(likeGroupsValue);
                        this.LikeGroups.Add(likeGroup);
                    }
                }
                JToken likeUrlValue = inputObject["LikeUrl"];
                if (likeUrlValue != null && likeUrlValue.Type != JTokenType.Null)
                {
                    this.LikeUrl = ((string)likeUrlValue);
                }
                JToken mediaUrlsSequence = ((JToken)inputObject["MediaUrls"]);
                if (mediaUrlsSequence != null && mediaUrlsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken mediaUrlsValue in ((JArray)mediaUrlsSequence))
                    {
                        this.MediaUrls.Add(((string)mediaUrlsValue));
                    }
                }
                JToken messageValue = inputObject["Message"];
                if (messageValue != null && messageValue.Type != JTokenType.Null)
                {
                    this.Message = ((string)messageValue);
                }
                JToken userIdValue = inputObject["UserId"];
                if (userIdValue != null && userIdValue.Type != JTokenType.Null)
                {
                    this.UserId = ((string)userIdValue);
                }
                JToken userNameValue = inputObject["UserName"];
                if (userNameValue != null && userNameValue.Type != JTokenType.Null)
                {
                    this.UserName = ((string)userNameValue);
                }
            }
        }
    }
}
