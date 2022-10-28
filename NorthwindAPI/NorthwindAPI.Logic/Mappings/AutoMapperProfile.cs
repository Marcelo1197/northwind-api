using AutoMapper;
using NorthwindAPI.Domain.Models.Shipper.Request;
using NorthwindAPI.Domain.Models.Shipper.Response;
using NorthwindAPI.Entities;

namespace NorthwindAPI.Logic.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Shippers
            CreateMap<RequestAddShipper, Shipper>();
            CreateMap<RequestEditShipper, Shipper>();
            CreateMap<Shipper, ResponseShipper>();
        }
    }
}
