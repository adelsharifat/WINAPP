using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class ConnectionST
    {
        public static string GetConnectionString(string envFilePath = @"")
        {
            try
            {
                if (String.IsNullOrEmpty(envFilePath))
                    envFilePath = AppDomain.CurrentDomain.BaseDirectory.ToString() + ".env";
                var env = CmisEnvFile.Env(envFilePath);
                return Crypto.Decrypt(env["CMIS_CONNECTION_STRING"], "cmis2020");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public static class CmisEnvFile
    {
        public static Dictionary<string, string> Env(string envFilePath)
        {
            try
            {
                string[] cfgFileData = File.ReadAllLines(envFilePath);
                var pairs = cfgFileData.Select(l => new { Line = l, Pos = l.IndexOf("=") });
                var dictionary = pairs.ToDictionary(p => p.Line.Substring(0, p.Pos).Trim(), p => p.Line.Substring(p.Pos + 1).Trim());
                return dictionary;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public static class Crypto
    {
        public static string Encrypt(string input, string salt)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMd5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMd5Provider.ComputeHash(Encoding.UTF8.GetBytes(salt));
                    tripleDESCryptoServiceProvider.Key = byteHash;
                    tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
                    byte[] data = Encoding.UTF8.GetBytes(input);
                    return Convert.ToBase64String(tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        public static string Decrypt(string encrypt, string salt)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMd5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMd5Provider.ComputeHash(Encoding.UTF8.GetBytes(salt));
                    tripleDESCryptoServiceProvider.Key = byteHash;
                    tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
                    byte[] data = Convert.FromBase64String(encrypt);
                    return Encoding.UTF8.GetString(tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
    }
}
