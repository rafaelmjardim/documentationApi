namespace documentationApi.Endpoints
{
    public static class EndpointExtensions
    {
        public static void MapAppEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapDocumentationsEndpoints();
        }
    }
}
