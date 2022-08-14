using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Overseer : MonoBehaviour
{
    public static Overseer overseer;
    [HideInInspector] public int enemyExitDespawnDistance { get; set; }
    public float enemySpeed;
    public float enemyBumpForce;
    public float enemySpawnRate;

    public TMP_Text timesHitText;
    private int timesHit = 0;
    public TMP_Text timeDurationText;
    private int secondsElapsed = 0;

    private void Awake()
    {
        overseer = this;
        StartCoroutine(ElapseTime());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void AddHit()
    {
        timesHit++;
        timesHitText.text = "Times Hit: " + timesHit;
    }

    IEnumerator ElapseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            secondsElapsed++;
            timeDurationText.text = "Time Elapsed: " + secondsElapsed;
        }
    }
}
