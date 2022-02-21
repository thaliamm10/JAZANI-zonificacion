using Jazani.Comunes.Base.ApiWeb.Base;
using Jazani.ICL.Datos.RegistroMasivo.Entidades;
using Jazani.ICL.Servicios.RegistroMasivo.Dtos;
using Jazani.ICL.Servicios.RegistroMasivo.Servicios.Abstracciones;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jazani.ICL.ApiWeb.Controllers.RegistroMasivo
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ApiControladorBase
    {
        private readonly IPruebaServicio _pruebaServicio;
        public PruebaController(
                IPruebaServicio pruebaServicio
            )
        {
            _pruebaServicio = pruebaServicio;
        }

        [HttpPost("registrar")]
        public async Task<List<PruebaDto>> RegistrarAsync(List<PruebaDto> dats)
        {

            List<PruebaDto> datas = new List<PruebaDto>();

            StringBuilder sb = new StringBuilder();

            sb.Append("<prueba>");

            foreach (PruebaDto prueba in dats)
            {
                sb.Append("<r>");
                sb.Append("<FB>");
                sb.Append("<n>");
                sb.Append(prueba.nombre);
                sb.Append("</n>");
                sb.Append("<d>");
                sb.Append(prueba.descripcion);
                sb.Append("</d>");
                sb.Append("<e>");
                sb.Append(prueba.estado);
                sb.Append("</e>");
                sb.Append("</FB>");
                sb.Append("</r>");
            }

            sb.Append("</prueba>");

            string xml_data = sb.ToString();

            await _pruebaServicio.RegistrarAsync(xml_data);

            return dats;
        }
    }
}
