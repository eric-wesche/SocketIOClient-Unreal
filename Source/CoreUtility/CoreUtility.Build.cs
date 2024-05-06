// Copyright 2018-current Getnamo. All Rights Reserved


using UnrealBuildTool;
using System.IO;

public class CoreUtility : ModuleRules
{
    public CoreUtility(ReadOnlyTargetRules Target) : base(Target)
    {
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PrecompileForTargets = PrecompileTargetsType.Any;

		PublicIncludePaths.AddRange(
            new string[] {
				Path.Combine(ModuleDirectory, "Public"),
			}
            );


        PrivateIncludePaths.AddRange(
            new string[] {
				Path.Combine(ModuleDirectory, "Private"),
            }
            );


        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core"
            }
            );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
				"RHI",
				"RenderCore",
				"libOpus",
				"UEOgg",
                "OpusAudioDecoder"
			}
            );


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
            }
            );
    }
}
