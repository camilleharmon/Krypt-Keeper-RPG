using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Vector2 leftSpawnPoint;
    public Vector2 rightSpawnPoint;

    void Start()
    {
        string entry = PlayerPrefs.GetString("LastEntry", "Right"); // Default

        if (entry == "Left")
        {
            transform.position = leftSpawnPoint;
        }
        else if (entry == "Right")
        {
            transform.position = rightSpawnPoint;
        }
    }
}
