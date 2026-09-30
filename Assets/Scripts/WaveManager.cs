using UnityEngine;

public class WaveManager : MonoBehaviour
{
    private int currentWave;
    private int enemyCount;
    [SerializeField] private float intervalBetweenWaves;
    [SerializeField] private float enemySpawnDelay;
    [SerializeField] private EnemySpawner spawner;

    private void Start()
    {
        WaveStart();
    }

    private void WaveStart()
    {
        currentWave += 1;

        spawner.SpawnEnemy(1, enemySpawnDelay);
        //enemySpawner's SpawnEnemy is set to private
        //I honestly have no clue what I should put as an int

        //I don't understand which part of the script is supposed to do the delay, WaveManager or EnemySpawner?

        enemyCount += 1;
    }

    private void EndWave()
    {
        WaveStart();
    }
}
