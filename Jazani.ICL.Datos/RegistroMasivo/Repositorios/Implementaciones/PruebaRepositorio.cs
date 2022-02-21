using Jazani.Comunes.DatosBase.Infraestructura.Repositorios.Abstracciones;
using Jazani.Comunes.DatosEF.Infraestructura.Repositorios.Abstracciones;
using Jazani.ICL.Datos.Infraestructura.Configuraciones.Abstracciones;
using Jazani.ICL.Datos.Infraestructura.Contextos.Abstracciones;
using Jazani.ICL.Datos.Infraestructura.Repositorios.Implementaciones;
using Jazani.ICL.Datos.RegistroMasivo.Entidades;
using Jazani.ICL.Datos.RegistroMasivo.Repositorios.Abstracciones;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.ICL.Datos.RegistroMasivo.Repositorios.Implementaciones
{
    public class PruebaRepositorio : ICLRepositorio<Prueba, string>, IPruebaRepositorio
    {
        public PruebaRepositorio(IICLUnidadDeTrabajo unidadDeTrabajo, IICLConfiguracion configuracion) : base(unidadDeTrabajo, configuracion) { }

        public async Task<Prueba> registrarAsync(string json_data)
        {
            var sql = "PCK_PRUEBA.SP_REGISTRAR";

            using (var conexion = new OracleConnection(Configuracion.CadenaConexion))
            {
                using var comando = new OracleCommand(sql, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("@P_DATA", OracleDbType.Varchar2, json_data, ParameterDirection.Input));
                //comando.Parameters.Add(new OracleParameter("@p_lista", OracleDbType.RefCursor, ParameterDirection.Output));
                conexion.Open();
                await comando.ExecuteNonQueryAsync();
                
            }

            Prueba data = new Prueba();
            data.nombre = "HOLA";
            data.descripcion = "DESIEKDIE";
            data.estado = 1;

            return data;
        }
    }
}
