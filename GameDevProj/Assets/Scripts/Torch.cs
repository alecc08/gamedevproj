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
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void interact()
    {
        Debug.Log("Torch is being interacted with");
        torchlight.enabled = !torchlight.enabled;
        if(flame.isPlaying)
        {
            flame.Stop();
        }
        else
        {
            flame.Play();
        }
        
    }
}
