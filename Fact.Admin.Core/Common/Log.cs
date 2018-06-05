using DominioEntidades.ModeloFactAdmin;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Log
    {
        public static string _usuario;
        public static string _ip;

        static Log()
        {
            //log4net.Core.LoggerManager.GetAllRepositories();
            XmlConfigurator.Configure();
            //log4net.Repository.ILoggerRepository[] aux = log4net.Core.LoggerManager.GetAllRepositories();
            //IAppender[] lista = aux[0].GetAppenders();
            //foreach (IAppender appender in lista)
            //{
            //    if (appender.Name == "AdoNetAppender")
            //    {

            //    }
            //}
            //   log4net.Appender.AdoNetAppender jjas = log4net.Appender.AdoNetAppender;

        }

        /// <summary>
        /// Level DEBUG a grabar en el log
        /// </summary>
        /// <param name="message">Mensaje a grabar en el log</param>
        public static void Debug(string message)
        {
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Debug(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + message);
        }

        /// <summary>
        /// Level ERROR a grabar en el log
        /// </summary>
        /// <param name="ex">Exception capturada para grabar, se puede enviar null</param>
        public static void Error(Exception ex)
        {
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Error(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + "Se genero un error", ex);
        }

        /// <summary>
        /// Level Fatal a grabar en el log
        /// </summary>
        /// <param name="message">Mensaje a grabar en el log</param>
        /// <param name="ex">Exception capturada para grabar, se puede enviar null</param>
        public static void Fatal(string message, Exception ex)
        {
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Fatal(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + message, ex);
        }

        /// <summary>
        /// Level Warn (peligro) a grabar en el log
        /// </summary>
        /// <param name="message">Mensaje a grabar en el log</param>
        /// <param name="ex">Exception capturada para grabar, se puede enviar null</param>
        public static void Warn(string message, Exception ex)
        {
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Warn(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + message, ex);
        }

        /// <summary>
        /// Level Info (informativo) a grabar en el log
        /// </summary>
        /// <param name="message">Mensaje a grabar en el log</param>
        public static void Info(string message)
        {
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Info(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + message);
        }

        /// <summary>
        /// Level Info (informativo) a grabar en el log
        /// </summary>
        public static void Inicio()
        {
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Info(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + "Iniciando Metodo");
        }

        /// <summary>
        /// Level Info (informativo) a grabar en el log
        /// </summary>
        public static void Fin()
        {
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Info(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + "Terminando Metodo");
        }

        /// <summary>
        /// Level Info (informativo) a grabar en el log
        /// </summary>
        public static void Inicio(credenciales objCredenciales)
        {
            _usuario = objCredenciales.usuario;
            _ip = objCredenciales.ip;
            MethodBase methodo = new StackTrace().GetFrame(1).GetMethod();
            ILog Logger = LogManager.GetLogger(methodo.Module.Name);
            string nombreMetodo = methodo.Name;
            string nombreClase = methodo.DeclaringType.Name;
            Logger.Info(nombreClase + "/" + nombreMetodo + "/" + _usuario + "/" + _ip + "/" + "Inicio con Credenciales");
        }
    }
}
