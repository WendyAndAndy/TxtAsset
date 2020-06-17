// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

/*  ��Ϊ��ģ�����ֻ������¶��һ���µ�UObject���� (UTxtAsset)
 *  ������ֻʵ����Ĭ��ģ��ļ���ж��
 *  û��ʹ���κθ�������ģ��
 *  ���Ըñ���ű�ʹ��Ĭ�ϵ�û���κ��޸�
 */

using UnrealBuildTool;

public class TxtAsset : ModuleRules
{
	public TxtAsset(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        // ��ģ���PublicĿ¼ (ͨ��Ϊ��������¶���ܵ�ͷ�ļ�����������)
        // Ŀǰ����Ҫ�ֶ���ӣ���Ϊ�ٷ�˵UHT���Զ����������PublicĿ¼�Լ���Ŀ¼���ļ�
        PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);

        // ��ģ���PrivateĿ¼����Ŀ¼
        // ����Ҳ����Ҫ�ֶ���ӣ�UBTҲ���ҵ���
        PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);

        // ��ģ��Public����������ģ��
        // [!��Ҫ] 
        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);

        // ��ģ��Private����������ģ��
        // [!��Ҫ] �����д����������Ӵ���
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
		
		// ������Ҫ��̬���ص�����ģ��
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
