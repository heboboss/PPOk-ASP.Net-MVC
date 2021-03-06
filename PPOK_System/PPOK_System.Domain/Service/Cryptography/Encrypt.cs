﻿using System.Security.Cryptography;
using System.Text;

namespace PPOK_System.Domain.Service.Cryptography {
	public static class Encrypt {
		public static string Encode(string value) {
			SHA256 sha256 = SHA256.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			byte[] hash = sha256.ComputeHash(bytes);
			return GetStringFromHash(hash);
		}

		private static string GetStringFromHash(byte[] hash) {
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < hash.Length; i++) {
				result.Append(hash[i].ToString("X2"));
			}
			return result.ToString();
		}
	}
}
