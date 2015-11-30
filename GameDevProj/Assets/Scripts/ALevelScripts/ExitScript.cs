using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class ExitScript : MonoBehaviour, Interactable {

    public void interact(GameObject player)
    {
        PlayerPrefs.SetString(GameConstants.GET_SCENE_TO_LOAD, "FinalScene");
        Application.LoadLevel(GameConstants.LOADING);
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
