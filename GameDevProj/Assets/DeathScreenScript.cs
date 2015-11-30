using UnityEngine;
using System.Collections;

public class DeathScreenScript : MonoBehaviour {

    public GameObject skull;

    bool loading = false;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if(skull != null)
        {
            skull.transform.Rotate(new Vector3(0.0f, 0.0f, 5f * Time.deltaTime));
        }
        if(Input.anyKey && !loading && Time.timeSinceLevelLoad > 2.0f)
        {
            loading = true;
            Application.LoadLevel(GameConstants.LOADING);
        }
	}
}
