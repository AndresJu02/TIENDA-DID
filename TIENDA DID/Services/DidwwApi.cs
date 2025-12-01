using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

public class DidwwApi
{
    private readonly DidwwClient _client;

    public DidwwApi(string apiKey)
    {
        _client = new DidwwClient(apiKey);
    }

    // ✅ ÚNICO método válido para consultar available_dids por grupo DID
    public async Task<JArray> GetAvailableDids(string didGroupId)
    {
        string endpoint = $"available_dids?filter[did_group.id]={didGroupId}&include=did_group";
        string json = await _client.GetAsync(endpoint);
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    // 🔥 Nuevo: obtener grupos DID por país + ciudad o país + región
    public async Task<JArray> GetDidGroupsPrefijos(string countryId, string cityId = null, string regionId = null, string typeId = null)
    {
        string endpoint = "did_groups?include=stock_keeping_units&filter[is_available]=true&filter[country.id]=" + countryId;

        if (!string.IsNullOrEmpty(cityId))
            endpoint += "&filter[city.id]=" + cityId;

        if (!string.IsNullOrEmpty(regionId))
            endpoint += "&filter[region.id]=" + regionId;

        if (!string.IsNullOrEmpty(typeId))
            endpoint += "&filter[did_group_type.id]=" + typeId;

        string json = await _client.GetAsync(endpoint);
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }



    // 🌍 Obtener regiones por país
    public async Task<JArray> GetRegions(string countryId)
    {
        string endpoint = $"regions?filter[country.id]={countryId}";
        string json = await _client.GetAsync(endpoint);
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetDidGroups_ByRegion(string countryId, string typeId, string regionId)
    {
        string endpoint = $"did_groups?filter[is_available]=true" +
                          $"&filter[country.id]={countryId}" +
                          $"&filter[region.id]={regionId}" +
                          $"&filter[did_group_type.id]={typeId}" +
                          $"&include=stock_keeping_units";

        string json = await _client.GetAsync(endpoint);
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }


    public async Task<JArray> GetCountries()
    {
        string json = await _client.GetAsync("countries");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetCities(string countryId)
    {
        string json = await _client.GetAsync($"cities?filter[country.id]={countryId}");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetDidGroupTypes()
    {
        string json = await _client.GetAsync("did_group_types");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    // ✅ Método para consultar grupos DID (fijas y otros tipos)
    public async Task<JObject> GetDidGroups(string countryId, string cityId, string typeId)
    {
        string endpoint = $"did_groups?include=stock_keeping_units" +
                          $"&filter[is_available]=true" +
                          $"&filter[country.id]={countryId}" +
                          (cityId != null ? $"&filter[city.id]={cityId}" : "") +
                          $"&filter[did_group_type.id]={typeId}";

        string json = await _client.GetAsync(endpoint);
        return JObject.Parse(json);
    }

    // ✅ Método especial para Colombia Mobile sin city
    public async Task<JArray> GetAvailableDids_Mobile(string countryId, string typeId)
    {
        string endpoint = $"available_dids?filter[country.id]={countryId}" +
                          $"&filter[did_group_type.id]={typeId}&include=did_group";

        string json = await _client.GetAsync(endpoint);
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    // ✅ Crear orden por available_did
    public async Task<JObject> CreateOrder(string availableDidId, string skuId)
    {
        var body = $@"
{{
  ""data"": {{
    ""type"": ""orders"",
    ""attributes"": {{
      ""items"": [
        {{
          ""type"": ""did_order_items"",
          ""attributes"": {{
            ""available_did_id"": ""{availableDidId}"",
            ""sku_id"": ""{skuId}""
          }}
        }}
      ]
    }}
  }}
}}";

        string result = await _client.PostAsync("orders", body);
        return JObject.Parse(result);
    }


    public async Task<string> GetValidSkuId(string didGroupId)
    {
        string endpoint = $"did_groups/{didGroupId}/stock_keeping_units";
        string json = await _client.GetAsync(endpoint);
        var obj = JObject.Parse(json);
        var skus = (JArray)obj["data"];

        foreach (var sku in skus)
        {
            if (sku["attributes"]?["channels_included_count"]?.ToString() == "2")
            {
                return sku["id"].ToString(); // ✅ devolver el SKU que tiene 2 canales
            }
        }

        return null; // si no encuentra ninguno válido
    }


    //--------------------------------------------------------------------

    public async Task<JArray> GetDidGroupTypesRamdom()
    {
        string json = await _client.GetAsync("did_group_types");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetCountriesRamdom()
    {
        string json = await _client.GetAsync("countries");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetCitiesRamdom(string countryId)
    {
        string json = await _client.GetAsync($"cities?filter[country.id]={countryId}");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetRegionsRamdom(string countryId)
    {
        string json = await _client.GetAsync($"regions?filter[country.id]={countryId}");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetDidGroups_ByCityRamdom(string countryId, string typeId, string cityId)
    {
        string json = await _client.GetAsync($"did_groups?include=stock_keeping_units&filter[is_available]=true&filter[country.id]={countryId}&filter[city.id]={cityId}&filter[did_group_type.id]={typeId}");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JArray> GetDidGroups_ByRegionRamdom(string countryId, string typeId, string regionId)
    {
        string json = await _client.GetAsync($"did_groups?include=stock_keeping_units&filter[is_available]=true&filter[country.id]={countryId}&filter[region.id]={regionId}&filter[did_group_type.id]={typeId}");
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }


    public async Task<JArray> GetDidGroups_MobileRamdom(string countryId, string typeId)
    {
        string endpoint = $"did_groups?include=stock_keeping_units" +
                          $"&filter[is_available]=true" +
                          $"&filter[country.id]={countryId}" +
                          $"&filter[did_group_type.id]={typeId}";

        string json = await _client.GetAsync(endpoint);
        var obj = JObject.Parse(json);
        return (JArray)obj["data"];
    }

    public async Task<JObject> CreateOrderRamdom(string skuId, int qty)
    {
        var body = $@"
{{
    ""data"": {{
        ""type"": ""orders"",
        ""attributes"": {{
            ""allow_back_ordering"": true,
            ""items"": [
                {{
                    ""type"": ""did_order_items"",
                    ""attributes"": {{
                        ""qty"": {qty},
                        ""sku_id"": ""{skuId}""
                    }}
                }}
            ]
        }}
    }}
}}";

        string result = await _client.PostAsync("orders", body);
        return JObject.Parse(result);
    }



}
