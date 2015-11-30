using UnityEngine;
using System.Collections;

public class nextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "MainCharacter")
        {
            Application.LoadLevel("ALevel");

        }
    }
}
