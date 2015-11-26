using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class Generator : MonoBehaviour, Interactable {

    AudioSource chargeSound;

    Light statusLight;

    bool generatorUsed = false;

    public void interact(GameObject player)
    {
        if(!generatorUsed)
        {
            player.GetComponent<MainCharacterScript>().rechargeBattery();
            chargeSound.Play();
            generatorUsed = true;
            statusLight.color = Color.red;
            
        }
        
    }

    public bool isInteractable()
    {
        return !generatorUsed;
    }

    // Use this for initialization
    void Start () {
        chargeSound = GetComponent<AudioSource>();
        statusLight = GetComponentInChildren<Light>(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public string getLabel()
    {
        return "Recharge Flashlight";
    }
}
