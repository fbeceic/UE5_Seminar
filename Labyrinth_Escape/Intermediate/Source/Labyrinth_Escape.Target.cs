using UnrealBuildTool;

public class Labyrinth_EscapeTarget : TargetRules
{
	public Labyrinth_EscapeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Labyrinth_Escape");
	}
}
