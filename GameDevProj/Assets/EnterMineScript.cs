using UnityEngine;
using System.Collections;

public class EnterMineScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetString(GameConstants.GET_SCENE_TO_LOAD, "Level1");
        Application.LoadLevel(GameConstants.LOADING);
    }
}
