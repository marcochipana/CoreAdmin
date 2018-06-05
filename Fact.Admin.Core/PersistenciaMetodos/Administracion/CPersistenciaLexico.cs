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
    public class CPersistenciaLexico : IDominioLexico
    {
        #region constructor instancia

        readonly db_fact_admin_entities _context;
        public CPersistenciaLexico(db_fact_admin_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion

        public List<lexico> GetListLexicoByTabla(string strTabla, bool bolIsHidden)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtener lista lexico por tabla; recurso:CPersistencia");

                var query = _context.lexico.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.lxvc_tabla == strTabla && wQuery.lxbt_is_hidden == bolIsHidden)
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

        public List<lexico> GetListLexicoByTablaTema(string strTabla, string strTema, bool bolIsHidden)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtener lista lexico por tabla; recurso:CPersistencia");

                var query = _context.lexico.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.lxvc_tabla == strTabla 
                           && wQuery.lxvc_tema == strTema
                           && wQuery.lxbt_is_hidden == bolIsHidden)
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

        public lexico GetObjLexicoByTablaTema(string strTabla, string strTema, bool bolIsHidden)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtener lista lexico por tabla; recurso:CPersistencia");

                var query = _context.lexico.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.lxvc_tabla == strTabla
                           && wQuery.lxvc_tema == strTema
                           && wQuery.lxbt_is_hidden == bolIsHidden)
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
    }
}
