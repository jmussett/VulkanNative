using System;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class DebugMessenger : IDisposable
{
    private readonly VkInstance? _instanceHandle;
    private readonly VkExtDebugUtilsExtension? _extension;
    private readonly DebugMessengerDefinition _definition;

    private VkDebugUtilsMessengerEXT? _handle;

    public DebugMessenger(VkInstance instanceHandle, VkExtDebugUtilsExtension extension, DebugMessengerDefinition definition)
    {
        _instanceHandle = instanceHandle;
        _extension = extension;
        _definition = definition;

        VkDebugUtilsMessengerEXT messengerHandle;

        _extension.vkCreateDebugUtilsMessengerEXT(_instanceHandle.Value, (VkDebugUtilsMessengerCreateInfoEXT*) definition.ChainHandle, null, &messengerHandle).ThrowOnError();

        _handle = messengerHandle;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void Dispose(bool disposing)
    {
        if (_handle is not null)
        {
            _extension!.vkDestroyDebugUtilsMessengerEXT(_instanceHandle!.Value, _handle!.Value, null);
            _handle = nint.Zero;
        }

        if (disposing)
        {
            _definition.Dispose();
        }
    }

    ~DebugMessenger()
    {
        Dispose(false);
    }
}