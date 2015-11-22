using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityStandardAssets.ImageEffects;

public class SanitySystem {

    private static UnityStandardAssets.ImageEffects.MotionBlur motionBlur;

    private static int currentInsanityLevel = 0;

    private const int MAX_INSANITY = 1000;

    private static MainCharacterScript mainCharScript;

    public static void init(MainCharacterScript mainCharacter)
    {
        mainCharScript = mainCharacter;
        motionBlur = GameObject.Find("CenterEyeAnchor").GetComponentInChildren<UnityStandardAssets.ImageEffects.MotionBlur>();
        currentInsanityLevel = 0;
    }


    public static float getInsanityLevel()
    {
        return (float)currentInsanityLevel / MAX_INSANITY;
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
        motionBlur.blurAmount = getInsanityLevel();
        if (getInsanityLevel() > 0.9f)
        {
            mainCharScript.activateGhouls();
        }
        else
        {
            mainCharScript.deactivateGhouls();
        }
    }
}
