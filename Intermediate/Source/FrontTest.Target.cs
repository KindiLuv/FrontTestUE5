using UnrealBuildTool;

public class FrontTestTarget : TargetRules
{
	public FrontTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FrontTest");
	}
}
