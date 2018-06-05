using Common;
using DominioEntidades.ModeloFactAdmin;
using DominioServicios.IUsuarios;
using PersistenciaModelo.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaMetodos.CUsuarios
{
    public class CPersistenciaRoles : IDominioRoles
    {
        #region constructor instancia

        readonly db_fact_admin_entities _context;
        public CPersistenciaRoles(db_fact_admin_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion

        public List<roles> GetListRolesActivo(bool bolIsHidden)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtener lista roles activo; recurso:CPersistencia");
                List<roles> query;
                
                    query = _context.roles.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.robt_is_hidden == bolIsHidden)
                   .ToList();                

                Log.Fin();
                return query;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }

        }

        public roles GetObjRolesByIdRol(int intRolId)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtener objeto rol por id; recurso:CPersistencia");
                
                var query = _context.roles.ToList()
               .Select(sQuery => sQuery)
               .Where(wQuery => wQuery.roin_rol_id == intRolId)
               .FirstOrDefault();

                Log.Fin();
                return query;
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
                Log.Debug("Accion: Guarda rol; recurso:CPersistencia");
                var response = _context.roles.Add(objRol);
                _context.SaveChanges();

                Log.Fin();               
                return objRol;
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
                Log.Debug("Accion: actualiza rol; recurso:CPersistencia");
                var query = _context.roles.ToList()
                    .Select(sQuery => sQuery)
                    .Where(wQuery => wQuery.roin_rol_id == objRol.roin_rol_id)
                    .FirstOrDefault();

                query.rovc_nombre_rol = objRol.rovc_nombre_rol;
                _context.SaveChanges();
                Log.Fin();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return false;
                throw;
            }

        }
    }
}
