namespace Radness.Api.Filters;

public static class ValidationFiltersExtensions 
{
    private static readonly ProducesResponseTypeMetadata ValidationErrorResponseMetadata = 
        new(400, typeof(HttpValidationProblemDetails), ["application/problem+json"]);
}