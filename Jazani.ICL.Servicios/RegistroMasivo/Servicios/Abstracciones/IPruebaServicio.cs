using Jazani.Comunes.Utilitarios.Infraestructura.Dtos;
using Jazani.ICL.Datos.RegistroMasivo.Entidades;
using Jazani.ICL.Servicios.RegistroMasivo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.ICL.Servicios.RegistroMasivo.Servicios.Abstracciones
{
    public interface IPruebaServicio
    {
        Task<OperacionDto<RespuestaSimpleDto<string>>> RegistrarAsync(string json_data);
    }
}
