using DominioServicios.Administracion;
using PersistenciaMetodos.Administracion;
using PersistenciaModelo.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionServicios.CAdministracion
{
    public class CAplicacionDataBase
    {
        #region contructor instancia

        private readonly IDominioDatabase _repositorioDataBaseAdmin;

        public CAplicacionDataBase()
        {
            var dbContext = new db_fact_admin_entities();
            _repositorioDataBaseAdmin = new CPersistenciaDatabase(dbContext);
        }

        #endregion

        public bool CrearBaseDatos(string strCompanyName)
        {
            try
            {
                return _repositorioDataBaseAdmin.CrearBaseDatos(strCompanyName);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
