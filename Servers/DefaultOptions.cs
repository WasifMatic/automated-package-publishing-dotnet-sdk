using ApiMaticPortalArtifactsApi.Core.Models;

namespace ApiMaticPortalArtifactsApi.Servers;

public class DefaultOptions
{
    public ProductionOptions Production { get; set; } = new();
    public TestingOptions Testing { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(
            () => new UrlTemplate(Production.BaseUrl, path, []),
            () => new UrlTemplate(Testing.BaseUrl, path, [TemplateParam.ForServer("customUrl", Testing.CustomUrl)]));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://api.apimatic.io";
    }

    public class TestingOptions
    {
        public string BaseUrl { get; set; } = "{customUrl}";
        public string CustomUrl { get; set; } = "https://localhost:44301/api";
    }
}
