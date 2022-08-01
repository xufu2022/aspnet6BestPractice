# aspnet6BestPractice

dotnet new sln --name ApiProjectTemplates
dotnet new webapi -o 'API Projects\ApiBestPractices.Endpoints'
dotnet new webapi -o 'API Projects\controllers'
dotnet new webapi -o 'API Projects\FastEndpointsAPI'
dotnet new webapi -o 'API Projects\minimal'

dotnet new classlib -o Data\BackendData
dotnet new xunit -o Tests\APIProjectTests

dotnet sln add 'API Projects\ApiBestPractices.Endpoints'
dotnet sln add 'API Projects\controllers'
dotnet sln add 'API Projects\FastEndpointsAPI'
dotnet sln add 'API Projects\minimal'
dotnet sln add 'Data\BackendData'
dotnet sln add 'Tests\APIProjectTests'

dotnet add 'API Projects\controllers\controllers.csproj' reference Data\BackendData\BackendData.csproj
dotnet add 'API Projects\FastEndpointsAPI\FastEndpointsAPI.csproj' reference Data\BackendData\BackendData.csproj
dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' reference Data\BackendData\BackendData.csproj
dotnet add 'API Projects\minimal\minimal.csproj' reference Data\BackendData\BackendData.csproj

dotnet add 'Tests\APIProjectTests\APIProjectTests.csproj' reference  'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' 'Data\BackendData\BackendData.csproj'

dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' package Ardalis.ApiEndpoints 
dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' package Ardalis.ApiEndpoints.Swashbuckle
dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' package Ardalis.RouteAndBodyModelBinding
dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' package Microsoft.AspNetCore.JsonPatch
dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' package Microsoft.EntityFrameworkCore.Design
dotnet add 'API Projects\ApiBestPractices.Endpoints\ApiBestPractices.Endpoints.csproj' package AutoMapper.Extensions.Microsoft.DependencyInjection

dotnet add 'API Projects\controllers\controllers.csproj' package Autofac 
dotnet add 'API Projects\controllers\controllers.csproj' package Autofac.Extensions.DependencyInjection
dotnet add 'API Projects\controllers\controllers.csproj' package MediatR.Extensions.Microsoft.DependencyInjection

dotnet add 'API Projects\FastEndpointsAPI\FastEndpointsAPI.csproj' package FastEndpoints

dotnet add 'API Projects\minimal\minimal.csproj' package Microsoft.Data.Sqlite.Core
dotnet add 'API Projects\minimal\minimal.csproj' package MinimalApi.Endpoint
dotnet add 'API Projects\minimal\minimal.csproj' package MinimalApis.Extensions
dotnet add 'API Projects\minimal\minimal.csproj' package Swashbuckle.AspNetCore.Annotations

dotnet add 'Data\BackendData\BackendData.csproj' package Ardalis.Result
dotnet add 'Data\BackendData\BackendData.csproj' package Microsoft.EntityFrameworkCore.Tools
dotnet add 'Data\BackendData\BackendData.csproj' package Microsoft.EntityFrameworkCore.SqlServer
dotnet add 'Data\BackendData\BackendData.csproj' package Microsoft.EntityFrameworkCore.Sqlite
dotnet add 'Data\BackendData\BackendData.csproj' package SQLite

dotnet add 'Tests\APIProjectTests\APIProjectTests.csproj' package Ardalis.HttpClientTestExtensions
dotnet add 'Tests\APIProjectTests\APIProjectTests.csproj' package Microsoft.AspNetCore.Mvc.Test
dotnet add 'Tests\APIProjectTests\APIProjectTests.csproj' package Microsoft.EntityFrameworkCore.InMemory
dotnet add 'Tests\APIProjectTests\APIProjectTests.csproj' package Microsoft.EntityFrameworkCore.Sqlite
dotnet add 'Tests\APIProjectTests\APIProjectTests.csproj' package SQLite

    builder.Services.AddControllers(options =>
        {
            options.UseNamespaceRouteToken();
            options.ModelBinderProviders.InsertRouteAndBodyBinding();
        })
        .AddNewtonsoftJson(); // needed for JsonPatch support

    builder.Services.AddControllers(options =>
    {
        options.RespectBrowserAcceptHeader = true;
    }).AddXmlSerializerFormatters()
    .AddControllersAsServices();