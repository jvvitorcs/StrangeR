using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int timeToWait = 2;
    public int currentSceneIndex;
    private Animator anim;
    public GameObject blackScreen;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        anim = blackScreen.GetComponent<Animator>();
        anim.SetBool("Fade", true);
        //if (currentSceneIndex == 1)
        //{
        //    StartCoroutine(WaitAndLoad());
        //}
    }   
   
    // Espera a splash Screen carregar
    IEnumerator WaitAndLoad()
    {
        anim.SetBool("Fade", false);
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(currentSceneIndex + 1);
        //LoadNextScene(); 
    }

    public void LoadNextScene()
    {
        StartCoroutine(WaitAndLoad());
        //SceneManager.LoadScene(currentSceneIndex + 1);        
    }

    public void LoadLastScreen()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void End()
    {
        Application.Quit();
    }

   


}
