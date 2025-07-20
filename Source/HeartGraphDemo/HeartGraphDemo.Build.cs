// Copyright Guy (Drakynfly) Lundvall. All Rights Reserved.

using UnrealBuildTool;

public class HeartGraphDemo : ModuleRules
{
	public HeartGraphDemo(ReadOnlyTargetRules Target) : base(Target)
	{
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
		Module.PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		Module.DefaultBuildSettings = BuildSettingsVersion.Latest;
		Module.IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

		if (Target.Configuration == UnrealTargetConfiguration.DebugGame
		    || Target.Configuration == UnrealTargetConfiguration.Debug)
		{
			Module.bUseUnity = false;
			Module.CppCompileWarningSettings.NonInlinedGenCppWarningLevel = WarningLevel.Warning;
			Module.CppCompileWarningSettings.UnsafeTypeCastWarningLevel = WarningLevel.Warning;
		}
	}
}