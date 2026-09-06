using UnrealBuildTool;
using System.Collections.Generic;

public class VioletPrototypeTarget : TargetRules
{
	public VioletPrototypeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("VioletPrototype");
	}
}
