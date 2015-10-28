using UnityEngine;
using System.Collections;

public class TitleSpin : MonoBehaviour {

    Vector3 initialPos;

    // Use this for initialization
    void Start () {
        initialPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    this.transform.position = initialPos + new Vector3(Mathf.Sin(Time.time*Mathf.PI)*0.1f,Mathf.Cos(Time.time*Mathf.PI)*0.1f,0f);
	}
}
