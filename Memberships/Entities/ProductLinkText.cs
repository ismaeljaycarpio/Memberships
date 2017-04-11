using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("ProductLinkText")]
    public class ProductLinkText
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductLinkTextId { get; set; }
        [MaxLength(25)]
        [Required]
        public string ProductLinkTextTitle { get; set; }
    }
}