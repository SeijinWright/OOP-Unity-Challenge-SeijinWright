using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Overseer : MonoBehaviour
{
    public static Overseer overseer;
    [HideInInspector] public int enemyExitDespawnDistance { get; set; }
    public float enemySpeed;
    public float enemyBumpForce;
    public float enemySpawnRate;

    private void Awake()
    {
        overseer = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
