using Lavka.Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lavka.Net.Controllers;

[ApiController]
[Route("[controller]")]
public class CouriersController : ControllerBase
{
    [HttpGet]
    public GetCouriersResponse GetCouriers(int limit = 1, int offset = 0)
    {
        return new GetCouriersResponse
        {
            Couriers = new[]
            {
                new CourierDto
                {
                    CourierId = 1,
                    Regions = new[] { 1, 2, 3 },
                    CourierType = "FOOT",
                    WorkingHours = new[] { "10:00-11:00", "16:00-17:00" }
                }
            },
            Limit = limit,
            Offset = offset
        };
    }

    [HttpGet("{courierId}")]
    public CourierDto GetCourierById(long courierId)
    {
        return new CourierDto
        {
            CourierId = 1,
            Regions = new[] { 1, 2, 3 },
            CourierType = "FOOD",
            WorkingHours = new[] { "10:00-11:00", "16:00-17:00" }
        };
    }
}