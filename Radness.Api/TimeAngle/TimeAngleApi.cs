namespace Radness.Api.Endpoints;

internal static class TimeAngleApi
{
   public static RouteGroupBuilder MapTimeAngles(this IEndpointRouteBuilder routes)
   {
      var group = routes.MapGroup("/timeangles");

      group.MapGet("/",  context =>
      {
         
      });
   }
}