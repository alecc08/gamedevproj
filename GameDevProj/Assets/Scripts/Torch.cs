using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Torch : MonoBehaviour, Interactable {

    Light torchlight;
    ParticleSystem flame;
	// Use this for initialization
	void Start () {
        torchlight = GetComponentInChildren<Light>();
        flame = GetComponentInChildren<ParticleSystem>();
        flame.playbackSpeed = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void interact(GameObject player)
    {
        Debug.Log("Torch is being interacted with");
        if(flame.isPlaying)
        {
            torchlight.enabled = false;
            flame.Stop();
        }
        else
        {
            torchlight.enabled = true;
            flame.Play();
            
        }
        
    }
}
