using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime History { get; set; }
        public string Explanation { get; set; }
        public string BlokImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}