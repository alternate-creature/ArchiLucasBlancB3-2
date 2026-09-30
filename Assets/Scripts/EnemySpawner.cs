using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private Vector2 enemySpawnPoint;
    [SerializeField] Base _base; //this did not exist before
    [SerializeField] EconomyManager economy; //this did not exist before

    public void SpawnEnemy(int amount, float interval)
    {
        //parameters were originally both named "x" in the diagram
        //this function cannot be called by WaveManager as intended because it is private

        for (int i = 0; i < amount; i++)
        {
            Enemy newEnemy = Instantiate(enemyPrefab.gameObject).GetComponent<Enemy>();
            newEnemy.transform.position = enemySpawnPoint;
            newEnemy._base   = _base;
            newEnemy.economy = economy;
        }
    }
}
