using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color EnterColor;
    private Vector3 positionOffset;
    public GameObject _turret;

    private BuildMaster _buildMaster;
    private Renderer _renderer;
    private Color _defoltColor;
    private Color _NoMoneyColor;

    private void Start()
    {
        _buildMaster = BuildMaster.instance;
        _renderer = GetComponent<Renderer>();
        _defoltColor = _renderer.material.color;

    }
    private void OnMouseDown()
    {

        if (!_buildMaster.CanBuild)
            return;

        if (_turret != null)
        {
            Debug.Log("Error building");
            return;  
        }

        _buildMaster.BuildTurretOn(this);
    }

    public Vector3 GetBuildPosition() 
    {
        return transform.position ;
        //+positionOffset
    }

    private void OnMouseEnter()
    {
        if (!_buildMaster.CanBuild)
        { return; }

        if (_buildMaster.HasMoney)
        {
        _renderer.material.color = EnterColor;
        }
        else 
        {
            _renderer.material.color = _NoMoneyColor = new Color (1 , 0 , 0);
}


    }
    private void OnMouseExit()
    {
        _renderer.material.color = _defoltColor;
    }
}
