using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public  int ReviewID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string PublishDate { get; set; }
        public bool WouldRate { get; set; }

        public virtual ICollection<Review_Category> Reviews_Categories { get; set; }

    }
}