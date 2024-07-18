using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
    void Update(){
          Cursor.lockState = CursorLockMode.None;
          Cursor.visible=true;
    }
    public void ReststartButton(string sceneToRestart){
        SceneManager.LoadScene(sceneToRestart);

    }
    public void ExitButton() {
        SceneManager.LoadScene("Main Menu");
    }

}
