using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    public Text MoneyText;

    void Update()
    {
        MoneyText.text = PlayerParameters.Money.ToString() + " Coins";
    }
}
