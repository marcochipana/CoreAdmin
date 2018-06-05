using AplicacionServicios.CAdministracion;
using AplicacionServicios.CUsuarios;
using Common;
using DominioEntidades.ModeloFactAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWebApi
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioFactAdmin
    {
        private readonly CAplicacionEmpresa _aplicacionEmpresa = new CAplicacionEmpresa();
        private readonly CAplicacionDataBase _aplicacionDatabase = new CAplicacionDataBase();
        private readonly CAplicacionLexico _aplicacionLexico = new CAplicacionLexico();
        private readonly CAplicacionRoles _aplicacionRoles = new CAplicacionRoles();

        //#region productos

        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "/GetProducto/{strProductoId}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //public producto GetObjPersona(string strProductoId)
        //{
        //    try
        //    {
        //        //Log.Inicio(objCredenciales);
        //        //if (Credenciales.Validate(objCredenciales))
        //            return _aplicacionProducto.GetObjProductoByProductoId(Convert.ToInt32(strProductoId));
        //        throw new Exception(Credenciales.AccessDenied);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error(ex);
        //        throw;
        //    }

        //}

        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "/GetListProductos/{strNombreProducto}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //public List<producto> GetListPersonasLikeNombre(string strNombreProducto)
        //{
        //    try
        //    {
        //        return _aplicacionProducto.GetListProductosLikeNombre(strNombreProducto);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}

        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "/GetSpListProductos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //public List<producto> GetSpListProductos()
        //{
        //    try
        //    {
        //        return _aplicacionProducto.GetSpListProductos();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}

        //[OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveProducto", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public int SaveProducto(producto objProducto)
        {
            try
            {
                return 1;// _aplicacionProducto.SaveProducto(objProducto);
            }
            catch (Exception)
            {
                throw;
            }

        }

        //[OperationContract]
        //[WebInvoke(Method = "PUT", UriTemplate = "/UpdateProducto/{strProductoId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //public bool UpdateProducto(producto objProducto, string strProductoId)
        //{
        //    try
        //    {
        //        objProducto.prin_producto_id = Convert.ToInt32(strProductoId);
        //        return _aplicacionProducto.UpdateProducto(objProducto);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}

        ////[OperationContract]
        ////[WebInvoke(Method = "DELETE", UriTemplate = "/Transaction/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ////public bool DeleteTransaction(string id)
        ////{
        ////    //
        ////    var persona = new personas();
        ////    persona.nombre = "tes";
        ////    persona.apellido = "test";
        ////    return persona;
        ////    return null;
        ////}

        //#endregion


        #region Admin database

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/CreateCompany/{strCompanyName}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public bool CrearBaseDatos(string strCompanyName)
        {
            try
            {
                return _aplicacionDatabase.CrearBaseDatos(strCompanyName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Lexico

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/LexicoByTabla/{strTabla}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public List<lexico> GetListLexicoByTabla(string strTabla)
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionLexico.GetListLexicoByTabla(strTabla, true);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/LexicoByTablaTema/{strTabla}/{strTema}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public List<lexico> GetListLexicoByTablaTema(string strTabla, string strTema)
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionLexico.GetListLexicoByTablaTema(strTabla, strTema, true);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/LexicoObjByTablaTema/{strTabla}/{strTema}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public lexico GetObjLexicoByTablaTema(string strTabla, string strTema)
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionLexico.GetObjLexicoByTablaTema(strTabla, strTema, true);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        #endregion

        #region empresa

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetListEmpresa/{strNombreEmpresa}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public List<empresa> GetListEmpresaByNombre(string strNombreEmpresa)
        {
            try
            {
                return _aplicacionEmpresa.GetListEmpresaByNombre(strNombreEmpresa, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetListEmpresa", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public List<empresa> GetListEmpresa()
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionEmpresa.GetListEmpresaByNombre(null, true);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetEmpresaById/{strId}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public empresa GetObjEmpresaById(string strId)
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionEmpresa.GetObjEmpresaById(Convert.ToInt64(strId));
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveEmpresa", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public empresa SaveEmpresa(empresa objEmpresa)
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionEmpresa.SaveEmpresa(objEmpresa);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }

        }
        
        #endregion

        #region roles

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetListRoles", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public List<roles> GetListRolesActivo()
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionRoles.GetListRolesActivo(true);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }

        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveRoles", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public roles SaveRol(roles objRol)
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                var response = _aplicacionRoles.SaveRol(objRol);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateRoles/{strRolId}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public bool UpdateRol(roles objRol, string strRolId)
        {
            Log.Inicio();
            try
            {
                //validamos credenciales
                objRol.roin_rol_id = Convert.ToInt32(strRolId);
                var response = _aplicacionRoles.UpdateRol(objRol);
                Log.Fin();
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        #endregion
    }
}

