using VulkanNative.Examples.HelloTriangle;

var api = VulkanApi.Initialize();

Glfw.SetErrorCallback((errorCode, message) =>
{
    throw new Exception($"GLFW error {errorCode}: {message}");
});

Glfw.WindowHint(Hint.ClientApi, 0);
Glfw.WindowHint(Hint.Resizable, false);

var window = Glfw.CreateWindow(800, 600, "Hello Triangle");


// TODO: Validate
api.EnumerateInstanceExtensionProperties(null, out var extensionProperties).ThrowOnError();
api.EnumerateInstanceLayerProperties(out var layerProperties).ThrowOnError();

var glfwExtensions = Glfw.Vulkan.GetRequiredInstanceExtensions();

using UnmanagedUtf8StringArray enabledExtensionNames = new()
{
    "VK_EXT_debug_utils"
};

foreach(var extension in glfwExtensions)
{
    enabledExtensionNames.Add(extension);
}

using UnmanagedUtf8StringArray enabledLayerNames = new()
{
    "VK_LAYER_KHRONOS_validation"
};

using var instance = api.CreateVulkanInstance("MyApp", "MyEngine", enabledExtensionNames, enabledLayerNames);

var debugUtils = instance.LoadDebugUtils();

var messenger = debugUtils.CreateMessenger();

messenger.OnMessage += message =>
{
    Console.WriteLine(message);
};

using var physicalDevices = instance.GetPhysicalDevices();

var physicalDevice = physicalDevices[0];

//vkGetPhysicalDeviceFeatures
//vkGetPhysicalDeviceMemoryProperties

while (!Glfw.WindowShouldClose(window))
{
    Glfw.PollEvents();
}

messenger.Dispose();
instance.Dispose();

Glfw.DestroyWindow(window);

Glfw.Terminate();

