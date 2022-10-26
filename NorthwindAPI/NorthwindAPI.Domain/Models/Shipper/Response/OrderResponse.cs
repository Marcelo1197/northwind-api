using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindAPI.Domain.Models.Shipper.Response
{
    public class OrderResponse
    {
        public OrderResponse()
        {
            OrderDetails = new HashSet<OrderDetailResponse>();
        }

        public int OrderId { get; set; }
        public string? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipCountry { get; set; }

        public virtual CustomerResponse? Customer { get; set; }
        public virtual EmployeeResponse? Employee { get; set; }
        public virtual ResponseShipper? ShipViaNavigation { get; set; }
        public virtual ICollection<OrderDetailResponse> OrderDetails { get; set; }
    }
}
