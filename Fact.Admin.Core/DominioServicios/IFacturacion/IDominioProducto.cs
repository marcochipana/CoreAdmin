using DominioEntidades.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioServicios.IFacturacion
{
    public interface IDominioProducto
    {
        producto GetObjProductoPorProductoId(int intProductoId);

        List<producto> GetListProductosLikeNombre(string strNombreProducto);

        List<producto> GetSpListProductos();

        int SaveProducto(producto objProducto);

        bool UpdateProducto(producto objProducto);
    }
}
