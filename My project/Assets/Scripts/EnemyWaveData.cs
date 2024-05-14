using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyWaveData", menuName = "Wave Data")]
public class EnemyWaveData : ScriptableObject
{
    [Tooltip("Los prefabs de enemigos que se generarán")]
    public GameObject[] enemyPrefabs;

    [Tooltip("La cantidad de enemigos por oleada")]
    public int numberOfEnemies;

    [Tooltip("El área de generación en 3D")]
    public Vector3 spawnArea;

    [Tooltip("La velocidad de movimiento de los enemigos")]
    public float moveSpeed = 5f;
}
