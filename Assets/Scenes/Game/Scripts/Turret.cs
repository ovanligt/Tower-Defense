using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform _partToRate;
    public float RangeAttack = 15f;
    public string EnemyTag = "Enemy";

    [SerializeField]private Transform _target;
    private void Start()
    {
        InvokeRepeating("UpdateTarget" , 0f , 0.5f);
    }
    private void Update()
    {
        if (_target == null) return;

        Vector3 Dir = _target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(Dir);
        Vector3 Rotation = lookRotation.eulerAngles;
        _partToRate.rotation = Quaternion.Euler(-90f , Rotation.y+90 , -90f);
         
    }
    private void UpdateTarget()
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag(EnemyTag);
        float ShortestDistance = Mathf.Infinity;
        GameObject NearestEnemy = null;
        foreach (GameObject enemy   in Enemies)
        {
            float DistanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (DistanceToEnemy <= ShortestDistance) 
            {
                ShortestDistance = DistanceToEnemy;
                NearestEnemy = enemy;
            }
        }
        if (NearestEnemy != null && ShortestDistance <= RangeAttack)
        {
            _target = NearestEnemy.transform;
        }
        else
        {
            _target = null;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position , RangeAttack);

    }


}
