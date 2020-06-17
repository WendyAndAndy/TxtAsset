// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

/*  因为该模块仅仅只往外曝露了一种新的UObject类型 (UTxtAsset)
 *  功能上只实现了默认模块的加载卸载
 *  没有使用任何更多其它模块
 *  所以该编译脚本使用默认的没做任何修改
 */

using UnrealBuildTool;

public class TxtAsset : ModuleRules
{
	public TxtAsset(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        // 本模块的Public目录 (通常为了往外曝露功能的头文件放在这里面)
        // 目前不需要手动添加，因为官方说UHT会自动发现与包含Public目录以及子目录下文件
        PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);

        // 本模块的Private目录及子目录
        // 好像也不需要手动添加，UBT也能找到？
        PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);

        // 本模块Public依赖的其它模块
        // [!重要] 
        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);

        // 本模块Private依赖的其它模块
        // [!重要] 如果少写，会出现链接错误
        PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		// 可能需要动态加载的其它模块
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
