using TMPro;
using UnityEngine;

public class Convo_Lady : MonoBehaviour
{
    public TMP_Text tmpTextLady;
    public TMP_Text tmpTextPlayer;

    public string[] responsesL;
    public string[] responsesP;

    public ConvoCount convoCount;

    public GameObject choice;

    public GameObject input1;
    public GameObject input2;

    public GameObject ladyResponse;


    public void ChangeText()
    {
        if (tmpTextLady != null)
        {
            if (choice.Equals(input1) && convoCount.count == 0)
            {
                //Find them quickly! How can I mourn an empty grave?
                tmpTextLady.text = responsesL[0];
                tmpTextLady.fontSize = 0.3F;
                //I'm on it!
                tmpTextPlayer.text = responsesP[0];
                hide(input2);
                convoCount.count++;
            }
            else if (choice.Equals(input2) && convoCount.count == 0) 
            {
                //But it's your job to care!
                tmpTextLady.text = responsesL[1];
                tmpTextLady.fontSize = 0.4F;
                //I'm quitting gravekeeping.
                tmpTextPlayer.text = responsesP[1];
                hide(input2);
                convoCount.count++;
            }
            else
            {
                hide(input1);
                hide(ladyResponse);
            }
        }
    }

    private void hide(GameObject objectToHide)
    {
        if (objectToHide != null)
        {
            objectToHide.SetActive(false);
        }
    }
}
