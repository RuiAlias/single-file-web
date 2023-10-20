The simplest way I could find to publish a ASP.NET Core application to a single file, including its "wwwroot" files.

Invoke `dotnet publish` on this directory and it should generate an executable on `.\bin\Release\net8.0\win-x64\publish\`. You can move that executable to any other directory and run it, and the web application will work including the serving of static files.

# Sources

- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/file-providers?view=aspnetcore-8.0
