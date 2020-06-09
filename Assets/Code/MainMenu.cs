using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(int index){

        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(index).buildIndex + 1);

    }

    public void QuitGame(){
        
        Debug.Log("Quit!");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
