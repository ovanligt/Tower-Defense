using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParameters : MonoBehaviour
{
    public static int Money;
    public int StartMoney = 400;

    private void Start()
    {
        Money = StartMoney;
    }

}
