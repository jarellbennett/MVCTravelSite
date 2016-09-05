using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Review
    {

        public string title;
        private string content;
        private DateTime pubDate;

        [Key]
        public int ID { get; set; }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public DateTime PubDate
        {
            get { return this.pubDate; }
            set { this.pubDate = DateTime.Now; }
        }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}