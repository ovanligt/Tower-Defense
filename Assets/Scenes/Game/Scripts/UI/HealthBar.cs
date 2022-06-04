using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public TMP_Text LivesText;

    private void Update()
    {
        LivesText.text = PlayerParameters.Lives.ToString() + " Lives";
    }

}
