using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private string sceneName = "Town";

    public void PlayButton()
    {
        SceneManager.LoadScene(sceneName);
    }
}
