using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class TutorialDoorReadable : MonoBehaviour, Readable {
    public string GetText()
    {
        return "Damn it I lost the key again... I need to stop playing around in those weird mushrooms";
    }

}
