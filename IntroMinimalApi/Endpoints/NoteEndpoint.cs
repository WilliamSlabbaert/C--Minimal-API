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

        routes.MapGet(string.Empty, service.GetNotes);

        routes.MapGet("{id}", (int id) =>
        {
            return "Note with ID :" + id;
        });

        routes.MapPost(string.Empty, ([FromBody] string note) =>
        {
            return note;
        });
    }
}
