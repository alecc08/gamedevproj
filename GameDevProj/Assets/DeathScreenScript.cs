using UnityEngine;
using System.Collections;

public class DeathScreenScript : MonoBehaviour {

    public GameObject skull;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if(skull != null)
        {
            skull.transform.Rotate(new Vector3(0.0f, 0.0f, 5f * Time.deltaTime));
        }
	}
}
