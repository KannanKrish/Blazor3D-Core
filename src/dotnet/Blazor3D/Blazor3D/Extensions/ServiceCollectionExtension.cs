﻿namespace HomagGroup.Blazor3D.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddBlazor3DFileTypes(this IServiceCollection services)
    {
        var provider = new FileExtensionContentTypeProvider();

        provider.AddMapping(".fbx", "application/octet-stream");
        provider.AddMapping(".gltf", "model/gltf+json");
        provider.AddMapping(".glb", "model/gltf-binary");
        provider.AddMapping(".dae", "model/vnd.collada+xml");
        provider.AddMapping(".stl", "model/stl");

        services.Configure<StaticFileOptions>(s => s.ContentTypeProvider = provider);

        return services;
    }

    private static void AddMapping(this FileExtensionContentTypeProvider provider, string fileExtension, string mimeType)
    {
        if (!provider.Mappings.ContainsKey(fileExtension))
            provider.Mappings.Add(fileExtension, mimeType);
    }
}