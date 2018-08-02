// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class CameraSwitchBetween4EditorTarget : TargetRules
{
	public CameraSwitchBetween4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "CameraSwitchBetween4" } );
	}
}
