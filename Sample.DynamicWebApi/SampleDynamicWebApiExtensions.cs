using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Sample.DynamicWebApi;

public static class SampleDynamicWebApiExtensions
{
    public static IMvcBuilder AddDynamicWebApi(this IMvcBuilder builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.ConfigureApplicationPartManager(manager =>
        {
            manager.FeatureProviders.Add(new ApplicationServiceControllerFeatureProvider());
        });

        builder.Services.Configure<MvcOptions>(options =>
        {
            options.Conventions.Add(new ApplicationServiceConvention());
        });

        return builder;
    }

    public static IMvcCoreBuilder AddDynamicWebApi(this IMvcCoreBuilder builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.ConfigureApplicationPartManager(manager =>
        {
            manager.FeatureProviders.Add(new ApplicationServiceControllerFeatureProvider());
        });

        builder.Services.Configure<MvcOptions>(options =>
        {
            options.Conventions.Add(new ApplicationServiceConvention());
        });

        return builder;
    }
}