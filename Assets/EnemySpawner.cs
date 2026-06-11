using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;

    public float spawnInterval = 2f;
    public float spawnDistance = 8f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector2 spawnPos = GetRandomPositionAroundPlayer();

        GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        // 👉 передаём игрока каждому новому врагу
        enemy.GetComponent<EnemyFollow>().player = player;
    }

    Vector2 GetRandomPositionAroundPlayer()
    {
        float angle = Random.Range(0f, 360f);
        Vector2 dir = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        return (Vector2)player.position + dir * spawnDistance;
    }
}