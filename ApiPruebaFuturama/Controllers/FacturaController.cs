using Facturama;
using Facturama.Models.Request;
using Facturama.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaFuturama.Controllers
{
	[ApiController]
	[Route("cdfi")]
	public class FacturaController : ControllerBase
	{
		[HttpGet]
		[Route("listar")]
		public dynamic listarCDFIS()
		{
			var facturama = new FacturamaApiMultiemisor("pruebas", "pruebas2011");
			
			var cdfis = facturama.Cfdis.List();
			
			return cdfis;
		}

		[HttpGet]
		[Route("listarPorId")]
		public dynamic listarCdfiPorId(string id) {
			var facturama = new FacturamaApiMultiemisor("pruebas", "pruebas2011");

			var Cdfi = facturama.Cfdis.Retrieve(id);
			
			return Cdfi;
		}
	}
}
