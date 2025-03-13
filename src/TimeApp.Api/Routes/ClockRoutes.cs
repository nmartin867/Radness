using Microsoft.AspNetCore.Http.HttpResults;
using TimeApp.Api.Model;
using TimeApp.Api.Services;

namespace TimeApp.Api.Routes;

public static class ClockRoutes
{
    public static RouteGroupBuilder MapClockRoutes(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/angles");

        group.MapGet("/", () => TypedResults.Ok(TimeOnly.FromDateTime(DateTime.Now)));
        
        return group;
    }
    
    // private static Task<Results<Ok<HourMinutesAngle>, BadRequest>> HandleSystemTime(ITimeOnly systemTime)
    // {
    //     //var degrees = service.CalculateAngle(time);
    //     TypedResults.Ok(degrees);
    // }
    // //
    // private static Task<Results<Ok<double>> CalculateTimeAngle(TimeOnly time, IClockService service)
    // {
    //     var degrees = service.CalculateAngle(time);
    //     TypedResults.Ok(degrees);
    // }

    // private static Ok<ClockAngleResponse> CalculateClockAngle([AsParameters]ClockAngleRequest request)
    // {
    //     var currentTime = TimeOnly.FromDateTime(DateTime.UtcNow);
    //     return TypedResults.Ok(todos);
    // }
}