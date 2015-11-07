using UnrealBuildTool;
using System.Collections.Generic;

class DetailCustomizationEditorTarget : TargetRules
{
	public DetailCustomizationEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.Add("DetailCustomization");
	}

}