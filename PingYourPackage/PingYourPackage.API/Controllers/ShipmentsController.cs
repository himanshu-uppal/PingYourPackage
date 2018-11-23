using PingYourPackage.API.Model.Dtos;
using PingYourPackage.API.Model.RequestCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * GET /api/shipments
 * GET /api/shipments/{key}
 * POST /api/shipments
 * PUT /api/shipments/{key}
 */
namespace PingYourPackage.API.Controllers
{
    public class ShipmentsController
    {
        public PaginatedDto<ShipmentDto>
 GetShipments(PaginatedRequestCommand cmd)
        {
            var shipments = _shipmentService
            .GetShipments(cmd.Page, cmd.Take);
            return shipments.ToPaginatedDto(
            shipments.Select(sh => sh.ToShipmentDto()));
        }
    }
}
