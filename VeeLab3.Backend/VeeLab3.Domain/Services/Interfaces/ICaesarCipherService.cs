using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeeLab3.Domain.Services.Interfaces
{
    public interface ICaesarCipherService
    {
        public Task<string> EncryptAsync(string str, int key);

        public Task<string> DecryptAsync(string str, int key);
    }
}
