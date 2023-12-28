﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class Post
    {
        private static int currentPostId;

        protected int ID {  get; set; }
        protected string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        //default constructor
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Sercan Ölmez";
        }
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUserName;
            this.IsPublic = isPublic;
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
