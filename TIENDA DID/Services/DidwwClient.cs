using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

public class DidwwClient
{
    private readonly HttpClient _http;

    public DidwwClient(string apiKey)
    {
        // Requerido por DIDWW
        System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

        _http = new HttpClient();
        _http.BaseAddress = new Uri("https://api.didww.com/v3/");

        // Cabezera correcta para API JSON:API
        _http.DefaultRequestHeaders.Accept.Clear();
        _http.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.api+json")
        );

        // 🔥 AQUÍ EL CAMBIO IMPORTANTE 🔥  
        // DIDWW usa "api-key" (NO Bearer)
        _http.DefaultRequestHeaders.Add("api-key", apiKey);
    }

    public async Task<string> GetAsync(string endpoint)
    {
        var response = await _http.GetAsync(endpoint);

        if (!response.IsSuccessStatusCode)
        {
            string err = await response.Content.ReadAsStringAsync();
            throw new Exception($"ERROR {response.StatusCode} → {err}");
        }

        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> PostAsync(string endpoint, string jsonBody)
    {
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/vnd.api+json");
        var response = await _http.PostAsync(endpoint, content);

        if (!response.IsSuccessStatusCode)
        {
            string err = await response.Content.ReadAsStringAsync();
            throw new Exception($"ERROR {response.StatusCode} → {err}");
        }

        return await response.Content.ReadAsStringAsync();
    }
}
