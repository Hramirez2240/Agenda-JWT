using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Agenda_Crud_JWT.Services.JWT
{
    public class JWTAuthenticationManager : IJWTAuthenticationManager
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public JWTAuthenticationManager(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public string Authenticate(string email, string password)
        {

            var items = _applicationDbContext.GetDbSet<User>().Select(x => new
            {
                x.Email,
                x.Password,
            });

            if (!items.Any(x => x.Email == email && x.Password == password))
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenKey = Encoding.ASCII.GetBytes("Holaamigosgoldozozoylolajiji");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, email)
                }),

                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = 
                new SigningCredentials
                (
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
