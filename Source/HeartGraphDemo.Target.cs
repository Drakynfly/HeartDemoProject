// Copyright Guy (Drakynfly) Lundvall. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class HeartGraphDemoTarget : TargetRules
{
	public HeartGraphDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange( new string[] { "HeartGraphDemo" } );
	}
}