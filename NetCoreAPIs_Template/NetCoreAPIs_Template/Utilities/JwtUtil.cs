using Microsoft.IdentityModel.Tokens;
using NetCoreAPIs_Template.AppSettings;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Utilities
{
    public class JwtUtil
    {
        public string CreateJwtToken(string userId)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName, userId)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SettingsHelper.Jwt.JwtKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expires = DateTime.Now.AddDays(Convert.ToDouble(SettingsHelper.Jwt.JwtExpireDays));

                var token = new JwtSecurityToken(
                    issuer: SettingsHelper.Jwt.JwtIssuer,
                    claims: claims,
                    expires: expires,
                    signingCredentials: creds
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
