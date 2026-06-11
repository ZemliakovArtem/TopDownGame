using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int hp = 3;

    public GameObject gameOverUI;

    private bool isDead = false;

    void Update()
    {
        if (isDead && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Die()
    {
        isDead = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void TakeDamage(int dmg)
    {
        if (isDead) return;

        hp -= dmg;

        Debug.Log("HP: " + hp);

        if (hp <= 0)
        {
            Die();
        }
    }
}