using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScreen : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {

            
            Invoke("DelayLoad", 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            if (Application.isEditor)
                EditorApplication.isPlaying = false;
            else
#endif
                Application.Quit();
        }
    }


    void DelayLoad()
    {
        SceneManager.LoadScene(1);
    }
}

