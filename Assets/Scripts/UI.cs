using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject pauseMenu;
    public void PauseButton()
    {
        pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
    }
}
