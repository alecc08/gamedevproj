using UnityEngine;
using System.Collections;

public class TaserScript : MonoBehaviour
{
    AudioSource electricSound;
    ParticleSystem taserSystem;

    Transform teleportTo;

    bool triggered = false;
    float timeSinceTrigger = 0.0f;

    GameObject mainChar;

    // Use this for initialization
    void Start()
    {
        electricSound = GameObject.Find("ElectricSound").GetComponentInChildren<AudioSource>();
        taserSystem = GameObject.Find("TaserSystem").GetComponentInChildren<ParticleSystem>();
        mainChar = GameObject.Find("MainCharacter");
        teleportTo = GameObject.Find("TeleportTo").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(triggered)
        {
            timeSinceTrigger += Time.deltaTime;
            if(timeSinceTrigger > 3.0f)
            {
                //Teleport to room
                taserSystem.Stop();
                mainChar.GetComponentInChildren<Light>().enabled = false;

                mainChar.transform.position = teleportTo.position;
                mainChar.transform.rotation = teleportTo.rotation;

                Destroy(this);
            }
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(!triggered)
        {
            triggered = true;
            electricSound.Play();
            taserSystem.Play();
            mainChar.GetComponentInChildren<CharacterController>().enabled = false;
        }
        
    }
}
