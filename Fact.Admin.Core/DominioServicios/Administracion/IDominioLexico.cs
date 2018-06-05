using DominioEntidades.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioServicios.Administracion
{
    public interface IDominioLexico
    {
        List<lexico> GetListLexicoByTabla(string strTabla, bool bolIsHidden);

        List<lexico> GetListLexicoByTablaTema(string strTabla, string strTema, bool bolIsHidden);

        lexico GetObjLexicoByTablaTema(string strTabla, string strTema, bool bolIsHidden);
    }
}
