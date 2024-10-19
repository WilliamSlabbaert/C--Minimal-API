using System;
using IntroMinimalApi.ConnectionUtils;
using Microsoft.AspNetCore.Mvc;

namespace IntroMinimalApi.Endpoints;

public static class NoteEndpoint
{
    public static void RegisterNotesEndpoint(this IEndpointRouteBuilder app)
    {
        var routes = BaseEndpoint.Register(app, EndpointNames.CALL_GENERIC_NOTES);

        routes.MapGet(string.Empty, () =>
        {
            return "OK This is your first call";
        });

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
