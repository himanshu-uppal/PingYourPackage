using PingYourPackage.API.Extensions;
using PingYourPackage.API.Model.Dtos;
using PingYourPackage.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PingYourPackage.API.Controllers
{
    [System.Web.Http.Route("DefaultHttpRoute")]
    public class ShipmentController : ApiController
    {
        private readonly IShipmentService _shipmentService;
        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }
        //public PaginatedDto<ShipmentDto> GetShipments(PaginatedRequestCommand cmd)
        //{
        //    var shipments = _shipmentService
        //    .GetShipments(cmd.Page, cmd.Take);
        //    return shipments.ToPaginatedDto(
        //    shipments.Select(sh => sh.ToShipmentDto()));
        //}
        public PaginatedDto<ShipmentDto> GetShipments()
        {
            var shipments = _shipmentService.GetShipments(2, 3);
            return shipments.ToPaginatedDto(
            shipments.Select(sh => sh.ToShipmentDto()));
        }
    }
    }
