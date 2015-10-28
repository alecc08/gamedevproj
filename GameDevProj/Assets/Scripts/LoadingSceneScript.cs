using UnityEngine;
using System.Collections;

public class LoadingSceneScript : MonoBehaviour
{

    float timeSinceLoad = 0.0f;
    void Start()
    {
        StartCoroutine(waitThenLoad(5));
       
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLoad += Time.deltaTime;
        if(timeSinceLoad > 3.0f)
        {
            Application.LoadLevelAsync(PlayerPrefs.GetString(GameConstants.GET_SCENE_TO_LOAD));
        }
        
    }

    IEnumerator waitThenLoad(int seconds)
    {
        yield return new WaitForSeconds(5);

        loadLevel();
        
    }

    IEnumerator loadLevel()
    {
        AsyncOperation async = Application.LoadLevelAsync(PlayerPrefs.GetString(GameConstants.GET_SCENE_TO_LOAD));
        yield return async;
    }




}
