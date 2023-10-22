using System.Text.Json.Serialization;

namespace Lavka.Net.Models;

public class CourierDto
{
    [JsonPropertyName("courier_id")]
    public long CourierId { get; set; }

    [JsonPropertyName("courier_type")]
    public string CourierType { get; set; }
    
    public IEnumerable<int> Regions { get; set; }

    [JsonPropertyName("working_hours")]
    public IEnumerable<string> WorkingHours { get; set; }
}