using UnityEngine;
using System.Collections;

public class WaterCollider : MonoBehaviour {
    
    
    
    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "MainCharacter")
        {
            other.gameObject.GetComponentInChildren<MainCharacterScript>().die();
            
        }
    }
}
