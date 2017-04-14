using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string nextScene;

    //Restart current scene
    public void restartbutton()
    {    
        Application.LoadLevel(Application.loadedLevel);
        T_RegCmdCtrl.gameWon = false;
    }

    //Load next scene
    public void loadNextScene()
    {
        Application.LoadLevel(nextScene);
        T_RegCmdCtrl.gameWon = false;
    }


}