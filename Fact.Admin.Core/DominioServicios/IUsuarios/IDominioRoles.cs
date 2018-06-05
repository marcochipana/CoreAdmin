using DominioEntidades.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioServicios.IUsuarios
{
    public interface IDominioRoles
    {
        List<roles> GetListRolesActivo(bool bolIsHidden);

        roles SaveRol(roles objRol);

        bool UpdateRol(roles objRol);

        roles GetObjRolesByIdRol(int intRolId);
    }
}
