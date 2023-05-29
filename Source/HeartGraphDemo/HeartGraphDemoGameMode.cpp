// Copyright Epic Games, Inc. All Rights Reserved.

#include "HeartGraphDemoGameMode.h"
#include "HeartGraphDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AHeartGraphDemoGameMode::AHeartGraphDemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
