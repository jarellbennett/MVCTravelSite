using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Category
    {
        public int ID { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public string Name { get; set; }

    }
}