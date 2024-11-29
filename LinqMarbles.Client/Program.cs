using LinqMarbles.Client.Components;
using LinqMarbles.Client.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddMudServices();

builder.Services.AddCascadingValue(c => new GlobalObject());

await builder.Build().RunAsync();
