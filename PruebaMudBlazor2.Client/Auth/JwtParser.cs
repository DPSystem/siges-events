using System.Security.Claims;
using System.Text.Json;

namespace PruebaMudBlazor2.Client.Auth
{
    public static class JwtParser
    {
        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];

            var jsonBytes = ParseBase64WithoutPadding(payload);

            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            // Try to get roles from the standard claim first, then fall back to "role"
            if (!keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles))
            {
                keyValuePairs.TryGetValue("role", out roles);
            }

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                // Remove both possible role keys
                keyValuePairs.Remove(ClaimTypes.Role);
                keyValuePairs.Remove("role");
            }

            if (keyValuePairs.TryGetValue("name", out var name))
            {
                claims.Add(new Claim(ClaimTypes.Name, name.ToString()));
                keyValuePairs.Remove("name");
            }

            if (keyValuePairs.TryGetValue("email", out var email))
            {
                claims.Add(new Claim(ClaimTypes.Email, email.ToString()));
                keyValuePairs.Remove("email");
            }
            
            if (keyValuePairs.TryGetValue("picture", out var picture))
            {
                claims.Add(new Claim("picture", picture.ToString()));
                keyValuePairs.Remove("picture");
            }


            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
