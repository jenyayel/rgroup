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
    public partial class MediaUploadResults
    {
        private IList<MediaUploadResult> _files;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<MediaUploadResult> Files
        {
            get { return this._files; }
            set { this._files = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaUploadResults class.
        /// </summary>
        public MediaUploadResults()
        {
            this.Files = new LazyList<MediaUploadResult>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken filesSequence = ((JToken)inputObject["Files"]);
                if (filesSequence != null && filesSequence.Type != JTokenType.Null)
                {
                    foreach (JToken filesValue in ((JArray)filesSequence))
                    {
                        MediaUploadResult mediaUploadResult = new MediaUploadResult();
                        mediaUploadResult.DeserializeJson(filesValue);
                        this.Files.Add(mediaUploadResult);
                    }
                }
            }
        }
    }
}
