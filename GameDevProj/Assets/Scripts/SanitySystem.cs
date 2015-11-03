using UnityEngine;
using System.Collections;

public class SanitySystem {

    static MotionBlur motionBlur;

    private static int currentInsanityLevel = 0;

    private const int MAX_INSANITY = 1000;

	public static void init()
    {
        motionBlur = GameObject.Find("CenterEyeAnchor").GetComponentInChildren<MotionBlur>();
        currentInsanityLevel = 0;
    }


    public static float getInsanityLevel()
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
        UpdateEffects();
    }

    public static void decreaseInsanity(int amount)
    {
        currentInsanityLevel -= amount;
        if(currentInsanityLevel < 0)
        {
            currentInsanityLevel = 0;
        }
        UpdateEffects();
    }

    private static void UpdateEffects()
    {
        if(getInsanityLevel() > 0.6f)
        {
            motionBlur.blurAmount = getInsanityLevel();
        }
        else
        {
            motionBlur.blurAmount = 0.0f;
        }
    }
}
