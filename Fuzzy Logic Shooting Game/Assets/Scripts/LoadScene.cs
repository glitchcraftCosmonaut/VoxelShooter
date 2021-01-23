using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public float loadDelay = 3f;
    public int nextSceneLoad;
    private void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void Update()
    {
        Invoke("LoadNextScene",loadDelay);
        LoadNextScene();
    }
    public void LoadNextScene()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene(nextSceneLoad);
            if(nextSceneLoad > PlayerPrefs .GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt",nextSceneLoad);
            }
        }
    }
}
