using DominioEntidades.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioServicios.IFacturacion
{
    public interface IDominioCliente
    {
        List<cliente> GetListClienteByPaterno(string strNombrePaterno);
    }
}
