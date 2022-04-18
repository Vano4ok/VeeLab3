using Microsoft.AspNetCore.Mvc;
using VeeLab3.Domain.Dto;
using VeeLab3.Domain.Services.Interfaces;

namespace VeeLab3.WebApi.Controllers
{
    [Route("api/caesarcipher")]
    [ApiController]
    public class CaesarCipherController : Controller
    {
        private readonly ICaesarCipherService caesarCipherService;

        public CaesarCipherController(ICaesarCipherService caesarCipherService)
        {
            this.caesarCipherService = caesarCipherService;
        }

        /// <summary>
        /// Encrypt the string.
        /// </summary>
        /// <param name="caesarCipherRequestDto">The caesar cipher request.</param>
        /// <returns>Encrypted string.</returns>
        [HttpPost("encrypt")]
        public async Task<IActionResult> Encrypt([FromBody] CaesarCipherRequestDto caesarCipherRequestDto)
        {
            return Ok(await caesarCipherService.EncryptAsync(caesarCipherRequestDto.Str, caesarCipherRequestDto.Key));
        }

        /// <summary>
        /// Decrypt the string.
        /// </summary>
        /// <param name="caesarCipherRequestDto">The caesar cipher request.</param>
        /// <returns>Decrypted string.</returns>
        [HttpPost("decrypt")]
        public async Task<IActionResult> Decrypt([FromBody] CaesarCipherRequestDto caesarCipherRequestDto)
        {
            return Ok(await caesarCipherService.DecryptAsync(caesarCipherRequestDto.Str, caesarCipherRequestDto.Key));
        }
    }
}
