using UnityEngine;
using System.Collections;

public class hingeScript : MonoBehaviour {

    public bool activated;
    
    // Use this for initialization
	void Start () {
        activated = false;
        transform.Rotate(Vector3.forward, 75f);
	}
	
	// Update is called once per frame
	void Update () {
        if (activated)
        {
           transform.Rotate(Vector3.forward, -(40 * Time.deltaTime)); 
        }
	}

    
}
