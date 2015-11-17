using UnityEngine;
using System.Collections;

public class ScreamCollider : MonoBehaviour {

    // Reference to audio sources
    AudioSource mScream;
    
    bool check;

	// Use this for initialization
	void Start () {
	    mScream = GetComponent<AudioSource>();
        check = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (check == true)
        {
            check = false;
            mScream.Play();
            Destroy(GameObject.FindWithTag("Sarah"));
        }
        

    }

}
