using Common;
using DominioEntidades.ModeloFactAdmin;
using DominioServicios.Administracion;
using PersistenciaModelo.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaMetodos.Administracion
{
    public class CPersistenciaEmpresa : IDominioEmpresa
    {
        #region constructor instancia

        readonly db_fact_admin_entities _context;
        public CPersistenciaEmpresa(db_fact_admin_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion

        public List<empresa> GetListEmpresaByNombre(string strNombreEmpresa, bool bolIsHidden)
        {
            Log.Inicio();
            try
            {
                List<empresa> query;
                if (strNombreEmpresa == null)
                {
                    query = _context.empresa.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.embt_is_hidden == bolIsHidden)
                   .ToList();
                }
                else
                {
                    query = _context.empresa.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.emvc_nombre_empresa.Contains(strNombreEmpresa) && wQuery.embt_is_hidden == bolIsHidden)
                   .ToList();
                }

                Log.Fin();
                return query;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }

        }

        public empresa GetObjEmpresaById(long longEmpresaId)
        {
            Log.Inicio();
            try
            {
               
               var query = _context.empresa.ToList()
               .Select(sQuery => sQuery)
               .Where(wQuery => wQuery.embi_empresa_id == longEmpresaId)
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

        public empresa SaveEmpresa(empresa objEmpresa)
        {
            Log.Inicio();
            try
            {
                var response =  _context.empresa.Add(objEmpresa);
                                _context.SaveChanges();


                Log.Fin();
                //return objEmpresa.embi_empresa_id;                
                return objEmpresa;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }

        }        
    }
}
