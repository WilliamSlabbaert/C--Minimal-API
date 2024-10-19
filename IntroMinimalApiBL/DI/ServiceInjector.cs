using System;
using IntroMinimalApiBL.Interfaces;
using IntroMinimalApiBL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IntroMinimalApiBL.DI;

public static class ServiceInjector
{
    public static void InjectServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<INoteService, NoteService>();
    }
}
