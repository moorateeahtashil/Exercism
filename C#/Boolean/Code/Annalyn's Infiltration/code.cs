using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
    return knightIsAwake || archerIsAwake || prisonerIsAwake;

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
    return !archerIsAwake && prisonerIsAwake;

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
    if (petDogIsPresent)
    {
        return !archerIsAwake;
    }
    // If Annalyn doesn't have her pet dog, she can free the prisoner if the prisoner is awake and both the knight and archer are asleep
    else
    {
        return !knightIsAwake && !archerIsAwake && prisonerIsAwake;
    }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
