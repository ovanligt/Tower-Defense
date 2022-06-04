using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bullet : MonoBehaviour
{

    public float Speed = 50f;
    private Transform _target;
    public int explosionRadius = 1;
    public GameObject impactEffect;
    private int rDamage ;


    private void Start()
    {
        rDamage = Random.Range(23, 28);
    }
    private void Update()
    {
        if (_target == null)
        {
            Destroy(gameObject);
            return;

        }
        Vector3 direction = _target.position - transform.position;
        float distanceThisFrame = Speed * Time.deltaTime;

        if (direction.magnitude < distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(direction.normalized * distanceThisFrame , Space.World);

        Debug.Log(rDamage);
    }
    

    private void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect,transform.position, transform.rotation);
        Destroy(effectIns, 5f);

        if (explosionRadius > 0f)
        {
            Explode();
        }
        else
        {
            Damage(_target);
        }

        Destroy(gameObject);
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }

    private void Damage(Transform enemy)
    {
        Enemy en = enemy.GetComponent<Enemy>();
        if (en != null )
        {
            en.TakeDamage(rDamage);
        }
    }

    public void SeekTarget(Transform target)
    {
        _target = target;      
    }


}
