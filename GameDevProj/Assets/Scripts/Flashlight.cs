using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

    float batterylevel = 1.0f;

    const float TOTAL_BATTERY_LIFETIME = 180.0f;

    bool flickering = false;
    public bool lightEnabled = true;

    float minFlickerSpeed = 0.01f;
    float maxFlickerSpeed = 0.1f;

    float initialIntensity;
    float initialRange;

    float minFlickerDelay = 2.0f;
    float timeSinceFlicker = 0.0f;
    

    Light flashLight;

	// Use this for initialization
	void Start () {
        flashLight = GetComponentInChildren<Light>();
        initialIntensity = flashLight.intensity;
        initialRange = flashLight.range;
	}
	
	// Update is called once per frame
	void Update () {
        if(lightEnabled && batterylevel > 0.0f)
        {
            batterylevel -= Time.deltaTime / TOTAL_BATTERY_LIFETIME;

            //flashLight.range = initialRange * batterylevel;
            flashLight.intensity = initialIntensity * batterylevel;

            if (flickering && timeSinceFlicker >= minFlickerDelay)
            {
                timeSinceFlicker = 0.0f;
                StartCoroutine(Flicker());
                flickering = false;
            }
            else
            {
                timeSinceFlicker += Time.deltaTime;
                flickering = (Random.Range(0.0f, 1.0f) / batterylevel > 2.0f);
            }
        }
        else
        {
            lightEnabled = false;
            flashLight.enabled = false;
        }
    }

    public void toggleLight()
    {
        if(lightEnabled)
        {
            lightEnabled = false;
            flashLight.enabled = false;
        }
        else
        {
            lightEnabled = true;
            flashLight.enabled = true;
        }
    }

    
 
    IEnumerator Flicker()
    {
        flashLight.enabled = false;
        yield return new WaitForSeconds (Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = true;
        yield return new WaitForSeconds (Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = false;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
        flashLight.enabled = true;
        yield return new WaitForSeconds(Random.Range(minFlickerSpeed, maxFlickerSpeed));
    }

    public void replenishBattery()
    {
        this.batterylevel = 1.0f;
    }
}
