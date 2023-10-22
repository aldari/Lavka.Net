namespace Lavka.Net.Models;

public class GetCouriersResponse
{
    public IEnumerable<CourierDto> Couriers { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
}