using System;
using UnityEngine;

public class BuildMaster : MonoBehaviour
{
    public static BuildMaster instance;
    public GameObject StandartTurretPrefab;

    //public GameObject AnotherTurretPrefab;

    private GameObject _turretToBuild;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log(" More than one Build Manager");
            return;
        }
        instance = this; 
    }

    public GameObject GetTurretToBuild() 
    {
        return _turretToBuild; 
    }

    public void BuildTorret(GameObject turret) 
    {
        _turretToBuild = turret;
    }

    
}
