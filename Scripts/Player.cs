using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    bool reSpawn;
    [SerializeField]
    Transform playerSpawnPoints;

    private bool lastToggle = false;
    private Transform[] spawnPoints;
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (lastToggle != reSpawn)
        {
            Respawn();
            reSpawn = false;
        }
        else
        {
            lastToggle = reSpawn;
        }
    }

    private void Respawn()
    {        
        
        int i = Random.Range(1, spawnPoints.Length);

        transform.position = spawnPoints[i].transform.position;
        
    }
}
