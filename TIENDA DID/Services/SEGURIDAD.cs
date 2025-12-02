using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

public class RemoteControl
{
    private const string statusUrl = "https://raw.githubusercontent.com/AndresJu02/TIENDA-DID/main/status.txt";

    public static async Task<bool> IsEnabledAsync()
    {
        try
        {
            using (var client = new HttpClient())
            {
                string content = await client.GetStringAsync(statusUrl);
                return content.Contains("enabled=1");
            }
        }
        catch
        {
            // Si falla la conexión puedes elegir:
            return true;  // permitir
            // return false; // o bloquear
        }
    }
}
