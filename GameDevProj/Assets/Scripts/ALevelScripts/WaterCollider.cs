using UnityEngine;
using System.Collections;

public class WaterCollider : MonoBehaviour {

    public Vector3 position;
    public Vector3 lookAt;
    
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
            GameObject player = other.gameObject;

            player.transform.position = position/*new Vector3(-15.56f, 11.68f, 12.34f)*/;

            player.transform.rotation.SetLookRotation(lookAt/*new Vector3(0, 299.355f, 0)*/);

            SanitySystem.increaseInsanity(2000);
            
        }
    }
}
