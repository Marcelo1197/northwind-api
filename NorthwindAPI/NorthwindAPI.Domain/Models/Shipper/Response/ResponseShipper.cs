using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Domain.Models.Shipper.Response
{
    public class ResponseShipper
    {
        public ResponseShipper()
        {
            Orders = new HashSet<OrderResponse>();
        }

        [Required]
        public int ShipperId { get; set; }

        [Required]
        public string CompanyName { get; set; } = null!;
        
        public string? Phone { get; set; }

        public virtual ICollection<OrderResponse> Orders { get; set; }
    }
}
