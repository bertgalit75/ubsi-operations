using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Ropes.API.Auth
{
    public class EzPasPasswordHasher<TUser> : PasswordHasher<TUser> where TUser : class
    {
        public override PasswordVerificationResult VerifyHashedPassword(TUser user, string hashedPassword, string providedPassword)
        {
            var hexPassword = FormatToEzPas(providedPassword);

            var result = string.Compare(hashedPassword, hexPassword, ignoreCase: true) == 0;

            return result ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;

            //"c06617466ae4a7d621cd";
            //"C06617466AE4A7D621CD02D7012A1D25";

            //byte[] decodedHashedPassword = Convert.FromBase64String(hashedPassword);

            //// read the format marker from the hashed password
            //if (decodedHashedPassword.Length == 0)
            //{
            //    return PasswordVerificationResult.Failed;
            //}

            //// ASP.NET Core uses 0x00 and 0x01 for v2 and v3
            //if (decodedHashedPassword[0] == 0xF0)
            //{
            //    // replace the 0xF0 prefix in the stored password with 0x01 (ASP.NET Core Identity V3) and convert back to Base64
            //    decodedHashedPassword[0] = 0x01;
            //    var storedPassword = Convert.ToBase64String(decodedHashedPassword);

            //    // md5 hash the provided password
            //    var md5ProvidedPassword = GetM5Hash(providedPassword);

            //    // call the base implementation with the new values
            //    var result = base.VerifyHashedPassword(user, storedPassword, md5ProvidedPassword);

            //    return result == PasswordVerificationResult.Success
            //        ? PasswordVerificationResult.SuccessRehashNeeded
            //        : result;
            //}

            //return base.VerifyHashedPassword(user, hashedPassword, providedPassword);
        }

        private static string FormatToEzPas(string providedPassword)
        {
            var md5ProvidedPassword = GetM5Hash(providedPassword);
            var base64Password = Convert.FromBase64String(md5ProvidedPassword);

            // Need to convert the password to hex and retrive only the first 20 characters as that's
            // the only part of the hash that is stored. The replace "-" is needed as BitConverter adds dashes
            // between each byte.
            var hexPassword = BitConverter.ToString(base64Password).Replace("-", "").Substring(0, 20);

            return hexPassword;
        }

        public static string GetM5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                var bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                return Convert.ToBase64String(bytes);
            }
        }
    }
}
