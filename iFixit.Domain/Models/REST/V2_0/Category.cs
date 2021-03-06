﻿using System.Collections.Generic;

namespace iFixit.Domain.Models.REST.V2_0.Category
{

   

    public class TopicInfo
    {
        public string name { get; set; }
        public string manufacturer { get; set; }
        public string introduced { get; set; }
        public string discontinued { get; set; }
    }

    public class Image
    {
        public int id { get; set; }
        public string mini { get; set; }
        public string thumbnail { get; set; }
        public string standard { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string original { get; set; }
    }

    public class Solutions
    {
        public string url { get; set; }
        public int count { get; set; }
    }

    public class Category
    {
        public string tag { get; set; }
        public int count { get; set; }
        public string url { get; set; }
    }

    public class Parts
    {
        public string url { get; set; }
      //  public List<Category> categories { get; set; }
    }

    public class Tool
    {
        public string text { get; set; }
        public string url { get; set; }
    }


    public class Guide
    {
        public string dataType { get; set; }
        public int guideid { get; set; }
        public string locale { get; set; }
        public int revisionid { get; set; }
        public double modified_date { get; set; }
        public double? prereq_modified_date { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string subject { get; set; }
        public string title { get; set; }
        public bool @public { get; set; }
        public int userid { get; set; }
        public string username { get; set; }
        //public List<object> flags { get; set; }
        public Image image { get; set; }
    }

    public class RootObject
    {
        public string wiki_title { get; set; }
        public string display_title { get; set; }
        public string locale { get; set; }
        public TopicInfo topic_info { get; set; }
        public Image image { get; set; }
        public string description { get; set; }
        //  public List<object> flags { get; set; }
        public Solutions solutions { get; set; }
       // public List<Parts> parts { get; set; }
        public List<Tool> tools { get; set; }
        public List<Guide> guides { get; set; }
        public List<string> ancestors { get; set; }
        public List<string> children { get; set; }
        public string contents_raw { get; set; }
        //[JsonConverter(typeof(EscapeQuoteConverter))]
        public string contents_rendered { get; set; }
      
    }





}
