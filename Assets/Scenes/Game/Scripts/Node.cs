using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color enterColor;

    private GameObject _turret;
    private BuildMaster _buildMaster;
    private new Renderer _renderer ;
    private Color _defoltColor;

    private void Start()
    {
        _buildMaster = BuildMaster.instance;
        _renderer = GetComponent<Renderer>();
        _defoltColor = _renderer.material.color;

    }
    private void OnMouseDown()
    {

        if (_buildMaster.GetTurretToBuild() == null)
            return;

        if (_turret != null)
        {
            Debug.Log("Error building");
            return;  
        }

        GameObject _turretToBuild = _buildMaster.GetTurretToBuild();
        _turret = (GameObject)Instantiate(_turretToBuild, transform.position, transform.rotation);



    }

    private void OnMouseEnter()
    {
        if (_buildMaster.GetTurretToBuild() == null)
        { return; }
        _renderer.material.color = enterColor;
    }
    private void OnMouseExit()
    {
        _renderer.material.color = _defoltColor;
    }
}
