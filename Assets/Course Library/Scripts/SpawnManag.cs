using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacleprefab;
    private Vector3 spawnPos = new Vector3(50, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerControl playercontrollerscript;

    // Start is called before the first frame update
    void Start()
    {
        playercontrollerscript = GameObject.Find("Player").GetComponent<PlayerControl>();
        InvokeRepeating("spawnObstacle",startDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void spawnObstacle()
    {
        if(playercontrollerscript.Gameover == false)
        {
            Instantiate(obstacleprefab, spawnPos, obstacleprefab.transform.rotation);
        }

    }
}
