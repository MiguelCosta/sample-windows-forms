namespace Mpc.WinFormsIoC.Application.Services.Security
{
    using System.Security.Cryptography;
    using System.Text;

    internal class EncryptTextSha1 : IEncryptText
    {
        public string Encrypt(string text)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (var b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
