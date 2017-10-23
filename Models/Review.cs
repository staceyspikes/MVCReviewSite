using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public  int ReviewID { get; set; }
        [DisplayName ("Name")]
        public string Title { get; set; }
        public string Content { get; set; }
        [DisplayName ("Published Date")]
        public string PublishDate { get; set; }
        [DisplayName("Would you buy again?")]
        public bool WouldRate { get; set; }

        public virtual ICollection<Review_Category> Reviews_Categories { get; set; }

    }
}