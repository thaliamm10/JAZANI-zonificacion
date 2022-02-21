using Jazani.Comunes.Utilitarios.Infraestructura.Dtos;
using Jazani.Comunes.Utilitarios.Infraestructura.Utilitarios;
using Jazani.ICL.Datos.RegistroMasivo.Entidades;
using Jazani.ICL.Datos.RegistroMasivo.Repositorios.Abstracciones;
using Jazani.ICL.Servicios.RegistroMasivo.Dtos;
using Jazani.ICL.Servicios.RegistroMasivo.Servicios.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.ICL.Servicios.RegistroMasivo.Servicios.Implementaciones
{
    public class PruebaServicio : IPruebaServicio
    {
        private readonly IPruebaRepositorio _pruebaRepositorio;
        public PruebaServicio(
                IPruebaRepositorio pruebaRepositorio
            )
        {
            _pruebaRepositorio = pruebaRepositorio;
        }

        public async Task<OperacionDto<RespuestaSimpleDto<string>>> RegistrarAsync(string json_data)
        {
            await _pruebaRepositorio.registrarAsync(json_data);

            return new OperacionDto<RespuestaSimpleDto<string>>(
                new RespuestaSimpleDto<string>()
                {
                    Mensaje = "Se guardó con éxito."
                });
        }
    }
}
