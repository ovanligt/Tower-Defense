using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint StandartTurret;
    private BuildMaster _buildMaster;

    private void Start()
    {
        _buildMaster = BuildMaster.instance;
    }

    public void SelectDefoltTurret()
    {

        _buildMaster.SelectTurretToBuild(StandartTurret);
    }
}
