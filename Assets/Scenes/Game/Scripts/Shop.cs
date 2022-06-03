using UnityEngine;

public class Shop : MonoBehaviour
{
    private BuildMaster _buildMaster;
    //public GameObject StandartTurretPrefab;

    private void Start()
    {
        _buildMaster = BuildMaster.instance;
    }

    public void BuildDefoltTurret()
    {

        _buildMaster.BuildTorret(_buildMaster.StandartTurretPrefab);
    }
}
