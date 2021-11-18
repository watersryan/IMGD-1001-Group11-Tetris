using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public static int SceneNumber;
    void Start()
    {
        if(SceneNumber == 0)
        {
            StartCoroutine(ToTitleScreen());
        }
    }

    IEnumerator ToTitleScreen()
    {
        yield return new WaitForSeconds(3);
        SceneNumber = 2;
        SceneManager.LoadScene(2);
    }
}
