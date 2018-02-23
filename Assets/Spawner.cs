using UnityEngine;
using System.Collections; 
public class Spawner : MonoBehaviour
{
    // public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public Object enemy;                // The enemy prefab to be spawned.
                                        // the radius of enimes spawn around the spawner
    public int numberOfMonsters; 
    private float timeSinceLastSpawn;
    private Random rand;

    public void Construct(Object _enemyPrefab, int _numberOfMonsters)
    {
        enemy = _enemyPrefab;
        numberOfMonsters = _numberOfMonsters;

    }
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        // InvokeRepeating("Spawn", spawnTime, spawnTime);
        Instantiate(enemy);
        spawn(); 
    }
   

    private void spawn()
    {
            for(int i = 0; i < numberOfMonsters -1; i++)
           
              {
            Vector3 Postion = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f,5f)); 
            Instantiate(enemy,Postion,Quaternion.identity);
             }
    }



    }



