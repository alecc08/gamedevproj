using UnityEngine;
using System.Collections;

public class GhoulAI : MonoBehaviour {

    Animator animator;
    GameObject mainCharacter;
    float timeSinceDeath = 0.0f;
    bool isDead = false;

    AudioSource growlSound;
    AudioSource leftFoot;
    AudioSource rightFoot;

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();
        mainCharacter = GameObject.Find("MainCharacter");
        growlSound = GameObject.Find("growl").GetComponent<AudioSource>();
        leftFoot = GameObject.Find("step1").GetComponent<AudioSource>();
        rightFoot = GameObject.Find("step2").GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
        animator.SetBool("isDead", isDead);
        if (!isDead)
        {
            Vector3 deltaPos = mainCharacter.transform.position - transform.position;
            deltaPos = new Vector3(deltaPos.x, 0, deltaPos.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(deltaPos, Vector3.up), Time.deltaTime);
            if (deltaPos.magnitude < 200.0f && deltaPos.magnitude > (1000.0f * (1.0f -SanitySystem.getInsanityLevel())))
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
        else
        {
            timeSinceDeath += Time.deltaTime;
            if(timeSinceDeath > 4.0f)
            {
                Destroy(this.gameObject);
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
            growlSound.Play();
            Debug.Log("You dead biiitch...");
        }
    }
}
