using Jazani.ICL.Datos.Infraestructura.Repositorios.Abstracciones;
using Jazani.ICL.Datos.RegistroMasivo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.ICL.Datos.RegistroMasivo.Repositorios.Abstracciones
{
    public interface IPruebaRepositorio : IICLRepositorio<Prueba, string>
    {
        Task<Prueba> registrarAsync(string json_data);
    }
}
