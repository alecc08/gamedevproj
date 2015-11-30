using UnityEngine;
using System.Collections;

public class FinalLevelRoomHints
{
    static int numberOfMessagesRead = 0;
    static string[] messages =
    {
        "All of a sudden I started to remember...",
        "My daughter was murdered 20 years ago...",
        "And her killer was me. I've been trying to escape this place for years...",
        "Each time I forget my past and hallucinate this horrible nightmare as I escape.",
        "Each time I run into the cave, and they always catch me when I come out",
        "I have a feeling this is the last time I'll be able to get free..."

    };

    public static void Begin(MainCharacterScript mainChar)
    {
        while(numberOfMessagesRead < messages.Length)
        {
            if(!mainChar.hintDisplayed())
            {
                mainChar.setHint(messages[numberOfMessagesRead++]);
            }
        }
        
        while(mainChar.hintDisplayed())
        {
            //wait until done reading
        }

        Application.LoadLevel("Credits");
    }
    
}
