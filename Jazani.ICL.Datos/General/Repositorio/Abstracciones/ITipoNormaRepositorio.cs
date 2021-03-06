using System;
using Jazani.ICL.Datos.General.Entidades;
using Jazani.ICL.Datos.Infraestructura.Repositorios.Abstracciones;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.ICL.Datos.General.Repositorio.Abstracciones
{

    public interface ITipoNormaRepositorio : IICLRepositorio<Tipo_Norma, long>
    {
        
        Task<List<Tipo_Norma>> ListarAsync();
        //Task<Tuple<List<Sector>, int>> ListarPaginadoAsync(string orden, int start, int length, string nombre = null);
    }
}
