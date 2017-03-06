using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{

    // Use this for restart models
    public void restartbutton()
    {
        SceneManager.LoadScene("Level1");
        T_RegCmdCtrl.gameWon = false;
    }
}