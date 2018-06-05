using Common;
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
    public class CAplicacionProducto
    {
        #region contructor instancia

        private readonly IDominioProducto _repositorioProducto;

        public CAplicacionProducto()
        {
            var dbContext = new db_fact_admin_entities();
            _repositorioProducto = new CPersistenciaProducto(dbContext);
        }

        #endregion

        public producto GetObjProductoByProductoId(int intProductoId)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Guardar objeto lote; Recurso: Entity query en ConsumoCarga");

                var response = _repositorioProducto.GetObjProductoPorProductoId(intProductoId);
                Log.Fin();
                return response;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<producto> GetListProductosLikeNombre(string strNombreProducto)
        {
            try
            {
                return _repositorioProducto.GetListProductosLikeNombre(strNombreProducto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int SaveProducto(producto objProducto)
        {
            try
            {
                return _repositorioProducto.SaveProducto(objProducto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<producto> GetSpListProductos()
        {
            try
            {
                return _repositorioProducto.GetSpListProductos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateProducto(producto objProducto)
        {
            try
            {
                return _repositorioProducto.UpdateProducto(objProducto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
