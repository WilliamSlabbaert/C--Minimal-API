using IntroMinimalApi.ConnectionUtils;
using IntroMinimalApiBL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntroMinimalApi.Endpoints;

public static class NoteEndpoint
{
    public static void RegisterNotesEndpoint(this IEndpointRouteBuilder app, IServiceProvider serviceProvider)
    {
        var service = serviceProvider.GetMyService<INoteService>();
        var routes = BaseEndpoint.Register(app, EndpointNames.CALL_GENERIC_NOTES);

        routes.MapGet(string.Empty, service.GetNotes)
        .WithTags(EndpointNames.GENERIC_NOTES);

        routes.MapGet(EndpointNames.CALL_ID, service.GetNote)
        .WithTags(EndpointNames.GENERIC_NOTES);

        routes.MapPost(string.Empty, ([FromBody] string note) => service.AddNote(note))
        .WithTags(EndpointNames.GENERIC_NOTES);
    }
}
