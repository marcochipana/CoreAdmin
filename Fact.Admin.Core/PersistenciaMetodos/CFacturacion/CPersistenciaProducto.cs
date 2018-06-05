using Common;
using DominioEntidades.ModeloFactAdmin;
using DominioServicios.IFacturacion;
using PersistenciaModelo.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersistenciaMetodos.CFacturacion
{
    public class CPersistenciaProducto : IDominioProducto
    {
        #region constructor instancia

        readonly db_fact_admin_entities _context;
        public CPersistenciaProducto(db_fact_admin_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion

        public producto GetObjProductoPorProductoId(int intProductoId)
        {
            Log.Inicio();
            try
            {
                Log.Debug("Accion: Obtenemos lista de facturas por fechas; Recurso: SPWB_GETLIST_PLANTILLAS_ACTIVO en Manejador");

                var query = _context.producto.ToList()
                    .Select(sQuery => sQuery)
                    .Where(wQuery => wQuery.prin_producto_id == intProductoId)
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

        public List<producto> GetListProductosLikeNombre(string strNombreProducto)
        {
            try
            {
                var query = _context.producto.ToList()
                    .Select(sQuery => sQuery)
                    .Where(wQuery => wQuery.prvc_nombre_producto.Contains(strNombreProducto))
                    .ToList();

                return query;
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
                string a = "12";
                var query = _context.SPWB_GetListProductos().ToList()
                    .Select(sQuery => sQuery).ToList();
                //.Where(wQuery => wQuery.prvc_nombre_producto.Contains(strNombreProducto))
                //.ToList();

                return query;
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
                var response = 
                    _context.producto.Add(objProducto);
                    _context.SaveChanges();
                
                return objProducto.prin_producto_id;
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
                var query = _context.producto.ToList()
                    .Select(sQuery => sQuery)
                    .Where(wQuery => wQuery.prin_producto_id == objProducto.prin_producto_id)
                    .FirstOrDefault();

                query.cain_categoria_id = objProducto.cain_categoria_id;
                query.prdc_precio_producto = objProducto.prdc_precio_producto;
                query.prvc_nombre_producto = objProducto.prvc_nombre_producto;
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
