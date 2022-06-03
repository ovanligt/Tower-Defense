using System;
using UnityEngine;

public class BuildMaster : MonoBehaviour
{
    public static BuildMaster instance;
    public GameObject StandartTurretPrefab;
    public bool CanBuild { get { return _turretToBuild != null; } }
    public bool HasMoney { get { return PlayerParameters.Money >= _turretToBuild.TurretCost; } }

    private TurretBlueprint _turretToBuild;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log(" More than one Build Manager");
            return;
        }
        instance = this; 
    }
    

    public void BuildTurretOn(Node node) 
    {
        if (PlayerParameters.Money < _turretToBuild.TurretCost)
        {
            Debug.Log("no money");
            return;
        }

        PlayerParameters.Money -= _turretToBuild.TurretCost;

        GameObject turret = (GameObject)Instantiate(_turretToBuild.Prefab,
            node.transform.position, node.transform.rotation);
        node._turret = turret;
        Debug.Log("Your building turrel " + PlayerParameters.Money);
    }

    public void SelectTurretToBuild(TurretBlueprint turret) 
    {
        _turretToBuild = turret;
    }

    
}
