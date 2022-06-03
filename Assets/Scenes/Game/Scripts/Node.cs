using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color enterColor;
    private Vector3 positionOffset;
    public GameObject _turret;

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
        _renderer.material.color = enterColor;
    }
    private void OnMouseExit()
    {
        _renderer.material.color = _defoltColor;
    }
}
