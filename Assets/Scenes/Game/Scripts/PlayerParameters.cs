using UnityEngine;

public class PlayerParameters : MonoBehaviour
{
    public static int Money;
    public int StartMoney = 100;

    public static int Lives;
    public int StartLives = 2;

    public static int WaveSurv;

    private void Start()
    {
        Money = StartMoney;
        Lives = StartLives;

        WaveSurv = 0;
    }

}
