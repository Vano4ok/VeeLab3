using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeeLab3.Domain.Services.Interfaces;

namespace VeeLab3.Domain.Services.Implementation
{
    public class CaesarCipherService : ICaesarCipherService
    {
        public async Task<string> EncryptAsync(string str, int key)
        {
            return await Task.Run(() =>
            {
                StringBuilder output = new StringBuilder();

                foreach (char ch in str)
                {
                    if (!char.IsLetter(ch))
                    {
                        output.Append(ch);
                    }
                    else
                    {
                        char d = char.IsUpper(ch) ? 'A' : 'a';
                        output.Append((char)(((ch + key - d) % 26) + d));
                    }
                }

                return output.ToString();
            });
        }

        public async Task<string> DecryptAsync(string str, int key)
        {
            return await EncryptAsync(str, 26 - (key % 26));
        }
    }
}
