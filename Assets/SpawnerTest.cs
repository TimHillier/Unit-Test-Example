using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEditor;
using System.Collections;

public class SpawnerTest {

	
	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator SpawnTest() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        var enemyPrefab = Resources.Load("Tests/MonsterTest");
        var spawner = new GameObject().AddComponent<Spawner>();
        GameObject[] monsters;
        var NumOfMonster = 5; //how many monsters to spawn
        
        spawner.Construct(enemyPrefab, NumOfMonster);

        yield return null; //causes update to be triggered, there is now an enemy in the scene. 
                          
        monsters = GameObject.FindGameObjectsWithTag("Monster");

        Assert.AreEqual(NumOfMonster, monsters.Length); //compare how many monsters you want to how many monsters were made. Will be true if theyre equal.




        
    }

    
}
