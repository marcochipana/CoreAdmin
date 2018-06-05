using DominioEntidades.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioServicios.Administracion
{
    public interface IDominioEmpresa
    {
        List<empresa> GetListEmpresaByNombre(string strNombreEmpresa, bool bolIsHidden);

        empresa GetObjEmpresaById(long longEmpresaId);

        empresa SaveEmpresa(empresa objEmpresa);
    }
}
