using Common;
using DominioEntidades.ModeloFactAdmin;
using DominioServicios.IUsuarios;
using PersistenciaMetodos.CUsuarios;
using PersistenciaModelo.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionServicios.CUsuarios
{
    public class CAplicacionRoles
    {
        #region contructor instancia

        private readonly IDominioRoles _repositorioRoles;

        public CAplicacionRoles()
        {
            var dbContext = new db_fact_admin_entities();
            _repositorioRoles = new CPersistenciaRoles(dbContext);
        }

        #endregion

        public List<roles> GetListRolesActivo(bool bolIsHidden)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtener lista roles; recurso:CAplicacion");
                var response = _repositorioRoles.GetListRolesActivo(bolIsHidden);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        public roles SaveRol(roles objRol)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Guarda rol; recurso:CAplicacion");
                var response = _repositorioRoles.SaveRol(objRol);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        public bool UpdateRol(roles objRol)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: actualiza rol; recurso:CAplicacion");
                var response = _repositorioRoles.UpdateRol(objRol);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }
    }
}
