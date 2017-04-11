using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("Subscription")]
    public class Subscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubscriptionId { get; set; }
        [MaxLength(255)]
        [Required]
        public string SubscriptionTitle { get; set; }
        [MaxLength(2048)]
        public string SubscriptionDescription { get; set; }
        [MaxLength(20)]
        [DisplayName("Registration Code")]
        public string SubscriptionRegistrationCode { get; set; }
    }
}