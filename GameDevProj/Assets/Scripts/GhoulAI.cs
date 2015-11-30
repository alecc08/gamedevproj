using UnityEngine;
using System.Collections;

public class GhoulAI : MonoBehaviour {

    Animator animator;
    GameObject mainCharacter;
    float timeSinceDeath = 0.0f;
    bool isDead = false;

    AudioSource growlSound;

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();
        mainCharacter = GameObject.Find("MainCharacter");
        growlSound = GameObject.Find("growl").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 deltaPos = mainCharacter.transform.position - transform.position;
        if(deltaPos.magnitude < 200.0f)
        {
            if (Random.Range(0, 1000) == 0)
            {
                if (!growlSound.isPlaying)
                {
                    growlSound.Play();
                }

            }

            deltaPos = new Vector3(deltaPos.x, 0, deltaPos.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(deltaPos, Vector3.up), Time.deltaTime);
            if (deltaPos.magnitude > (1000.0f * (1.0f - SanitySystem.getInsanityLevel())))
            {
                Vector3 movement = deltaPos.normalized * Time.deltaTime;
                transform.position += movement;
                animator.SetBool("isRunning", true);


            }
            else
            {
                animator.SetBool("isRunning", false);
            }
        }
        
	}

    public void disappear()
    {
        if(!isDead)
        {
            isDead = true;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("MainCharacter"))
        {
            collision.gameObject.GetComponentInChildren<MainCharacterScript>().die();
        }
    }
}
