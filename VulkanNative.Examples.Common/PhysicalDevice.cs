using System.Runtime.InteropServices;
using System;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public unsafe class PhysicalDevice
{
    private readonly VkPhysicalDevice _handle;
    private readonly VulkanLoader _loader;
    private readonly VkInstanceCommands _commands;

    public nint Handle => _handle;

    public PhysicalDevice(VkPhysicalDevice handle, VulkanLoader loader, VkInstanceCommands instanceCommands)
    {
        _handle = handle;
        _loader = loader;
        _commands = instanceCommands;
    }

    public VkPhysicalDeviceProperties GetProperties()
    {
        VkPhysicalDeviceProperties properties;
        _commands.VkGetPhysicalDeviceProperties(_handle, &properties);

        return properties;
    }

    public VkPhysicalDeviceFeatures GetFeatures()
    {
        VkPhysicalDeviceFeatures features;
        _commands.VkGetPhysicalDeviceFeatures(_handle, &features);

        return features;
    }

    public VkQueueFamilyProperties[] GetQueueFamilies()
    {
        uint count;
        _commands.VkGetPhysicalDeviceQueueFamilyProperties(_handle, &count, null);

        var queueFamiliesPtr = stackalloc VkQueueFamilyProperties[(int) count];

        _commands.VkGetPhysicalDeviceQueueFamilyProperties(_handle, &count, queueFamiliesPtr);

        var queueFamilies = new VkQueueFamilyProperties[(int)count];

        for(var i = 0; i < count; i++)
        {
            queueFamilies[i] = queueFamiliesPtr[i];
        }

        return queueFamilies;
    }

    public unsafe ExtensionProperties[] GetExtensions()
    {
        uint count = 0;

        _commands.VkEnumerateDeviceExtensionProperties(_handle, (byte*)null, &count, null).ThrowOnError();

        var extensionPropertiesPtr = stackalloc VkExtensionProperties[(int)count];

        _commands.VkEnumerateDeviceExtensionProperties(_handle, (byte*)null, &count, extensionPropertiesPtr).ThrowOnError();

        ExtensionProperties[] extensionProperties = new ExtensionProperties[(int)count];

        for (var i = 0; i < count; i++)
        {
            extensionProperties[i] = new()
            {
                ExtensionName = Marshal.PtrToStringAnsi((nint)extensionPropertiesPtr[i].ExtensionName) ?? string.Empty,
                SpecVersion = extensionPropertiesPtr[i].SpecVersion
            };
        }

        return extensionProperties;
    }

    public unsafe LayerProperties[] GetLayers()
    {
        uint layerCount = 0;

        _commands.VkEnumerateDeviceLayerProperties(_handle, &layerCount, null).ThrowOnError();

        var availableVkLayers = stackalloc VkLayerProperties[(int)layerCount];

        _commands.VkEnumerateDeviceLayerProperties(_handle, &layerCount, availableVkLayers).ThrowOnError();

        var availableLayers = new LayerProperties[(int)layerCount];

        for (var i = 0; i < layerCount; i++)
        {
            availableLayers[i] = new()
            {
                LayerName = Marshal.PtrToStringAnsi((nint)availableVkLayers[i].LayerName) ?? string.Empty,
                Description = Marshal.PtrToStringAnsi((nint)availableVkLayers[i].Description) ?? string.Empty,
                SpecVersion = availableVkLayers[i].SpecVersion,
                ImplementationVersion = availableVkLayers[i].ImplementationVersion
            };
        }

        return availableLayers;
    }

    public VulkanDevice CreateLogicalDevice(UnmanagedUtf8StringArray extensions, DeviceQueue[] queues)
    {
        VkDevice device;

        VkDeviceQueueCreateInfo* queueCreateInfos = stackalloc VkDeviceQueueCreateInfo[queues.Length];

        for (var i = 0; i < queues.Length; i++)
        {
            fixed (float* queuePriorityPtr = &queues[i].QueuePriorites[0])
            {
                queueCreateInfos[i] = new VkDeviceQueueCreateInfo
                {
                    SType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO,
                    QueueFamilyIndex = queues[i].QueueFamilyIndex,
                    QueueCount = (uint)queues[i].QueuePriorites.Length,
                    PQueuePriorities = queuePriorityPtr
                };
            }
        }

        VkDeviceCreateInfo deviceCreateInfo = new()
        {
            SType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO,
            QueueCreateInfoCount = (uint)queues.Length,
            PQueueCreateInfos = queueCreateInfos,
            EnabledExtensionCount = (uint)extensions.Length,
            PpEnabledExtensionNames = extensions.AsPointer()
        };

        _commands.VkCreateDevice(_handle, &deviceCreateInfo, null, &device).ThrowOnError();

        return new VulkanDevice(device, _loader);
    }
}

public struct DeviceQueue
{
    public uint QueueFamilyIndex;

    public float[] QueuePriorites;
}
