using System;

namespace IntroMinimalApi.Endpoints;

public static class BaseEndpoint
{
    public static IEndpointRouteBuilder Register(this IEndpointRouteBuilder app, string groupName) => app.MapGroup(groupName);
    public static TService GetMyService<TService>(this IServiceProvider provider) => provider.GetService<TService>();

}
