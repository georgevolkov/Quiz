using System;
using System.Security.Cryptography;
using System.Text;

namespace QuestionsApplication.Encryption
{
   public static class ShaStringExtension
   {
      public static string Encrypt(this string password)
      {
         using (var sha1 = new SHA1Managed())
         {
            var hash = Encoding.UTF8.GetBytes(password);
            var generatedHash = sha1.ComputeHash(hash);
            var generatedHashString = Convert.ToBase64String(generatedHash);
            return generatedHashString;
         }
      }
   }
}