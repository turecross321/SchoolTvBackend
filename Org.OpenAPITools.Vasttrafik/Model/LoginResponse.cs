using Newtonsoft.Json;

namespace Org.OpenAPITools.Model;

public record LoginResponse
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }
    
    [JsonProperty("scope")]
    public string Scope { get; set; }
    
    [JsonProperty("token_type")]
    public string TokenType { get; set; }
    
    [JsonProperty("expires_in")]
    public long ExpiresIn { get; set; }
}