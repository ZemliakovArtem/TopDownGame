using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int hp = 3;

    public void TakeDamage(int damage)
    {
        hp -= damage;

        Debug.Log("Enemy HP: " + hp);

        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}