using System;
using System.Numerics;

namespace Lab4_IT.Algorithms 
{
	internal static class ModularAlgoritms 
	{
		public static bool isPrime(BigInteger x) 
		{
			if (x <= 1 || (x % 2 == 0 && x != 2))
			{
				return false;
			}

			if (x <= 3)
			{
				return true;
			}

			for (BigInteger i = 2; i <= (BigInteger) Math.Sqrt((double) x); i++) 
			{
				if (x % i == 0)
				{
					return false;
				}
			}

			return true;
		}

		public static BigInteger fastExponentialPower(BigInteger a, BigInteger z, BigInteger n) 
		{
			BigInteger power = 1;

			a %= n;

			while (z > 0)
			{
				if (z % 2 == 1)
				{
					power = (power * a) % n;
				}

				z >>= 1;

				a = (a * a) % n;
			}

			return power;
		}

		public static BigInteger modularMultiplicativeInverse(BigInteger a, BigInteger n) 
		{
			return fastExponentialPower(a, n - 2, n);
		}
	}
}
