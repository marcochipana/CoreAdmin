using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Encryptador
    {
        public Encryptador(string s_NomSegcrypt)
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public bool EncryptDecryptPublic(bool enDec, string strInput, ref string strOutput)
        {
            return EncryptDecrypt(enDec, strInput, ref strOutput);
        }

        /// <summary>
        /// Función wraper para encriptar y desencriptar valores - Segurinet
        /// </summary>
        /// <param name="EnDec">true - Encriptar, false - Desencriptar</param>
        /// <param name="InputString">String Valor</param>
        /// <param name="OutputRaw">Resultado</param>
        /// <param name="Length">Tamaño del string destino.</param>
        /// <returns></returns>
        unsafe private static bool EncryptDecrypt(bool enDec, string strInput, ref string strOutput)
        {
            bool res = false;

            int chrSize = strInput.Length * 2;
            byte[] byteRes = new byte[chrSize];
            strOutput = "";

            fixed (byte* pByteRes = &byteRes[0])
            {
                res = EncryptDecrypt(enDec, strInput, pByteRes, &chrSize);
                for (int i = 0; i < chrSize; i++)
                    strOutput += ((char)*(pByteRes + i));
            }
            return res;
        }


        /// <summary>
        /// Función para encriptar y desencriptar valores - Segurinet
        /// </summary>
        /// <param name="EnDec">true - Encriptar, false - Desencriptar</param>
        /// <param name="InputString">String Valor</param>
        /// <param name="OutputRaw">Resultado</param>
        /// <param name="Length">Tamaño del string destino.</param>
        /// <returns></returns>
        /// 

        [DllImport(@"SegCryptCrediSeguros.dll")]
        unsafe private static extern bool EncryptDecrypt(bool EnDec, string InputString, byte* OutputRaw, int* Length);

    }
}
