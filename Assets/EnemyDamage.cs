using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public float damageInterval = 1f;

    private float lastDamageTime;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Time.time - lastDamageTime >= damageInterval)
            {
                PlayerHealth ph = other.GetComponent<PlayerHealth>();

                if (ph != null)
                {
                    ph.TakeDamage(damage);
                }

                lastDamageTime = Time.time;
            }
        }
    }
}