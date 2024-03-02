// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HeartGraphDemo : ModuleRules
{
	public HeartGraphDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		ApplySharedModuleSetup(this, Target);

		PublicDependencyModuleNames.AddRange(new []
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput"
		});
	}

	public static void ApplySharedModuleSetup(ModuleRules Module, ReadOnlyTargetRules Target)
	{
		if (Target.Configuration == UnrealTargetConfiguration.DebugGame
		    || Target.Configuration == UnrealTargetConfiguration.Debug)
		{
			Module.bUseUnity = false;
		}
	}
}