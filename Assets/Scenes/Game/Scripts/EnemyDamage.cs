using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 34;

    public void OnCollisionEnter(Collision collision)
    {

        GameObject _castle = collision.gameObject;
        Castle castle = _castle.GetComponent<Castle>();
        if (castle.CurrentHealth > 0)
        {
            castle.TakeDamage(damage);
            return;
        }
    }

}
