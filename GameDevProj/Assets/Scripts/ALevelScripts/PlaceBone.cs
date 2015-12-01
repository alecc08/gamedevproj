using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class PlaceBone : MonoBehaviour, Interactable {

    bool placed;
    public bool hasBone;

    GameObject bone;
    
    // Use this for initialization
	void Start () {
        placed = false;
        hasBone = false;
        bone = GameObject.Find("DasBone");
        bone.SetActive(false);
	}

    public void interact(GameObject player)
    {
        if (hasBone && !placed)
        {
            placed = true;
            
            bone.SetActive(true);
        }
        else if(!hasBone && !placed)
        {
            player.GetComponent<MainCharacterScript>().setHint("There's room for something to be inserted in this button.. maybe I can find something...");
        }
    }

    public string getLabel()
    {
        if (!placed)
        {
            if (!hasBone)
                return "?";
            else
                return "Place bone";
        }
        else
            return "";
    }

    public bool isInteractable()
    {
        return !placed;
    }
}
