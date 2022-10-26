using NorthwindAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Domain.Models.Shipper.Request
{
    public class RequestAddShipper
    {
        public RequestAddShipper()
        {
            Orders = new HashSet<Order>();
        }

        [Required(ErrorMessage = "Ingresar nombre del shipper")]
        [StringLength(40, ErrorMessage = "Ingrese máximo 40 caracteres por favor.")]
        public string CompanyName { get; set; } = null!;

        [RegularExpression(@"\d*", ErrorMessage = "Ingrese solo números por favor.")]
        [StringLength(24, ErrorMessage = "Ingrese máximo 24 números por favor")]
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
