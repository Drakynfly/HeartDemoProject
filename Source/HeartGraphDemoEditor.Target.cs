// Copyright Guy (Drakynfly) Lundvall. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class HeartGraphDemoEditorTarget : TargetRules
{
	public HeartGraphDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange( new string[] { "HeartGraphDemo" } );
	}
}