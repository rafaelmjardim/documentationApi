using documentationApi.Dto;
using documentationApi.Interfaces;

namespace documentationApi.Endpoints
{
    public static class DocumentationsEndpoints
    {
        public static void MapDocumentationsEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/documentations");

            group.MapPost("/", async (DocumentationDto doc, IDocumentationService service) => {

                return await service.Create(doc);
            });
        }
    }
}
