using System.Xml.Serialization;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.VulkanRegistry;

internal class VulkanApiRegistry
{
    private VkRegistry? _vkRegistry;

    public VkRegistry Root => _vkRegistry ?? throw new InvalidOperationException("Registry has not been loaded");

    public async Task FetchApiRegistry()
    {
        var registryUrl = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml";
        using var httpClient = new HttpClient();

        var registryXml = await httpClient.GetStringAsync(registryUrl);

        var serializer = new XmlSerializer(typeof(VkRegistry));

        using var reader = new StringReader(registryXml);

        _vkRegistry = (VkRegistry) serializer.Deserialize(reader)!;
    }
}
