using UnityEngine;
using System.Collections;

public class LoadingScript : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0.0f, 5f * Time.deltaTime, 0.0f));
	}
}
