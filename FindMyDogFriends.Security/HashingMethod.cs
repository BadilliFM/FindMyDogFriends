using System.Security.Cryptography;
using System.Text;

namespace FindMyDogFriends.Security;

public class HashingMethod
{
    public static byte[] ComputeHashSha512(byte[] toBeHashed)
    {
        using (var sha512 = SHA512.Create())
        {
            return sha512.ComputeHash(toBeHashed);
        }
    }
    public static string HashString(string password)
    {
        return Convert.ToBase64String(HashingMethod.ComputeHashSha512(Encoding.UTF8.GetBytes(password)));
    }
}
