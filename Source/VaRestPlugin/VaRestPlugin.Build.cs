// Copyright 2014 Vladimir Alyamkin. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class VaRestPlugin : ModuleRules
	{
		public VaRestPlugin(ReadOnlyTargetRules Target) : base(Target)
		{
            PrivateIncludePaths.AddRange(
				new string[] {
					"VaRestPlugin/Private",
					// ... add other private include paths required here ...
				});

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"Engine",
                    "HTTP",
                    "Json"
					// ... add other public dependencies that you statically link with here ...
				});
		}
	}
}