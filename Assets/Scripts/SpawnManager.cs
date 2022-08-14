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
    private int screenWidth;
    private int screenHeight;
    public int spawnBorder;
    private Vector2 tmpPos;

    private Overseer os;

    private void Start()
    {
        os = Overseer.overseer;
        StartCoroutine(SpawnEnemies());
        tmpPos = (Vector2.zero);
    }

    private void Update()
    {
        screenWidth = Camera.main.pixelWidth;
        screenHeight = Camera.main.pixelHeight;
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(os.enemySpawnRate);
            int enemyToSpawn = Random.Range(1, 5);
            print(enemyToSpawn);
            if (enemyToSpawn == 1)
            {
                Instantiate(downGuy, tmpPos, transform.rotation);
            }
            if (enemyToSpawn == 2)
            {
                Instantiate(upGuy, tmpPos, transform.rotation);
            }
            if (enemyToSpawn == 3)
            {
                Instantiate(leftGuy, tmpPos, transform.rotation);
            }
            if (enemyToSpawn == 4)
            {
                Instantiate(rightGuy, tmpPos, transform.rotation);
            }
        }
    }
}
