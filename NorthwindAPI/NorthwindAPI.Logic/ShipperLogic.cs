using NorthwindAPI.Domain.Models.Shipper.Response;
using NorthwindAPI.Domain.Models.Shipper.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindAPI.Entities;

namespace NorthwindAPI.Logic
{
    public class ShipperLogic : BaseLogic
    {
        public Shipper Get(int id)
        {
            try
            {
                var shipperFound = _context.Shippers.Find(id);
                if (shipperFound == null)
                {
                    throw new Exception(); //TODO: manage ex
                }

                return shipperFound;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ResponseShipper> GetAll()
        {
            try
            {
                return _context.Shippers
                    .Select(s => new ResponseShipper
                    {
                        ShipperId = s.ShipperId,
                        CompanyName = s.CompanyName,
                        Phone = s.Phone,
                    })
                    .ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Add(RequestAddShipper shipper)
        {
            try
            {
                _context.Shippers
                    .Add(new Entities.Shipper
                    {
                        CompanyName = shipper.CompanyName,
                        Phone = shipper.Phone
                    });
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(RequestEditShipper shipper)
        {
            try
            {
                var shipperFinded = _context.Shippers.Find(shipper.ShipperId);
                if (shipperFinded == null)
                {
                    throw new Exception(); //TODO: manage ex
                }
                shipperFinded.CompanyName = shipper.CompanyName;
                shipperFinded.Phone = shipper.Phone;
                shipperFinded.Orders = shipper.Orders;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var shipperToDelete = _context.Shippers.Find(id);
                if (shipperToDelete == null)
                {
                    throw new Exception(); //TODO: manage ex
                }
                _context.Remove(shipperToDelete);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
