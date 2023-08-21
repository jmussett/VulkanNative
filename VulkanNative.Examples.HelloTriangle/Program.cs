using System;
using System.Runtime.InteropServices;
using System.Text;
using VulkanNative;
using VulkanNative.Examples.HelloTriangle;

var vulkanLoader = VulkanLoader.Initialize();

var globalCommands = vulkanLoader.LoadGlobalCommands();

unsafe
{
    uint count;
    globalCommands.VkEnumerateInstanceExtensionProperties((byte*) null, &count, null).ThrowOnError();

    VkExtensionProperties* instanceExtensionsPtr = stackalloc VkExtensionProperties[(int)count];

    globalCommands.VkEnumerateInstanceExtensionProperties((byte*) null, &count, instanceExtensionsPtr).ThrowOnError();

    var instanceExtensions = new UnmanagedJaggedArray<char>((int)count);

    for (var i = 0; i < count; i++)
    {
        var extensionName = new UnmanagedString(instanceExtensionsPtr[i].ExtensionName, (int) VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE);

        instanceExtensions.Add(in extensionName);
    }

    using UnmanagedEncodedString appName = "MyApp";
    using UnmanagedEncodedString engineName = "MyEngine";

    using UnmanagedJaggedArray<byte> enabledExtensionNames = new(3)
    {
        new UnmanagedEncodedString("VK_KHR_surface"),
        new UnmanagedEncodedString("VK_KHR_win32_surface"),
        new UnmanagedEncodedString("VK_EXT_debug_report")
    };

    using UnmanagedJaggedArray<byte> enabledLayerNames = new(3)
    {
        // TODO
    };

    VkInstance instance;

    var pApplicationInfo = new VkApplicationInfo
    {
        SType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO,
        PApplicationName = appName.AsPointer(),
        PEngineName = engineName.AsPointer(),
        ApplicationVersion = new VkVersion(1, 0, 0),
        EngineVersion = new VkVersion(1, 0, 0),
        ApiVersion = new VkVersion(1, 0, 0),
    };

    var vkInstanceCreateInfo = new VkInstanceCreateInfo
    {
        SType = VkStructureType.VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO,
        PApplicationInfo = &pApplicationInfo,
        EnabledLayerCount = (uint) enabledLayerNames.Length,
        PpEnabledLayerNames = enabledLayerNames.AsPointer(),
        EnabledExtensionCount = (uint) enabledExtensionNames.Length,
        PpEnabledExtensionNames = enabledExtensionNames.AsPointer(),
    };

    globalCommands.VkCreateInstance(&vkInstanceCreateInfo, null, &instance).ThrowOnError();
}
