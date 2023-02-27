using UnrealBuildTool;

public class SlendermanishTarget : TargetRules
{
	public SlendermanishTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Slendermanish");
	}
}
