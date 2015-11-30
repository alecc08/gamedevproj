using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class TutorialKeyScript : MonoBehaviour, Interactable {
    public string getLabel()
    {
        return "Pick up key";
    }

    public void interact(GameObject player)
    {
        TutorialLevelDoor.locked = false;
        Destroy(this.gameObject);
        //Play key noise
    }

    public bool isInteractable()
    {
        return true;
    }
    
}
