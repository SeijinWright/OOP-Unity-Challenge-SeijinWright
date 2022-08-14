using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject downGuy;
    public GameObject upGuy;
    public GameObject leftGuy;
    public GameObject rightGuy;

    public int spawnDistanceFromFrame;
    public int spawnBorder;

    private Overseer os;

    private void Start()
    {
        os = Overseer.overseer;
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(os.enemySpawnRate);
            int enemyToSpawn = Random.Range(1, 5);
            Vector2 tmpPos;
            if (enemyToSpawn == 1)
            {
                tmpPos = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(spawnBorder, Screen.width - spawnBorder), Screen.height + spawnDistanceFromFrame));
                Instantiate(downGuy, tmpPos, transform.rotation);
            }
            if (enemyToSpawn == 2)
            {
                tmpPos = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(spawnBorder, Screen.width - spawnBorder), -spawnDistanceFromFrame));
                Instantiate(upGuy, tmpPos, transform.rotation);
            }
            if (enemyToSpawn == 3)
            {
                tmpPos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width + spawnDistanceFromFrame, Random.Range(spawnBorder, Screen.height - spawnBorder)));
                Instantiate(leftGuy, tmpPos, transform.rotation);
            }
            if (enemyToSpawn == 4)
            {
                tmpPos = Camera.main.ScreenToWorldPoint(new Vector2(-spawnDistanceFromFrame, Random.Range(spawnBorder, Screen.height - spawnBorder)));
                Instantiate(rightGuy, tmpPos, transform.rotation);
            }
        }
    }
}
