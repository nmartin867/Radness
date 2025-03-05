namespace Radness.Api.Filters;

public static class ExceptionFilterExtensions
{
    private static readonly ProducesResponseTypeMetadata NotImplementedExceptionResponseMetadata = 
        new(500, typeof(NotImplementedException), ["application/problem+json"]);
}