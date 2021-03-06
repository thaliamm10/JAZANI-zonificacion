using Jazani.ICL.Datos.Infraestructura.Repositorios.Abstracciones;
using Jazani.ICL.Datos.ProcedimientoGeneral.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.ICL.Datos.ProcedimientoGeneral.Repositorios.Abstracciones
{
    public interface IProcedimientoRepositorio : IICLRepositorio<Procedimiento, int>
    {
        Task<List<Procedimiento>> ListarAsync(String nombre, int estado);
    }
}
