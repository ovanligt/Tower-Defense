using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float Speed = 50f;
    

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;

        }
        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = Speed * Time.deltaTime;
        if (direction.magnitude < distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(direction.normalized * distanceThisFrame , Space.World);


    }

    private void HitTarget()
    {
        Destroy(gameObject);
    }

    public void SeekTarget(Transform _target)
    {
        target = _target;

        
    }


}
