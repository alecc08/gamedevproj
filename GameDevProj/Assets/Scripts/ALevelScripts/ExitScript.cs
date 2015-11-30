using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class ExitScript : MonoBehaviour, Interactable {

    public void interact(GameObject player)
    { 
        //go to next level
    }

    public string getLabel()
    {
        return "Open";
    }

    public bool isInteractable()
    {
        return true;
    }
	
}
