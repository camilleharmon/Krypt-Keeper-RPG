using UnityEngine;

public class Start_Convo : MonoBehaviour
{
    public GameObject convo;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!convo.activeInHierarchy)
            {
                convo.SetActive(!convo.activeInHierarchy);
            }
        }
    }
}
