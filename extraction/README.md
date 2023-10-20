The simplest way I could find to publish a ASP.NET Core application to a single file, including its "wwwroot" files and without embeding those files in the assembly as resources.

Invoke `dotnet publish` on this directory and it should generate an executable on `.\bin\Release\net8.0\win-x64\publish\`. You can move that executable to any other directory and run it, and the web application will work including the serving of static files.

# Sources

- https://learn.microsoft.com/en-us/dotnet/core/deploying/single-file/overview?tabs=cli
- https://github.com/dotnet/designs/blob/main/accepted/2020/single-file/design.md
- https://github.com/dotnet/sdk/blob/d84e2440836b5767c8b1bc9531e6dde26f18fd6a/src/Tasks/Microsoft.NET.Build.Tasks/targets/Microsoft.NET.Publish.targets#L973-L974
- https://github.com/dotnet/sdk/blob/2fdc148c280b63f6d4d4e529d2f82e6eb364f64c/src/StaticWebAssetsSdk/Targets/Microsoft.NET.Sdk.StaticWebAssets.References.targets#L25
