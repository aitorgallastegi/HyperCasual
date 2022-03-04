using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour{

    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;
    

    // Start is called before the first frame update
    void Start(){
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnTriggerExit(Collider other){
        groundSpawner.SpawnTile();
        Destroy(gameObject,2);//segundos
    }

    
    void SpawnObstacle(){
        int obstacleSpawnIndex = Random.Range(2,5);// incluye el primer numero pero no el segundo, del 2 al 4
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
