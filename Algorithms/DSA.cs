using System.Numerics;
using System.Text;

namespace Lab4_IT.Algorithms
{
	internal static class DSA
	{
		private static BigInteger getHash(string M, BigInteger q)
		{
			BigInteger H = 100;
			byte[] bytes = Encoding.UTF8.GetBytes(M);

			foreach (byte b in bytes)
			{
				H = ((H + b) * (H + b)) % q;
			}

			return H;
		}

		public static (BigInteger r, BigInteger s) sign(
			BigInteger q, BigInteger p, BigInteger x, BigInteger k,
			BigInteger g,
			ref BigInteger hash,
			string M)
		{
			BigInteger r, s, inversedK;

			hash = getHash(M, q);

			r = ModularAlgoritms.fastExponentialPower(g, k, p) % q;
			if (r == 0) return (0, 0);

			inversedK = ModularAlgoritms.modularMultiplicativeInverse(k, q);

			s = (inversedK * (hash + x * r)) % q;
			if (s == 0) return (0, 0);

			return (r, s);
		}

		public static BigInteger verify(
			BigInteger q, BigInteger p,
			BigInteger g, BigInteger y,
			BigInteger r, BigInteger s,
			ref BigInteger hash,
			string signedM)
		{
			if (r <= 0 || r >= q || s <= 0 || s >= q) return 0;

			hash = getHash(signedM, q);

			BigInteger w = ModularAlgoritms.modularMultiplicativeInverse(s, q);
			BigInteger u1 = (hash * w) % q;
			BigInteger u2 = (r * w) % q;

			BigInteger v = ((ModularAlgoritms.fastExponentialPower(g, u1, p) *
							 ModularAlgoritms.fastExponentialPower(y, u2, p)) % p) % q;

			return v;
		}
	}
}
