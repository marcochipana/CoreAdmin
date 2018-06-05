using DominioEntidades.ModeloFactAdmin;
using DominioServicios.IFacturacion;
using PersistenciaModelo.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaMetodos.CFacturacion
{
    public class CPersistenciaCliente : IDominioCliente
    {
        #region constructor instancia

        readonly db_fact_admin_entities _context;
        public CPersistenciaCliente(db_fact_admin_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion

        public List<cliente> GetListClienteByPaterno(string strNombrePaterno)
        {
            try
            {
                var query = _context.cliente.ToList()
                    .Select(sQuery => sQuery)
                    .Where(wQuery => wQuery.clvc_apellido.Contains(strNombrePaterno))
                    .ToList();

                return query;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
