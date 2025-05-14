using UnityEngine;

public class ContinueGame : MonoBehaviour
{
    public GameObject pauseMenu;
    public void PauseButton()
    {
        pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
    }
}
