////using EmprestimoLivroAPI.Interfaces;
//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;
//using System;
//using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;

//namespace EmprestimoLivroAPI.Services
//{
//    public class TokenService : ITokenService
//    {
//        private readonly SymmetricSecurityKey _chave;
//        public TokenService
//        (IConfiguration config)
//        {
//            _chave = new SymmetricSecurityKey
//                (Encoding.UTF8.GetBytes
//                (config["chaveSecreta"]));
//        }

//        public string CreateToken(User user)
//        {
//            var claims = new List<Claim>
//                {
//                    new Claim
//                    (JwtRegisteredClaimNames.NameId,
//                      user.UserName)
//                };
//            var credenciais = new SigningCredentials(_chave,
//             SecurityAlgorithms.HmacSha512Signature);

//            var tokenDescriptor = new SecuityTokenDescriptor
//            {
//                Subjext = new ClaimsIdenity(claims),
//                Expires = DateTime.Now.AddDays(7),
//                SigningCredentials = credenciais
//            };

//            var tokenHandler = new JwtSecurityTokenHandler();

//            var token = tokenHandler.CreateToken(tokenDescriptor);
//            return tokenHandler.WriteToken(token);
//        }
//    }
//}
