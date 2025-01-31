using System.Text.Json.Serialization;

namespace Bellon.API.ConsumoInterno.Classes;

[Serializable]
public class LSCentralUnidadMedida
{
    [JsonPropertyName("@odata.context")]
    public Uri odataContext { get; set; }

    [JsonPropertyName("@odata.etag")]
    public string odataEtag { get; set; }

    [JsonPropertyName("id_unidad_medida")]
    public Guid IdUnidadMedida { get; set; }

    [JsonPropertyName("codigo")]
    public string Codigo { get; set; }

    [JsonPropertyName("descripcion")]
    public string Descripcion { get; set; }
}
