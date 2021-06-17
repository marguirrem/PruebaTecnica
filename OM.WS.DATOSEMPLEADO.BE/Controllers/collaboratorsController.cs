using OM.WS.DATOSEMPLEADO.BE.Data;
using OM.WS.DATOSEMPLEADO.BE.Models;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;

namespace OM.WS.DATOSEMPLEADO.BE.Controllers
{
    public class collaboratorsController : ApiController
    {

        private CMysql cMySql = new CMysql();
        DataSet ds = new DataSet();
        string sSql;

        // GET: api/collaborators
        public IEnumerable<Colaborador> Get()
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            ds.Tables.Clear();
            ds.Clear();

            sSql += "call sp_GetColaboradores();";

            ds = cMySql.EjecutarSQL_DS(sSql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i =0; i<ds.Tables[0].Rows.Count;i++) {
                    Colaborador c1 = new Colaborador();
                    c1.IdColaborador = long.Parse( ds.Tables[0].Rows[i]["IDCOLABORADOR"].ToString());
                    c1.Nombre =ds.Tables[0].Rows[i]["NOMBRE"].ToString();
                    c1.Apellido =ds.Tables[0].Rows[i]["APELLIDO"].ToString();
                    c1.Profesion =ds.Tables[0].Rows[i]["PROFESION"].ToString();
                    c1.Direccion =ds.Tables[0].Rows[i]["DIRECCION"].ToString();
                    c1.Edad =ds.Tables[0].Rows[i]["EDAD"].ToString();
                    c1.EstadoCivil =ds.Tables[0].Rows[i]["ESTADOCIVIL"].ToString();
                    colaboradores.Add(c1);
                }
                    
                return colaboradores;
            }
            return null;
        }
    }
}
