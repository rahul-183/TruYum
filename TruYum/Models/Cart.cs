using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TruYum.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [Display(Name ="MenuItems")]
        public virtual int Id { get; set; }

        [ForeignKey("Id")]
        public MenuItem Menuitems { get; set; }
    }
}