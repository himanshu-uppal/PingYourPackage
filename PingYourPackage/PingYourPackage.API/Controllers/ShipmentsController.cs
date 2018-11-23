using PingYourPackage.API.Model;
using PingYourPackage.API.Model.Dtos;
using PingYourPackage.API.Model.RequestCommands;
using PingYourPackage.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

/*
 * 
 * GET /api/shipments
 * GET /api/shipments/{key}
 * POST /api/shipments
 * PUT /api/shipments/{key}
 */
namespace PingYourPackage.API.Controllers
{
    public class ShipmentsController :ApiController
    {
        private readonly IShipmentService _shipmentService;
        public ShipmentsController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }
        public PaginatedDto<ShipmentDto> GetShipments(PaginatedRequestCommand cmd)
        {
            var shipments = _shipmentService
            .GetShipments(cmd.Page, cmd.Take);
            return shipments.ToPaginatedDto(
            shipments.Select(sh => sh.ToShipmentDto()));
        }
    }
}
