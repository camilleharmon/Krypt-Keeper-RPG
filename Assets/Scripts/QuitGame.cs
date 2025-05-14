using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    private string sceneName = "Town";

    public void QuitButton()
    {
        Application.Quit();

        Debug.Log("Game has been quit.");
    }
}
