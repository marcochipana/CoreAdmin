using DominioEntidades.ModeloFactAdmin;
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
    public class CAplicacionEmpresa
    {
        #region contructor instancia

        private readonly IDominioDatabase _repositorioDataBaseAdmin;
        private readonly IDominioEmpresa _repositorioEmpresa;

        public CAplicacionEmpresa()
        {
            var dbContext = new db_fact_admin_entities();
            _repositorioEmpresa = new CPersistenciaEmpresa(dbContext);
            _repositorioDataBaseAdmin = new CPersistenciaDatabase(dbContext);
        }

        #endregion

        public List<empresa> GetListEmpresaByNombre(string strNombreEmpresa, bool bolIsHidden)
        {
            try
            {
                return _repositorioEmpresa.GetListEmpresaByNombre(strNombreEmpresa, bolIsHidden);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public empresa GetObjEmpresaById(long longEmpresaId)
        {
            try
            {
                return _repositorioEmpresa.GetObjEmpresaById(longEmpresaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public empresa SaveEmpresa(empresa objEmpresa)
        {
            try
            {
                if (_repositorioDataBaseAdmin.CrearBaseDatos(objEmpresa.emvc_nombre_empresa))
                    return _repositorioEmpresa.SaveEmpresa(objEmpresa);

                return new empresa();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
