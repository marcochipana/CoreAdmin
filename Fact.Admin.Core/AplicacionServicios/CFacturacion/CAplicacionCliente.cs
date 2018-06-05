using DominioEntidades.ModeloFactAdmin;
using DominioServicios.IFacturacion;
using PersistenciaMetodos.CFacturacion;
using PersistenciaModelo.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionServicios.CFacturacion
{
    public class CAplicacionCliente
    {
        #region contructor instancia

        private readonly IDominioCliente _repositorioCliente;

        public CAplicacionCliente()
        {
            var dbContext = new db_fact_admin_entities();
            _repositorioCliente = new CPersistenciaCliente(dbContext);
        }

        #endregion

        public List<cliente> GetListClienteByPaterno(string strPaterno)
        {
            try
            {
                return _repositorioCliente.GetListClienteByPaterno(strPaterno);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
