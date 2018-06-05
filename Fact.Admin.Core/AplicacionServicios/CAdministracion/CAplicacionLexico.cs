using Common;
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
    public class CAplicacionLexico
    {
        #region contructor instancia

        private readonly IDominioLexico _repositorioLexico;

        public CAplicacionLexico()
        {
            var dbContext = new db_fact_admin_entities();
            _repositorioLexico = new CPersistenciaLexico(dbContext);
        }

        #endregion

        public List<lexico> GetListLexicoByTabla(string strTabla, bool bolIsHidden)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtener lista lexico por tabla; recurso:CAplicacion");
                var response = _repositorioLexico.GetListLexicoByTabla(strTabla, bolIsHidden);
                Log.Fin();
                return response;
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
                Log.Debug("Accion: Obtener lista lexico por tabla y tema; recurso:CAplicacion");
                var response = _repositorioLexico.GetListLexicoByTablaTema(strTabla, strTema, bolIsHidden);
                Log.Fin();
                return response;
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
                Log.Debug("Accion: Obtener objeto lexico por tabla y tema; recurso:CAplicacion");
                var response = _repositorioLexico.GetObjLexicoByTablaTema(strTabla, strTema, bolIsHidden);
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
