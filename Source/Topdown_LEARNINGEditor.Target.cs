// CopyRight Ou junichi

using UnrealBuildTool;
using System.Collections.Generic;

public class Topdown_LEARNINGEditorTarget : TargetRules
{
	public Topdown_LEARNINGEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Topdown_LEARNING" } );
	}
}
