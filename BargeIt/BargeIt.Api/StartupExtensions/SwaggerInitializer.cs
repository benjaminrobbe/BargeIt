// using BargeIt.Config;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Reflection;

namespace BargeIt.Api.StartUpExtensions
{
    public static class SwaggerInitializer
    {
        //public static IServiceCollection AddCustomSwagger(this IServiceCollection services, IConfiguration configuration)
        //{
        //    var apiInfoConfig = configuration.GetSection("ApiInfo").Get<ApiInfoConfig>();
        //    services.AddSwaggerGen(options =>
        //    {
        //        var provider = services.BuildServiceProvider()
        //                       .GetRequiredService<IApiVersionDescriptionProvider>();

        //        foreach (var description in provider.ApiVersionDescriptions)
        //        {
        //            options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description, apiInfoConfig));
        //        }

        //        var securitySchema = new OpenApiSecurityScheme
        //        {
        //            Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        //            Name = "Authorization",
        //            In = ParameterLocation.Header,
        //            Type = SecuritySchemeType.Http,
        //            Scheme = "bearer",
        //            Reference = new OpenApiReference
        //            {
        //                Type = ReferenceType.SecurityScheme,
        //                Id = "Bearer"
        //            }
        //        };
        //        options.AddSecurityDefinition("Bearer", securitySchema);

        //    });
        //    // services.AddSwaggerGenNewtonsoftSupport();
        //    return services;
        //}

        //private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description, ApiInfoConfig apiInfoConfig)
        //{
        //    var info = new OpenApiInfo()
        //    {
        //        Title = apiInfoConfig.Title,
        //        Version = description.ApiVersion.ToString(),
        //        Description = apiInfoConfig.Description,
        //        Contact = new OpenApiContact() { Name = apiInfoConfig.ContactName, Email = apiInfoConfig.ContactEmail },
        //    };

        //    if (description.IsDeprecated)
        //    {
        //        info.Description += " This API version has been deprecated.";
        //    }

        //    return info;
        //}
    }
}

