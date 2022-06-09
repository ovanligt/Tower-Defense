using System;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public string EnemyTag = "Enemy";

    public Transform _enemyPrefab;
    [SerializeField]private Transform _partToRate;
    private float _rangeVision = 15f;

    public float _fireRate = 1;
    public float _fireCountdown = 0;
    public GameObject bulletPrefab;
    public Transform fitePoint;

    private void Start()
    {
        InvokeRepeating("SearchingTarget", 0f , 0.5f);
    }

    private void Update()
    {
        TrackingTarget();
        SoottingCounter();
    }

    private void SoottingCounter() 
    {
        if (_fireCountdown <= 0)
        {
            Shoot();
            _fireCountdown = 1f / _fireRate;
        }
        _fireCountdown -= Time.deltaTime;
    }

    private void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, fitePoint.position , fitePoint.rotation);
        Bullet bullet = bulletGo.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.SeekTarget(_enemyPrefab);
        }
    }

    public void SearchingTarget()
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag(EnemyTag);
        float ShortestDistance = Mathf.Infinity;
        GameObject NearestEnemy = null;
        foreach (GameObject enemy in Enemies)
        {
            float DistanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (DistanceToEnemy <= ShortestDistance)
            {
                ShortestDistance = DistanceToEnemy;
                NearestEnemy = enemy;
            }
        }
        if (NearestEnemy != null && ShortestDistance <= _rangeVision)
        {
            _enemyPrefab = NearestEnemy.transform;
        }
        else
        {
            _enemyPrefab = null;
        }
    }
    private void TrackingTarget() 
    {
        if (_enemyPrefab == null) return;

        Vector3 Direction = _enemyPrefab.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(Direction);
        Vector3 rotation = Quaternion.Lerp(_partToRate.rotation, lookRotation, Time.deltaTime * 5).eulerAngles; ;
        _partToRate.rotation = Quaternion.Euler(-90f, rotation.y + 90, -90f);
    }

    


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position , _rangeVision);
    }


}
