﻿using System.Runtime.InteropServices;
using System.Text;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public unsafe class VulkanApi
{
    private readonly VulkanLoader _vulkanLoader;
    private readonly VkGlobalCommands _globalCommands;

    public VulkanApi(VulkanLoader vulkanLoader)
    {
        _vulkanLoader = vulkanLoader;

        _globalCommands = _vulkanLoader.LoadGlobalCommands();
    }

    public static VulkanApi Initialize()
    {
        var vulkanLoader = VulkanLoader.Initialize();

        return new VulkanApi(vulkanLoader);
    }

    public VulkanInstance CreateVulkanInstance(string appName, string engineName, UnmanagedUtf8StringArray enabledExtensionNames, UnmanagedUtf8StringArray enabledLayerNames)
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

        _globalCommands.VkCreateInstance(&vkInstanceCreateInfo, null, &instance).ThrowOnError();

        //VK_ERROR_INCOMPATIBLE_DRIVER https://vulkan-tutorial.com/Drawing_a_triangle/Setup/Instance

        return new VulkanInstance(instance, _vulkanLoader);
    }

    public void EnumerateInstanceExtensionProperties(string? layerName, out ExtensionProperties[] properties)
    {
        // Define the state you wish to pass to the callback
        // This can be extended to include other required data, too
        var state = new ExtensionPropertiesState
        {
            Commands = _globalCommands,
            Properties = Array.Empty<ExtensionProperties>()
        };

        if (layerName != null)
        {
            // Use the GetBytes method to stack-allocate the UTF-8 bytes for the layer name
            Encoding.UTF8.GetBytes(layerName, 512, ref state, EnumerateInstanceExtensionProperties);
        }
        else
        {
            // If layerName is null, directly call the processing function with a default span
            EnumerateInstanceExtensionProperties(null, ref state);
        }

        properties = state.Properties;
    }

    private static void EnumerateInstanceExtensionProperties(Span<byte> layerName, ref ExtensionPropertiesState state)
    {
        uint propertyCount = 0;

        fixed (byte* layerNamePtr = layerName)
        {
            state.Commands.VkEnumerateInstanceExtensionProperties(layerNamePtr, &propertyCount, null).ThrowOnError();

            var propertiesArray = stackalloc VkExtensionProperties[(int)propertyCount];

            state.Commands.VkEnumerateInstanceExtensionProperties(layerNamePtr, &propertyCount, propertiesArray).ThrowOnError();

            state.Properties = new ExtensionProperties[propertyCount];

            // Convert the VkExtensionProperties* to a managed List
            for (int i = 0; i < propertyCount; i++)
            {
                state.Properties[i] = new ExtensionProperties
                {
                    ExtensionName = Marshal.PtrToStringUTF8((nint)propertiesArray[i].ExtensionName)!,
                    SpecVersion = propertiesArray[i].SpecVersion
                };
            }
        }
    }

    public void EnumerateInstanceLayerProperties(out LayerProperties[] layerProperties)
    {
        layerProperties = Array.Empty<LayerProperties>();

        uint propertyCount;
        _globalCommands.VkEnumerateInstanceLayerProperties(&propertyCount, null).ThrowOnError();

        var propertiesPtr = stackalloc VkLayerProperties[(int)propertyCount];

        layerProperties = new LayerProperties[propertyCount];

        for (int i = 0; i < propertyCount; i++)
        {
            layerProperties[i] = new LayerProperties
            {
                LayerName = Marshal.PtrToStringUTF8((nint)propertiesPtr[i].LayerName)!,
                Description = Marshal.PtrToStringUTF8((nint)propertiesPtr[i].Description)!,
                SpecVersion = propertiesPtr[i].SpecVersion,
                ImplementationVersion = propertiesPtr[i].ImplementationVersion
            };
        }
    }

    private struct ExtensionPropertiesState
    {
        public VkGlobalCommands Commands { get; set; }
        public ExtensionProperties[] Properties { get; set; }
    }
}