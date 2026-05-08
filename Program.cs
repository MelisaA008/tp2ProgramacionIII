using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using tp2ProgramacionIII;
using tp2ProgramacionIII.BL.Services;
using tp2ProgramacionIII.DAL.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Registro de servicios en DI
builder.Services.AddSingleton<AuthState>();
builder.Services.AddSingleton<PersonaRepository>();
builder.Services.AddTransient<PersonaService>();

await builder.Build().RunAsync();
