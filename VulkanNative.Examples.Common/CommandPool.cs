using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public unsafe sealed class CommandPool : IDisposable
{
    private VkCommandPool _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;

    public nint Handle => _handle;

    public CommandPool(VkCommandPool handle, VkDevice deviceHandle, VkDeviceCommands commands)
    {
        _handle = handle;
        _deviceHandle = deviceHandle;
        _commands = commands;
    }

    public CommandBuffer AllocateCommandBuffer(VkCommandBufferLevel level)
    {
        return AllocateCommandBuffers(1, level)[0];
    }

    public CommandBuffer[] AllocateCommandBuffers(uint commandBufferCount, VkCommandBufferLevel level)
    {
        if (commandBufferCount == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(commandBufferCount), "commandBufferCount must be greater then 0.");
        }

        VkCommandBufferAllocateInfo commandBufferAllocateInfo = new()
        {
            commandPool = _handle,
            commandBufferCount = commandBufferCount,
            level = level
        };

        VkCommandBuffer* commandBufferPtr = stackalloc VkCommandBuffer[(int) commandBufferCount];

        _commands.vkAllocateCommandBuffers(_deviceHandle, &commandBufferAllocateInfo, commandBufferPtr).ThrowOnError();

        var commandBuffers = new CommandBuffer[commandBufferCount];

        for (var i = 0; i < commandBufferCount; i++)
        {
            commandBuffers[i] = new(commandBufferPtr[i], _commands);
        }

        return commandBuffers;
    }

    public void FreeCommandBuffer(CommandBuffer commandBuffer)
    {
        VkCommandBuffer* commandBufferPtr = stackalloc VkCommandBuffer[1];

        commandBufferPtr[0] = commandBuffer.Handle;

        _commands.vkFreeCommandBuffers(_deviceHandle, _handle, 1, commandBufferPtr);
    }

    public void FreeCommandBuffers(Span<CommandBuffer> commandBuffers)
    {
        VkCommandBuffer* commandBufferPtr = stackalloc VkCommandBuffer[commandBuffers.Length];

        for(var i = 0; i < commandBuffers.Length; i++)
        {
            commandBufferPtr[i] = commandBuffers[i].Handle;
        }

        _commands.vkFreeCommandBuffers(_deviceHandle, _handle, (uint) commandBuffers.Length, commandBufferPtr);
    }

    public void Reset(VkCommandPoolResetFlags flags = 0) // TODO: None
    {
        _commands.vkResetCommandPool(_deviceHandle, _handle, flags).ThrowOnError();
    }

    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _commands.vkDestroyCommandPool(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~CommandPool()
    {
        Dispose();
    }
}