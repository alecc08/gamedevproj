using UnityEngine;
using System.Collections;

public class SanitySystem {

    private static int currentInsanityLevel = 0;

    private const int MAX_INSANITY = 1000;

	public static void init()
    {
        currentInsanityLevel = 0;
    }

    public static float getInsanityLevelPercent()
    {
        return currentInsanityLevel / MAX_INSANITY;
    }

    public static void increaseInsanity(int amount)
    {
        currentInsanityLevel += amount;
        if(currentInsanityLevel > MAX_INSANITY)
        {
            currentInsanityLevel = MAX_INSANITY;
        }
    }

    public static void decreaseInsanity(int amount)
    {
        currentInsanityLevel -= amount;
        if(currentInsanityLevel < 0)
        {
            currentInsanityLevel = 0;
        }
    }
}
