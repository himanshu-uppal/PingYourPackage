using PingYourPackage.API.Model.Dtos;
using PingYourPackage.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using PingYourPackage.API.Extensions;
using PingYourPackage.Domain.Entities;

namespace PingYourPackage.API.WebHost.Controllers
{
    [System.Web.Http.Route("DefaultHttpRoute")]
    public class ShipmentsController : ApiController
    {
        private readonly IShipmentService _shipmentService;
        public ShipmentsController(IShipmentService shipmentService)
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
        public List<Shipment> GetShipments()
        {
            var shipments = _shipmentService.GetShipments(2, 3).ToList();
            return shipments;
            //return shipments.ToPaginatedDto(
            //shipments.Select(sh => sh.ToShipmentDto()));
        }
    }
}