using documentationApi.Dto;
using documentationApi.Interfaces;
using documentationApi.Services;

namespace documentationApi.Endpoints
{
    public static class DocumentationsEndpoints
    {
        public static void MapDocumentationsEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/documentations");

            group.MapGet("/", async (IDocumentationService service) => {
                var docs = await service.GetAllDocumentations();

                return Results.Ok(docs);
            });

            group.MapGet("/{id}", async (int id, IDocumentationService service) =>
            {
                var doc = await service.GetById(id);

                return doc is not null ? Results.Ok(doc) : Results.NotFound();
            });

            group.MapPost("/", async (DocumentationDto doc, IDocumentationService service) => {

                try
                {
                    var created = await service.Create(doc);

                    return Results.Ok(created);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }

            });

            group.MapDelete("/{id}", async (int id, IDocumentationRepository service) =>
            {
                var deleted = await service.Remove(id);

                if (!deleted)
                    return Results.BadRequest("Nenhum item deletado.");

               return Results.Ok("Deletado com sucesso.");
            });

            group.MapPut("/{id}", async (int id, DocumentationDto docDto, IDocumentationService service) =>
            {
                var isUpdated = await service.Update(id, docDto);
                return isUpdated ? Results.Ok("Documento atualizado com sucesso.") : Results.NotFound("Erro ao editar.");
            });
        }
    }
}
