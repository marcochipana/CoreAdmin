using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominioServicios.Administracion;
using PersistenciaModelo.ModeloFactAdmin;
using System.IO;
using System.Web;

namespace PersistenciaMetodos.Administracion
{
    public class CPersistenciaDatabase : IDominioDatabase
    {
        #region constructor instancia

        readonly db_fact_admin_entities _context;
        public CPersistenciaDatabase(db_fact_admin_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion             

        public bool CrearBaseDatos(string strCompanyName)
        {
            try
            {

                //var query = _context.Database.SqlQuery<cliente>("Select * from cliente").ToList();
                //var dataBaseCreated = _context.Database.ExecuteSqlCommand("CREATE DATABASE " + strCompanyName);
                var dataBaseCreated = 1;
                if (dataBaseCreated != 0)
                {
                    string root = HttpContext.Current.Server.MapPath(".");
                    string parent = Path.GetDirectoryName(root);

                    var sqlDatabasePath = parent + @"\Common\";
                                    
                    string filePathName = Path.GetFullPath(sqlDatabasePath + @"\DB_Company.sql");

                    string script = File.ReadAllText(@filePathName);
                    //string script = File.ReadAllText(@"~/Common/DB_Company.sql");
                    string scriptEntities = script.Replace("#Facturacion_CompanyName#", strCompanyName);

                    var tablesDatabaseCreated = _context.Database.ExecuteSqlCommand(scriptEntities);

                    if (tablesDatabaseCreated!=0)
                    {
                        return true;
                    }
                }
                //.Select(sQuery => sQuery)
                //.Where(wQuery => wQuery.clvc_apellido.Contains(strNombrePaterno))
                //.ToList();

                return false;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
