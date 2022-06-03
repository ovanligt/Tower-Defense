using System;
using UnityEngine;

public class BuildMaster : MonoBehaviour
{
    public static BuildMaster instance;
    public GameObject StandartTurretPrefab;
    public bool CanBuild { get { return _turretToBuild != null; } }

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
        GameObject turret = (GameObject)Instantiate(_turretToBuild.Prefab,
            node.transform.position, node.transform.rotation);
        node._turret = turret;
    }

    public void SelectTurretToBuild(TurretBlueprint turret) 
    {
        _turretToBuild = turret;
    }

    
}
