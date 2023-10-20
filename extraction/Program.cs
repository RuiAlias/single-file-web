var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    ContentRootPath = AppContext.BaseDirectory
});
var app = builder.Build();

app.UseFileServer();

app.Run();
