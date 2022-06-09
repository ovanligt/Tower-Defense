using UnityEngine;
using TMPro;

public class LivesCounter : MonoBehaviour
{
    public TMP_Text LivesText;

    private void Update()
    {
        LivesText.text = PlayerParameters.Lives.ToString() + " LIVES";
    }
}
