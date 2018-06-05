using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaMetodos.Administracion
{
    class Class1
    {


    }

    //private void MtdCreateTables(string strInstancia, string strDataBaseName, ref string strMensajeInfo)
    //{
    //    try
    //    {
    //        SqlConnection cnn = new SqlConnection(
    //           "Server=" + strInstancia + "; " +
    //           "database=" + strDataBaseName + ";" + " integrated security=yes");

    //        string script = File.ReadAllText(@"ResourcesEntitySystem\DataScript\DB_SystemEntities.sql");

    //        string scriptEntities = script.Replace("#EntityName_CompanyName#", strDataBaseName);
    //        //  string sqlConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ccwebgrity;Data Source=SURAJIT\SQLEXPRESS";

    //        // SqlConnection conn = new SqlConnection(sqlConnectionString);

    //        Server server = new Server(new ServerConnection(cnn));

    //        server.ConnectionContext.ExecuteNonQuery(scriptEntities);
    //    }
    //    catch (Exception ex)
    //    {
    //        strMensajeInfo = "WizardLib(MtdCreateTables) " + ex.Message;
    //    }
    //}

}
