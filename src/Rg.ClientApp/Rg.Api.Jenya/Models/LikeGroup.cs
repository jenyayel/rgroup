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
    public partial class LikeGroup
    {
        private string _kind;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Kind
        {
            get { return this._kind; }
            set { this._kind = value; }
        }
        
        private IList<User> _users;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<User> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LikeGroup class.
        /// </summary>
        public LikeGroup()
        {
            this.Users = new LazyList<User>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken kindValue = inputObject["Kind"];
                if (kindValue != null && kindValue.Type != JTokenType.Null)
                {
                    this.Kind = ((string)kindValue);
                }
                JToken usersSequence = ((JToken)inputObject["Users"]);
                if (usersSequence != null && usersSequence.Type != JTokenType.Null)
                {
                    foreach (JToken usersValue in ((JArray)usersSequence))
                    {
                        User user = new User();
                        user.DeserializeJson(usersValue);
                        this.Users.Add(user);
                    }
                }
            }
        }
    }
}
