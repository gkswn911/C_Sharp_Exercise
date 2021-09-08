using System.Security.Cryptography;

namespace sha256
{

public string SHA256Hash1 (string data)
{
    SHA256Managed sha256Managed = new SHA256Managed();

    byte[] encryptBytes = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(data));

    String encryptString = Convert.ToBase64String(encryptBytes);
}

  // 혹은 아래와 같은 방법도 있다.
public string SHA256Hash2 (string data) 
{

	SHA256 sha = new SHA256Managed ();
  
	byte[] hash = sha.ComputeHash (Encoding.ASCII.GetBytes (data));
	StringBuilder stringBuilder = new StringBuilder();

	foreach (byte b in hash) 
  {
		stringBuilder.AppendFormat ("{0:x2}", b);
	}
	return stringBuilder.ToString ();
}

}
