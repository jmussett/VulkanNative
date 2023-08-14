using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkDeviceCommands
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, void> _vkDestroyDevice;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, uint, VkQueue*, void> _vkGetDeviceQueue;
    private delegate* unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult> _vkQueueSubmit;
    private delegate* unmanaged[Cdecl]<VkQueue, VkResult> _vkQueueWaitIdle;
    private delegate* unmanaged[Cdecl]<VkDevice, VkResult> _vkDeviceWaitIdle;
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult> _vkAllocateMemory;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> _vkFreeMemory;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkDeviceSize, VkDeviceSize, VkMemoryMapFlags, void**, VkResult> _vkMapMemory;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, void> _vkUnmapMemory;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkMappedMemoryRange*, VkResult> _vkFlushMappedMemoryRanges;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkMappedMemoryRange*, VkResult> _vkInvalidateMappedMemoryRanges;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkDeviceSize*, void> _vkGetDeviceMemoryCommitment;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkDeviceMemory, VkDeviceSize, VkResult> _vkBindBufferMemory;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkDeviceMemory, VkDeviceSize, VkResult> _vkBindImageMemory;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkMemoryRequirements*, void> _vkGetBufferMemoryRequirements;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkMemoryRequirements*, void> _vkGetImageMemoryRequirements;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, uint*, VkSparseImageMemoryRequirements*, void> _vkGetImageSparseMemoryRequirements;
    private delegate* unmanaged[Cdecl]<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> _vkQueueBindSparse;
    private delegate* unmanaged[Cdecl]<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult> _vkCreateFence;
    private delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkAllocationCallbacks*, void> _vkDestroyFence;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkFence*, VkResult> _vkResetFences;
    private delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkResult> _vkGetFenceStatus;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkFence*, VkBool32, ulong, VkResult> _vkWaitForFences;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreCreateInfo*, VkAllocationCallbacks*, VkSemaphore*, VkResult> _vkCreateSemaphore;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> _vkDestroySemaphore;
    private delegate* unmanaged[Cdecl]<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult> _vkCreateEvent;
    private delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkAllocationCallbacks*, void> _vkDestroyEvent;
    private delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> _vkGetEventStatus;
    private delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> _vkSetEvent;
    private delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> _vkResetEvent;
    private delegate* unmanaged[Cdecl]<VkDevice, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, VkQueryPool*, VkResult> _vkCreateQueryPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> _vkDestroyQueryPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, nint, void*, VkDeviceSize, VkQueryResultFlags, VkResult> _vkGetQueryPoolResults;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult> _vkCreateBuffer;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkAllocationCallbacks*, void> _vkDestroyBuffer;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferViewCreateInfo*, VkAllocationCallbacks*, VkBufferView*, VkResult> _vkCreateBufferView;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferView, VkAllocationCallbacks*, void> _vkDestroyBufferView;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult> _vkCreateImage;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkAllocationCallbacks*, void> _vkDestroyImage;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void> _vkGetImageSubresourceLayout;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageViewCreateInfo*, VkAllocationCallbacks*, VkImageView*, VkResult> _vkCreateImageView;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkAllocationCallbacks*, void> _vkDestroyImageView;
    private delegate* unmanaged[Cdecl]<VkDevice, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, VkShaderModule*, VkResult> _vkCreateShaderModule;
    private delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> _vkDestroyShaderModule;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCacheCreateInfo*, VkAllocationCallbacks*, VkPipelineCache*, VkResult> _vkCreatePipelineCache;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> _vkDestroyPipelineCache;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, nint*, void*, VkResult> _vkGetPipelineCacheData;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult> _vkMergePipelineCaches;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateGraphicsPipelines;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateComputePipelines;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkAllocationCallbacks*, void> _vkDestroyPipeline;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineLayoutCreateInfo*, VkAllocationCallbacks*, VkPipelineLayout*, VkResult> _vkCreatePipelineLayout;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> _vkDestroyPipelineLayout;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, VkSampler*, VkResult> _vkCreateSampler;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSampler, VkAllocationCallbacks*, void> _vkDestroySampler;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkAllocationCallbacks*, VkDescriptorSetLayout*, VkResult> _vkCreateDescriptorSetLayout;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void> _vkDestroyDescriptorSetLayout;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, VkDescriptorPool*, VkResult> _vkCreateDescriptorPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> _vkDestroyDescriptorPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult> _vkResetDescriptorPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult> _vkAllocateDescriptorSets;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult> _vkFreeDescriptorSets;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void> _vkUpdateDescriptorSets;
    private delegate* unmanaged[Cdecl]<VkDevice, VkFramebufferCreateInfo*, VkAllocationCallbacks*, VkFramebuffer*, VkResult> _vkCreateFramebuffer;
    private delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> _vkDestroyFramebuffer;
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderPassCreateInfo*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass;
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> _vkDestroyRenderPass;
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, void> _vkGetRenderAreaGranularity;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCommandPoolCreateInfo*, VkAllocationCallbacks*, VkCommandPool*, VkResult> _vkCreateCommandPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> _vkDestroyCommandPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolResetFlags, VkResult> _vkResetCommandPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult> _vkAllocateCommandBuffers;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void> _vkFreeCommandBuffers;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult> _vkBeginCommandBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResult> _vkEndCommandBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferResetFlags, VkResult> _vkResetCommandBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> _vkCmdBindPipeline;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewport*, void> _vkCmdSetViewport;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetScissor;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> _vkCmdSetLineWidth;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, float, void> _vkCmdSetDepthBias;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, float*, void> _vkCmdSetBlendConstants;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, void> _vkCmdSetDepthBounds;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, uint, void> _vkCmdSetStencilCompareMask;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, uint, void> _vkCmdSetStencilWriteMask;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, uint, void> _vkCmdSetStencilReference;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void> _vkCmdBindDescriptorSets;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkIndexType, void> _vkCmdBindIndexBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void> _vkCmdBindVertexBuffers;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, void> _vkCmdDraw;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, int, uint, void> _vkCmdDrawIndexed;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawIndirect;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawIndexedIndirect;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void> _vkCmdDispatch;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, void> _vkCmdDispatchIndirect;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> _vkCmdCopyBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void> _vkCmdCopyImage;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void> _vkCmdBlitImage;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void> _vkCmdCopyBufferToImage;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> _vkCmdCopyImageToBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, void*, void> _vkCmdUpdateBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, uint, void> _vkCmdFillBuffer;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkClearColorValue*, uint, VkImageSubresourceRange*, void> _vkCmdClearColorImage;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkClearDepthStencilValue*, uint, VkImageSubresourceRange*, void> _vkCmdClearDepthStencilImage;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void> _vkCmdClearAttachments;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void> _vkCmdResolveImage;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> _vkCmdSetEvent;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> _vkCmdResetEvent;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlags, VkPipelineStageFlags, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _vkCmdWaitEvents;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkPipelineStageFlags, VkDependencyFlags, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _vkCmdPipelineBarrier;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, void> _vkCmdBeginQuery;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, void> _vkCmdEndQuery;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, void> _vkCmdResetQueryPool;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, uint, void> _vkCmdWriteTimestamp;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, VkDeviceSize, VkDeviceSize, VkQueryResultFlags, void> _vkCmdCopyQueryPoolResults;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlags, uint, uint, void*, void> _vkCmdPushConstants;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void> _vkCmdBeginRenderPass;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassContents, void> _vkCmdNextSubpass;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdEndRenderPass;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkCommandBuffer*, void> _vkCmdExecuteCommands;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> _vkBindBufferMemory2;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> _vkBindImageMemory2;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> _vkGetDeviceGroupPeerMemoryFeatures;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetDeviceMask;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> _vkCmdDispatchBase;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetImageMemoryRequirements2;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetBufferMemoryRequirements2;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetImageSparseMemoryRequirements2;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> _vkTrimCommandPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void> _vkGetDeviceQueue2;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> _vkCreateSamplerYcbcrConversion;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> _vkDestroySamplerYcbcrConversion;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> _vkCreateDescriptorUpdateTemplate;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> _vkDestroyDescriptorUpdateTemplate;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> _vkUpdateDescriptorSetWithTemplate;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> _vkGetDescriptorSetLayoutSupport;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawIndirectCount;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> _vkCmdDrawIndexedIndirectCount;
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> _vkCmdBeginRenderPass2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> _vkCmdNextSubpass2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> _vkCmdEndRenderPass2;
    private delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void> _vkResetQueryPool;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, ulong*, VkResult> _vkGetSemaphoreCounterValue;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> _vkWaitSemaphores;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> _vkSignalSemaphore;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> _vkGetBufferDeviceAddress;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferOpaqueCaptureAddress;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> _vkGetDeviceMemoryOpaqueCaptureAddress;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> _vkCreatePrivateDataSlot;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> _vkDestroyPrivateDataSlot;
    private delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> _vkSetPrivateData;
    private delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> _vkGetPrivateData;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> _vkCmdSetEvent2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> _vkCmdResetEvent2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> _vkCmdWaitEvents2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> _vkCmdPipelineBarrier2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void> _vkCmdWriteTimestamp2;
    private delegate* unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> _vkQueueSubmit2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> _vkCmdCopyBuffer2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> _vkCmdCopyImage2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> _vkCmdCopyBufferToImage2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> _vkCmdCopyImageToBuffer2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> _vkCmdBlitImage2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> _vkCmdResolveImage2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> _vkCmdBeginRendering;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdEndRendering;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> _vkCmdSetCullMode;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> _vkCmdSetFrontFace;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> _vkCmdSetPrimitiveTopology;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkViewport*, void> _vkCmdSetViewportWithCount;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkRect2D*, void> _vkCmdSetScissorWithCount;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void> _vkCmdBindVertexBuffers2;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthTestEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthWriteEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> _vkCmdSetDepthCompareOp;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthBoundsTestEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetStencilTestEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> _vkCmdSetStencilOp;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetRasterizerDiscardEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthBiasEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetPrimitiveRestartEnable;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceBufferMemoryRequirements;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceImageMemoryRequirements;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetDeviceImageSparseMemoryRequirements;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyDevice(device, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue)
    {
        _vkGetDeviceQueue(device, queueFamilyIndex, queueIndex, pQueue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkQueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
    {
        return _vkQueueSubmit(queue, submitCount, pSubmits, fence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkQueueWaitIdle(VkQueue queue)
    {
        return _vkQueueWaitIdle(queue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkDeviceWaitIdle(VkDevice device)
    {
        return _vkDeviceWaitIdle(device);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)
    {
        return _vkAllocateMemory(device, pAllocateInfo, pAllocator, pMemory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkFreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)
    {
        _vkFreeMemory(device, memory, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkMapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size, VkMemoryMapFlags flags, void** ppData)
    {
        return _vkMapMemory(device, memory, offset, size, flags, ppData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkUnmapMemory(VkDevice device, VkDeviceMemory memory)
    {
        _vkUnmapMemory(device, memory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkFlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
    {
        return _vkFlushMappedMemoryRanges(device, memoryRangeCount, pMemoryRanges);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkInvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
    {
        return _vkInvalidateMappedMemoryRanges(device, memoryRangeCount, pMemoryRanges);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes)
    {
        _vkGetDeviceMemoryCommitment(device, memory, pCommittedMemoryInBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset)
    {
        return _vkBindBufferMemory(device, buffer, memory, memoryOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset)
    {
        return _vkBindImageMemory(device, image, memory, memoryOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)
    {
        _vkGetBufferMemoryRequirements(device, buffer, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)
    {
        _vkGetImageMemoryRequirements(device, image, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
    {
        _vkGetImageSparseMemoryRequirements(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkQueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
    {
        return _vkQueueBindSparse(queue, bindInfoCount, pBindInfo, fence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
    {
        return _vkCreateFence(device, pCreateInfo, pAllocator, pFence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyFence(device, fence, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkResetFences(VkDevice device, uint fenceCount, VkFence* pFences)
    {
        return _vkResetFences(device, fenceCount, pFences);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetFenceStatus(VkDevice device, VkFence fence)
    {
        return _vkGetFenceStatus(device, fence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkWaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout)
    {
        return _vkWaitForFences(device, fenceCount, pFences, waitAll, timeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)
    {
        return _vkCreateSemaphore(device, pCreateInfo, pAllocator, pSemaphore);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroySemaphore(device, semaphore, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)
    {
        return _vkCreateEvent(device, pCreateInfo, pAllocator, pEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyEvent(VkDevice device, VkEvent @event, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyEvent(device, @event, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetEventStatus(VkDevice device, VkEvent @event)
    {
        return _vkGetEventStatus(device, @event);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSetEvent(VkDevice device, VkEvent @event)
    {
        return _vkSetEvent(device, @event);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkResetEvent(VkDevice device, VkEvent @event)
    {
        return _vkResetEvent(device, @event);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)
    {
        return _vkCreateQueryPool(device, pCreateInfo, pAllocator, pQueryPool);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyQueryPool(device, queryPool, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nint dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags)
    {
        return _vkGetQueryPoolResults(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)
    {
        return _vkCreateBuffer(device, pCreateInfo, pAllocator, pBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyBuffer(device, buffer, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)
    {
        return _vkCreateBufferView(device, pCreateInfo, pAllocator, pView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyBufferView(device, bufferView, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)
    {
        return _vkCreateImage(device, pCreateInfo, pAllocator, pImage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyImage(device, image, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
    {
        _vkGetImageSubresourceLayout(device, image, pSubresource, pLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)
    {
        return _vkCreateImageView(device, pCreateInfo, pAllocator, pView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyImageView(device, imageView, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)
    {
        return _vkCreateShaderModule(device, pCreateInfo, pAllocator, pShaderModule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyShaderModule(device, shaderModule, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)
    {
        return _vkCreatePipelineCache(device, pCreateInfo, pAllocator, pPipelineCache);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyPipelineCache(device, pipelineCache, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nint* pDataSize, void* pData)
    {
        return _vkGetPipelineCacheData(device, pipelineCache, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
    {
        return _vkMergePipelineCaches(device, dstCache, srcCacheCount, pSrcCaches);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
    {
        return _vkCreateGraphicsPipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
    {
        return _vkCreateComputePipelines(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyPipeline(device, pipeline, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)
    {
        return _vkCreatePipelineLayout(device, pCreateInfo, pAllocator, pPipelineLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyPipelineLayout(device, pipelineLayout, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)
    {
        return _vkCreateSampler(device, pCreateInfo, pAllocator, pSampler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroySampler(device, sampler, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)
    {
        return _vkCreateDescriptorSetLayout(device, pCreateInfo, pAllocator, pSetLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyDescriptorSetLayout(device, descriptorSetLayout, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)
    {
        return _vkCreateDescriptorPool(device, pCreateInfo, pAllocator, pDescriptorPool);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyDescriptorPool(device, descriptorPool, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)
    {
        return _vkResetDescriptorPool(device, descriptorPool, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
    {
        return _vkAllocateDescriptorSets(device, pAllocateInfo, pDescriptorSets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
    {
        return _vkFreeDescriptorSets(device, descriptorPool, descriptorSetCount, pDescriptorSets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkUpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
    {
        _vkUpdateDescriptorSets(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)
    {
        return _vkCreateFramebuffer(device, pCreateInfo, pAllocator, pFramebuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyFramebuffer(device, framebuffer, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
    {
        return _vkCreateRenderPass(device, pCreateInfo, pAllocator, pRenderPass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyRenderPass(device, renderPass, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)
    {
        _vkGetRenderAreaGranularity(device, renderPass, pGranularity);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)
    {
        return _vkCreateCommandPool(device, pCreateInfo, pAllocator, pCommandPool);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyCommandPool(device, commandPool, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags)
    {
        return _vkResetCommandPool(device, commandPool, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
    {
        return _vkAllocateCommandBuffers(device, pAllocateInfo, pCommandBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
    {
        _vkFreeCommandBuffers(device, commandPool, commandBufferCount, pCommandBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
    {
        return _vkBeginCommandBuffer(commandBuffer, pBeginInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEndCommandBuffer(VkCommandBuffer commandBuffer)
    {
        return _vkEndCommandBuffer(commandBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags)
    {
        return _vkResetCommandBuffer(commandBuffer, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
    {
        _vkCmdBindPipeline(commandBuffer, pipelineBindPoint, pipeline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
    {
        _vkCmdSetViewport(commandBuffer, firstViewport, viewportCount, pViewports);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
    {
        _vkCmdSetScissor(commandBuffer, firstScissor, scissorCount, pScissors);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
    {
        _vkCmdSetLineWidth(commandBuffer, lineWidth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
    {
        _vkCmdSetDepthBias(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetBlendConstants(VkCommandBuffer commandBuffer, float* blendConstants)
    {
        _vkCmdSetBlendConstants(commandBuffer, blendConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
    {
        _vkCmdSetDepthBounds(commandBuffer, minDepthBounds, maxDepthBounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask)
    {
        _vkCmdSetStencilCompareMask(commandBuffer, faceMask, compareMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask)
    {
        _vkCmdSetStencilWriteMask(commandBuffer, faceMask, writeMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference)
    {
        _vkCmdSetStencilReference(commandBuffer, faceMask, reference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
    {
        _vkCmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType)
    {
        _vkCmdBindIndexBuffer(commandBuffer, buffer, offset, indexType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets)
    {
        _vkCmdBindVertexBuffers(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
    {
        _vkCmdDraw(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
    {
        _vkCmdDrawIndexed(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride)
    {
        _vkCmdDrawIndirect(commandBuffer, buffer, offset, drawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint drawCount, uint stride)
    {
        _vkCmdDrawIndexedIndirect(commandBuffer, buffer, offset, drawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
    {
        _vkCmdDispatch(commandBuffer, groupCountX, groupCountY, groupCountZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset)
    {
        _vkCmdDispatchIndirect(commandBuffer, buffer, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
    {
        _vkCmdCopyBuffer(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
    {
        _vkCmdCopyImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
    {
        _vkCmdBlitImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
    {
        _vkCmdCopyBufferToImage(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
    {
        _vkCmdCopyImageToBuffer(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, void* pData)
    {
        _vkCmdUpdateBuffer(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint data)
    {
        _vkCmdFillBuffer(commandBuffer, dstBuffer, dstOffset, size, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
    {
        _vkCmdClearColorImage(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
    {
        _vkCmdClearDepthStencilImage(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
    {
        _vkCmdClearAttachments(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
    {
        _vkCmdResolveImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask)
    {
        _vkCmdSetEvent(commandBuffer, @event, stageMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags stageMask)
    {
        _vkCmdResetEvent(commandBuffer, @event, stageMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
    {
        _vkCmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
    {
        _vkCmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags)
    {
        _vkCmdBeginQuery(commandBuffer, queryPool, query, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
    {
        _vkCmdEndQuery(commandBuffer, queryPool, query);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
    {
        _vkCmdResetQueryPool(commandBuffer, queryPool, firstQuery, queryCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query)
    {
        _vkCmdWriteTimestamp(commandBuffer, pipelineStage, queryPool, query);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags)
    {
        _vkCmdCopyQueryPoolResults(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues)
    {
        _vkCmdPushConstants(commandBuffer, layout, stageFlags, offset, size, pValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
    {
        _vkCmdBeginRenderPass(commandBuffer, pRenderPassBegin, contents);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
    {
        _vkCmdNextSubpass(commandBuffer, contents);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndRenderPass(VkCommandBuffer commandBuffer)
    {
        _vkCmdEndRenderPass(commandBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
    {
        _vkCmdExecuteCommands(commandBuffer, commandBufferCount, pCommandBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
    {
        return _vkBindBufferMemory2(device, bindInfoCount, pBindInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
    {
        return _vkBindImageMemory2(device, bindInfoCount, pBindInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
    {
        _vkGetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
    {
        _vkCmdSetDeviceMask(commandBuffer, deviceMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
    {
        _vkCmdDispatchBase(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetImageMemoryRequirements2(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetBufferMemoryRequirements2(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
    {
        _vkGetImageSparseMemoryRequirements2(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkTrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
    {
        _vkTrimCommandPool(device, commandPool, flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue)
    {
        _vkGetDeviceQueue2(device, pQueueInfo, pQueue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
    {
        return _vkCreateSamplerYcbcrConversion(device, pCreateInfo, pAllocator, pYcbcrConversion);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroySamplerYcbcrConversion(device, ycbcrConversion, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
    {
        return _vkCreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
    {
        _vkUpdateDescriptorSetWithTemplate(device, descriptorSet, descriptorUpdateTemplate, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
    {
        _vkGetDescriptorSetLayoutSupport(device, pCreateInfo, pSupport);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
        _vkCmdDrawIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkBuffer countBuffer, VkDeviceSize countBufferOffset, uint maxDrawCount, uint stride)
    {
        _vkCmdDrawIndexedIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
    {
        return _vkCreateRenderPass2(device, pCreateInfo, pAllocator, pRenderPass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
    {
        _vkCmdBeginRenderPass2(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
    {
        _vkCmdNextSubpass2(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
    {
        _vkCmdEndRenderPass2(commandBuffer, pSubpassEndInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
    {
        _vkResetQueryPool(device, queryPool, firstQuery, queryCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
    {
        return _vkGetSemaphoreCounterValue(device, semaphore, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkWaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
    {
        return _vkWaitSemaphores(device, pWaitInfo, timeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
    {
        return _vkSignalSemaphore(device, pSignalInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkDeviceAddress VkGetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
    {
        return _vkGetBufferDeviceAddress(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong VkGetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
    {
        return _vkGetBufferOpaqueCaptureAddress(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong VkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
    {
        return _vkGetDeviceMemoryOpaqueCaptureAddress(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
    {
        return _vkCreatePrivateDataSlot(device, pCreateInfo, pAllocator, pPrivateDataSlot);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyPrivateDataSlot(device, privateDataSlot, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
    {
        return _vkSetPrivateData(device, objectType, objectHandle, privateDataSlot, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
    {
        _vkGetPrivateData(device, objectType, objectHandle, privateDataSlot, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
    {
        _vkCmdSetEvent2(commandBuffer, @event, pDependencyInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdResetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlags2 stageMask)
    {
        _vkCmdResetEvent2(commandBuffer, @event, stageMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWaitEvents2(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
    {
        _vkCmdWaitEvents2(commandBuffer, eventCount, pEvents, pDependencyInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdPipelineBarrier2(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
    {
        _vkCmdPipelineBarrier2(commandBuffer, pDependencyInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdWriteTimestamp2(VkCommandBuffer commandBuffer, VkPipelineStageFlags2 stage, VkQueryPool queryPool, uint query)
    {
        _vkCmdWriteTimestamp2(commandBuffer, stage, queryPool, query);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkQueueSubmit2(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
    {
        return _vkQueueSubmit2(queue, submitCount, pSubmits, fence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
    {
        _vkCmdCopyBuffer2(commandBuffer, pCopyBufferInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
    {
        _vkCmdCopyImage2(commandBuffer, pCopyImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
    {
        _vkCmdCopyBufferToImage2(commandBuffer, pCopyBufferToImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
    {
        _vkCmdCopyImageToBuffer2(commandBuffer, pCopyImageToBufferInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
    {
        _vkCmdBlitImage2(commandBuffer, pBlitImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
    {
        _vkCmdResolveImage2(commandBuffer, pResolveImageInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBeginRendering(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
    {
        _vkCmdBeginRendering(commandBuffer, pRenderingInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdEndRendering(VkCommandBuffer commandBuffer)
    {
        _vkCmdEndRendering(commandBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode)
    {
        _vkCmdSetCullMode(commandBuffer, cullMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
    {
        _vkCmdSetFrontFace(commandBuffer, frontFace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
    {
        _vkCmdSetPrimitiveTopology(commandBuffer, primitiveTopology);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
    {
        _vkCmdSetViewportWithCount(commandBuffer, viewportCount, pViewports);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
    {
        _vkCmdSetScissorWithCount(commandBuffer, scissorCount, pScissors);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, VkDeviceSize* pOffsets, VkDeviceSize* pSizes, VkDeviceSize* pStrides)
    {
        _vkCmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable)
    {
        _vkCmdSetDepthTestEnable(commandBuffer, depthTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable)
    {
        _vkCmdSetDepthWriteEnable(commandBuffer, depthWriteEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
    {
        _vkCmdSetDepthCompareOp(commandBuffer, depthCompareOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable)
    {
        _vkCmdSetDepthBoundsTestEnable(commandBuffer, depthBoundsTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetStencilTestEnable(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable)
    {
        _vkCmdSetStencilTestEnable(commandBuffer, stencilTestEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
    {
        _vkCmdSetStencilOp(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable)
    {
        _vkCmdSetRasterizerDiscardEnable(commandBuffer, rasterizerDiscardEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable)
    {
        _vkCmdSetDepthBiasEnable(commandBuffer, depthBiasEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable)
    {
        _vkCmdSetPrimitiveRestartEnable(commandBuffer, primitiveRestartEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceBufferMemoryRequirements(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetDeviceBufferMemoryRequirements(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceImageMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetDeviceImageMemoryRequirements(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
    {
        _vkGetDeviceImageSparseMemoryRequirements(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }
}