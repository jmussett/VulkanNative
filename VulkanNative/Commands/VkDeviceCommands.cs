﻿namespace VulkanNative;

public unsafe class VkDeviceCommands
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, void> vkDestroyDevice;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, uint, VkQueue*, void> vkGetDeviceQueue;
    public delegate* unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult> vkQueueSubmit;
    public delegate* unmanaged[Cdecl]<VkQueue, VkResult> vkQueueWaitIdle;
    public delegate* unmanaged[Cdecl]<VkDevice, VkResult> vkDeviceWaitIdle;
    public delegate* unmanaged[Cdecl]<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult> vkAllocateMemory;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> vkFreeMemory;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkDeviceSize, VkDeviceSize, VkMemoryMapFlags, void**, VkResult> vkMapMemory;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, void> vkUnmapMemory;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkFlushMappedMemoryRanges;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkInvalidateMappedMemoryRanges;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkDeviceSize*, void> vkGetDeviceMemoryCommitment;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkDeviceMemory, VkDeviceSize, VkResult> vkBindBufferMemory;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkDeviceMemory, VkDeviceSize, VkResult> vkBindImageMemory;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkMemoryRequirements*, void> vkGetBufferMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkMemoryRequirements*, void> vkGetImageMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, uint*, VkSparseImageMemoryRequirements*, void> vkGetImageSparseMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> vkQueueBindSparse;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult> vkCreateFence;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkAllocationCallbacks*, void> vkDestroyFence;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkFence*, VkResult> vkResetFences;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkResult> vkGetFenceStatus;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkFence*, VkBool32, ulong, VkResult> vkWaitForFences;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreCreateInfo*, VkAllocationCallbacks*, VkSemaphore*, VkResult> vkCreateSemaphore;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> vkDestroySemaphore;
    public delegate* unmanaged[Cdecl]<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult> vkCreateEvent;
    public delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkAllocationCallbacks*, void> vkDestroyEvent;
    public delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> vkGetEventStatus;
    public delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> vkSetEvent;
    public delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> vkResetEvent;
    public delegate* unmanaged[Cdecl]<VkDevice, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, VkQueryPool*, VkResult> vkCreateQueryPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> vkDestroyQueryPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, nint, void*, VkDeviceSize, VkQueryResultFlags, VkResult> vkGetQueryPoolResults;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult> vkCreateBuffer;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkAllocationCallbacks*, void> vkDestroyBuffer;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferViewCreateInfo*, VkAllocationCallbacks*, VkBufferView*, VkResult> vkCreateBufferView;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferView, VkAllocationCallbacks*, void> vkDestroyBufferView;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult> vkCreateImage;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkAllocationCallbacks*, void> vkDestroyImage;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void> vkGetImageSubresourceLayout;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageViewCreateInfo*, VkAllocationCallbacks*, VkImageView*, VkResult> vkCreateImageView;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkAllocationCallbacks*, void> vkDestroyImageView;
    public delegate* unmanaged[Cdecl]<VkDevice, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, VkShaderModule*, VkResult> vkCreateShaderModule;
    public delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> vkDestroyShaderModule;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCacheCreateInfo*, VkAllocationCallbacks*, VkPipelineCache*, VkResult> vkCreatePipelineCache;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> vkDestroyPipelineCache;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, nint*, void*, VkResult> vkGetPipelineCacheData;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult> vkMergePipelineCaches;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateGraphicsPipelines;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateComputePipelines;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkAllocationCallbacks*, void> vkDestroyPipeline;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineLayoutCreateInfo*, VkAllocationCallbacks*, VkPipelineLayout*, VkResult> vkCreatePipelineLayout;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> vkDestroyPipelineLayout;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, VkSampler*, VkResult> vkCreateSampler;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSampler, VkAllocationCallbacks*, void> vkDestroySampler;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkAllocationCallbacks*, VkDescriptorSetLayout*, VkResult> vkCreateDescriptorSetLayout;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void> vkDestroyDescriptorSetLayout;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, VkDescriptorPool*, VkResult> vkCreateDescriptorPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> vkDestroyDescriptorPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult> vkResetDescriptorPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult> vkAllocateDescriptorSets;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult> vkFreeDescriptorSets;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void> vkUpdateDescriptorSets;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFramebufferCreateInfo*, VkAllocationCallbacks*, VkFramebuffer*, VkResult> vkCreateFramebuffer;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> vkDestroyFramebuffer;
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderPassCreateInfo*, VkAllocationCallbacks*, VkRenderPass*, VkResult> vkCreateRenderPass;
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> vkDestroyRenderPass;
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, void> vkGetRenderAreaGranularity;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandPoolCreateInfo*, VkAllocationCallbacks*, VkCommandPool*, VkResult> vkCreateCommandPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> vkDestroyCommandPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolResetFlags, VkResult> vkResetCommandPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult> vkAllocateCommandBuffers;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void> vkFreeCommandBuffers;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult> vkBeginCommandBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResult> vkEndCommandBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferResetFlags, VkResult> vkResetCommandBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> vkCmdBindPipeline;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewport*, void> vkCmdSetViewport;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetScissor;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> vkCmdSetLineWidth;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, float, void> vkCmdSetDepthBias;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> vkCmdSetBlendConstants;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, void> vkCmdSetDepthBounds;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, uint, void> vkCmdSetStencilCompareMask;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, uint, void> vkCmdSetStencilWriteMask;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, uint, void> vkCmdSetStencilReference;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void> vkCmdBindDescriptorSets;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkIndexType, void> vkCmdBindIndexBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, void> vkCmdBindVertexBuffers;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, void> vkCmdDraw;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, int, uint, void> vkCmdDrawIndexed;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawIndirect;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawIndexedIndirect;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void> vkCmdDispatch;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, void> vkCmdDispatchIndirect;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> vkCmdCopyBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void> vkCmdCopyImage;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void> vkCmdBlitImage;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void> vkCmdCopyBufferToImage;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> vkCmdCopyImageToBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, void*, void> vkCmdUpdateBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, uint, void> vkCmdFillBuffer;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkClearColorValue*, uint, VkImageSubresourceRange*, void> vkCmdClearColorImage;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkClearDepthStencilValue*, uint, VkImageSubresourceRange*, void> vkCmdClearDepthStencilImage;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void> vkCmdClearAttachments;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void> vkCmdResolveImage;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> vkCmdSetEvent;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> vkCmdResetEvent;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlags, VkPipelineStageFlags, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> vkCmdWaitEvents;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkPipelineStageFlags, VkDependencyFlags, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> vkCmdPipelineBarrier;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, void> vkCmdBeginQuery;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, void> vkCmdEndQuery;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, void> vkCmdResetQueryPool;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void> vkCmdWriteTimestamp;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, VkDeviceSize, VkDeviceSize, VkQueryResultFlags, void> vkCmdCopyQueryPoolResults;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlags, uint, uint, void*, void> vkCmdPushConstants;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void> vkCmdBeginRenderPass;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassContents, void> vkCmdNextSubpass;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void> vkCmdEndRenderPass;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkCommandBuffer*, void> vkCmdExecuteCommands;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> vkBindBufferMemory2;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> vkBindImageMemory2;
    public delegate* unmanaged[Cdecl]<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> vkGetDeviceGroupPeerMemoryFeatures;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> vkCmdSetDeviceMask;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> vkCmdDispatchBase;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetImageMemoryRequirements2;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetBufferMemoryRequirements2;
    public delegate* unmanaged[Cdecl]<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetImageSparseMemoryRequirements2;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> vkTrimCommandPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void> vkGetDeviceQueue2;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> vkCreateSamplerYcbcrConversion;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> vkDestroySamplerYcbcrConversion;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> vkCreateDescriptorUpdateTemplate;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> vkDestroyDescriptorUpdateTemplate;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> vkUpdateDescriptorSetWithTemplate;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> vkGetDescriptorSetLayoutSupport;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawIndirectCount;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void> vkCmdDrawIndexedIndirectCount;
    public delegate* unmanaged[Cdecl]<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> vkCreateRenderPass2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> vkCmdBeginRenderPass2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> vkCmdNextSubpass2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> vkCmdEndRenderPass2;
    public delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void> vkResetQueryPool;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, ulong*, VkResult> vkGetSemaphoreCounterValue;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> vkWaitSemaphores;
    public delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> vkSignalSemaphore;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> vkGetBufferDeviceAddress;
    public delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferOpaqueCaptureAddress;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> vkGetDeviceMemoryOpaqueCaptureAddress;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> vkCreatePrivateDataSlot;
    public delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> vkDestroyPrivateDataSlot;
    public delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> vkSetPrivateData;
    public delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> vkGetPrivateData;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> vkCmdSetEvent2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> vkCmdResetEvent2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> vkCmdWaitEvents2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> vkCmdPipelineBarrier2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void> vkCmdWriteTimestamp2;
    public delegate* unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> vkQueueSubmit2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> vkCmdCopyBuffer2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> vkCmdCopyImage2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> vkCmdCopyBufferToImage2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> vkCmdCopyImageToBuffer2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> vkCmdBlitImage2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> vkCmdResolveImage2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> vkCmdBeginRendering;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, void> vkCmdEndRendering;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> vkCmdSetCullMode;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> vkCmdSetFrontFace;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> vkCmdSetPrimitiveTopology;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkViewport*, void> vkCmdSetViewportWithCount;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkRect2D*, void> vkCmdSetScissorWithCount;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, VkDeviceSize*, VkDeviceSize*, VkDeviceSize*, void> vkCmdBindVertexBuffers2;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthTestEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthWriteEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> vkCmdSetDepthCompareOp;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthBoundsTestEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetStencilTestEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> vkCmdSetStencilOp;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetRasterizerDiscardEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetDepthBiasEnable;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> vkCmdSetPrimitiveRestartEnable;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceBufferMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceImageMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetDeviceImageSparseMemoryRequirements;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandBuffer, VkCommandPoolMemoryConsumption*, void> vkGetCommandPoolMemoryConsumption;
    public delegate* unmanaged[Cdecl]<VkDevice, VkFaultQueryBehavior, VkBool32*, uint*, VkFaultData*, VkResult> vkGetFaultData;
}