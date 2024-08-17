using UnityEngine;
using System.Collections;

public class EnemyWaveManager : MonoBehaviour
{
    public EnemyWaveData waveData;
    public float waveInterval = 5f;

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        StartCoroutine(SpawnEnemyWaves());
    }

    private IEnumerator SpawnEnemyWaves()
    {
        while (true)
        {
            SpawnEnemyWave();

            yield return new WaitForSeconds(waveInterval);
        }
    }

    private void SpawnEnemyWave()
    {
        for (int i = 0; i < waveData.numberOfEnemies; i++)
        {
            GameObject randomEnemyPrefab = waveData.enemyPrefabs[Random.Range(0, waveData.enemyPrefabs.Length)];

            Vector3 randomPosition = new Vector3(
                Random.Range(-waveData.spawnArea.x, waveData.spawnArea.x),
                Random.Range(-waveData.spawnArea.y, waveData.spawnArea.y),
                Random.Range(-waveData.spawnArea.z, waveData.spawnArea.z)
            );

            // Calcular la rotación para que el GameObject "SpawnEnemy" apunte al jugador
            Quaternion lookRotation = Quaternion.LookRotation(player.position - randomPosition);

            // Invertir la dirección frontal del GameObject "SpawnEnemy"
            lookRotation *= Quaternion.Euler(0f, 180f, 0f);

            // Instanciar el prefab "SpawnEnemy" con la rotación correcta
            GameObject spawnEnemy = Instantiate(randomEnemyPrefab, randomPosition, lookRotation);
        }
    }
}
