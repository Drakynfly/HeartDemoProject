// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HeartGraphDemo : ModuleRules
{
	public HeartGraphDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new []
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput"
		});
	}
}
