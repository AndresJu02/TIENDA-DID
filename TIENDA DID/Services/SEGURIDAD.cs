using System;
using System.Net.Http;
using System.Threading.Tasks;

public class RemoteControl
{
    private const string statusUrl =
        "https://raw.githubusercontent.com/AndresJu02/TIENDA-DID/refs/heads/master/TIENDA%20DID/main/status.txt";

    private static readonly HttpClient http = new HttpClient();

    public static async Task<bool> IsEnabledAsync()
    {
        try
        {
            // Forzar a GitHub a NO USAR caché
            string urlNoCache = statusUrl + "?t=" + DateTime.Now.Ticks;

            http.DefaultRequestHeaders.CacheControl =
                new System.Net.Http.Headers.CacheControlHeaderValue
                {
                    NoCache = true,
                    NoStore = true,
                };

            string content = await http.GetStringAsync(urlNoCache);

            // Limpieza del contenido
            content = content.Trim().ToLower();

            // Aceptar "enabled=1" o solo "1"
            if (content.Contains("enabled=1") || content == "1")
            {
                return true;
            }

            return false; // Está desactivada
        }
        catch
        {
            // Si no hay internet o GitHub falla puedes elegir:
            return true;   // Permitir acceso si falla
            // return false; // O bloquear si falla
        }
    }
}
