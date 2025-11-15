using documentationApi.Interfaces;

namespace documentationApi.Endpoints
{
    public static class DocumentationsEndpoints
    {
        public static void MapDocumentationsEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/documentations");

            group.MapGet("/", async (IDocumentationService service) =>
            {

                var result = await service.GetAllDocumentations();

                return Results.Ok(result);
            });

            group.MapPost("/", () => {
                return Results.Ok("Documentation post");
            });
        }
    }
}
