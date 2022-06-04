using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 3f;

    public float Health = 100f;
    private Transform _target;
    private int _wavepointIndex = 0;

    public void TakeDamage(int damage) 
    {
        Health -= damage;

        if (Health <= 0)
        {
            EnemyDie();
        }
    }
    private void EnemyDie() 
    {
        PlayerParameters.Money += 10;
        Destroy(gameObject);
    }

    private void Start() 
    {
        _target = Waypoint.points[0];
    }

    private void Update() 
    {
        Move();
    }

    private void Move()
    {
                Vector3 direction = _target.position - transform.position;
        transform.Translate(direction.normalized * Speed * Time.deltaTime , Space.World);   

        if (Vector3.Distance(transform.position , _target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if (_wavepointIndex >= Waypoint.points.Length - 1)
        {
            LastPath();
            return;
        }
        _wavepointIndex ++;
        _target = Waypoint.points[_wavepointIndex];
    }

    private void LastPath() 
    {
        PlayerParameters.Lives--;
        Destroy(gameObject);
    }

    
}
