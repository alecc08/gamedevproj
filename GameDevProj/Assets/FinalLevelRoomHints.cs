using UnityEngine;
using System.Collections;

public class FinalLevelRoomHints : MonoBehaviour
{
    public static bool begin = false;
    MainCharacterScript mainChar;
    ParticleSystem taserSystem;
    AudioSource electricSound;

    float shockTime = 0.0f;

    static int numberOfMessagesRead = 0;
    static string[] messages =
    {
        "All of a sudden I started to remember...",
        "My daughter was murdered 20 years ago...",
        "And I was the murderer...",
        "I've been trying to escape this place for years...",
        "They warned me if I ever tried to escape again it'd be the last time",
        "Finally my suffering will come to an end...",
        "..."

    };

    public void Start()
    {
        mainChar = GameObject.Find("MainCharacter").GetComponentInChildren<MainCharacterScript>();
        taserSystem = GameObject.Find("TaserSystem").GetComponentInChildren<ParticleSystem>();
        electricSound = GameObject.Find("ElectricSound").GetComponentInChildren<AudioSource>();
    }

    public void Update()
    {
        mainChar.getSpotlight().lightEnabled = false;
        if(begin)
        {
            if (numberOfMessagesRead < messages.Length)
            {
                if (!mainChar.hintDisplayed())
                {
                    mainChar.setHint(messages[numberOfMessagesRead++]);
                }
            }
            else
            {
                if (!mainChar.hintDisplayed())
                {
                    if(!taserSystem.isPlaying)
                    {
                        taserSystem.Play();
                        electricSound.Play();
                    }
                    else
                    {
                        shockTime += Time.deltaTime;
                        if(shockTime > 4.0f)
                        {
                            Application.LoadLevel("Credits");
                        }
                    }
                    
                    
                }
            }
        }
        
    }


    
}
