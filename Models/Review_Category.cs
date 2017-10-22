using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review_Category
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Review")]
        public int? ReviewID { get; set; }
        public Review Review { get; set; }

        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
    }
}