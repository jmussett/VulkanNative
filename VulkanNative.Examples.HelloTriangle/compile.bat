@echo off

@echo compiled vert.spv:

%VULKAN_SDK%\Bin\glslc.exe shaders/shader.vert -o shaders/vert.spv
%VULKAN_SDK%\Bin\spirv-dis.exe shaders/vert.spv

@echo compiled frag.spv:

%VULKAN_SDK%\Bin\glslc.exe shaders/shader.frag -o shaders/frag.spv
%VULKAN_SDK%\Bin\spirv-dis.exe shaders/frag.spv
pause