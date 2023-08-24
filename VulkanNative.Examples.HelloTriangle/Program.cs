using VulkanNative;
using VulkanNative.Examples.HelloTriangle;

var vulkanLoader = VulkanLoader.Initialize();

var globalCommands = vulkanLoader.LoadGlobalCommands();

var instanceExtensions = EnumerateInstanceExtensions(globalCommands);

using UnmanagedUtf8StringArray enabledExtensionNames = new(3)
{
    "VK_KHR_surface",
    "VK_KHR_win32_surface",
    "VK_EXT_debug_report"
};

using UnmanagedUtf8StringArray enabledLayerNames = new(3)
{
    // TODO
};

var vkInstance = CreateVulkanInstance(globalCommands, "MyApp", "MyEngine", enabledExtensionNames, enabledLayerNames);

static unsafe UnmanagedUtf8StringArray EnumerateInstanceExtensions(VkGlobalCommands globalCommands)
{
    uint count;
    globalCommands.VkEnumerateInstanceExtensionProperties((byte*)null, &count, null).ThrowOnError();

    VkExtensionProperties* instanceExtensionsPtr = stackalloc VkExtensionProperties[(int)count];

    globalCommands.VkEnumerateInstanceExtensionProperties((byte*)null, &count, instanceExtensionsPtr).ThrowOnError();

    var instanceExtensions = new UnmanagedUtf8StringArray((int)count);

    for (var i = 0; i < count; i++)
    {
        instanceExtensions.Add(instanceExtensionsPtr[i].ExtensionName, (int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE);
    }

    return instanceExtensions;
}

static unsafe VkInstance CreateVulkanInstance(VkGlobalCommands globalCommands, string appName, string engineName, UnmanagedUtf8StringArray enabledExtensionNames, UnmanagedUtf8StringArray enabledLayerNames)
{
    using UnmanagedEncodedString appNameEncoded = appName;
    using UnmanagedEncodedString engineNameEncoded = engineName;

    VkInstance instance;

    var pApplicationInfo = new VkApplicationInfo
    {
        SType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO,
        PApplicationName = appNameEncoded.AsPointer(),
        PEngineName = engineNameEncoded.AsPointer(),
        ApplicationVersion = new VkVersion(1, 0, 0),
        EngineVersion = new VkVersion(1, 0, 0),
        ApiVersion = new VkVersion(1, 0, 0),
    };

    var vkInstanceCreateInfo = new VkInstanceCreateInfo
    {
        SType = VkStructureType.VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO,
        PApplicationInfo = &pApplicationInfo,
        EnabledLayerCount = (uint)enabledLayerNames.Length,
        PpEnabledLayerNames = enabledLayerNames.AsPointer(),
        EnabledExtensionCount = (uint)enabledExtensionNames.Length,
        PpEnabledExtensionNames = enabledExtensionNames.AsPointer(),
    };

    globalCommands.VkCreateInstance(&vkInstanceCreateInfo, null, &instance).ThrowOnError();

    return instance;
}