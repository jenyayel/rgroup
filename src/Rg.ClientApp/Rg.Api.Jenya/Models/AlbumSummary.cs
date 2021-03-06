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
    public partial class AlbumSummary
    {
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
        
        private string _description;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _lastModifiedText;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string LastModifiedText
        {
            get { return this._lastModifiedText; }
            set { this._lastModifiedText = value; }
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
        
        private IList<string> _sampleMediaUrls;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> SampleMediaUrls
        {
            get { return this._sampleMediaUrls; }
            set { this._sampleMediaUrls = value; }
        }
        
        private string _title;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
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
        
        /// <summary>
        /// Initializes a new instance of the AlbumSummary class.
        /// </summary>
        public AlbumSummary()
        {
            this.Comments = new LazyList<CommentDetails>();
            this.LikeGroups = new LazyList<LikeGroup>();
            this.SampleMediaUrls = new LazyList<string>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
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
                JToken descriptionValue = inputObject["Description"];
                if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                {
                    this.Description = ((string)descriptionValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken lastModifiedTextValue = inputObject["LastModifiedText"];
                if (lastModifiedTextValue != null && lastModifiedTextValue.Type != JTokenType.Null)
                {
                    this.LastModifiedText = ((string)lastModifiedTextValue);
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
                JToken sampleMediaUrlsSequence = ((JToken)inputObject["SampleMediaUrls"]);
                if (sampleMediaUrlsSequence != null && sampleMediaUrlsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken sampleMediaUrlsValue in ((JArray)sampleMediaUrlsSequence))
                    {
                        this.SampleMediaUrls.Add(((string)sampleMediaUrlsValue));
                    }
                }
                JToken titleValue = inputObject["Title"];
                if (titleValue != null && titleValue.Type != JTokenType.Null)
                {
                    this.Title = ((string)titleValue);
                }
                JToken userIdValue = inputObject["UserId"];
                if (userIdValue != null && userIdValue.Type != JTokenType.Null)
                {
                    this.UserId = ((string)userIdValue);
                }
            }
        }
    }
}
