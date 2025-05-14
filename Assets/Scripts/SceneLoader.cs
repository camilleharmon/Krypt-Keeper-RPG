using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    public enum EntryDirection { Left, Right }
    public EntryDirection entryDirection;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger entered");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            SceneManager.LoadScene(sceneName);

            PlayerPrefs.SetString("LastEntry", entryDirection.ToString());
        }
    }
   }
