// CopyRight Ou junichi

using UnrealBuildTool;
using System.Collections.Generic;

public class Topdown_LEARNINGTarget : TargetRules
{
	public Topdown_LEARNINGTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Topdown_LEARNING" } );
	}
}
