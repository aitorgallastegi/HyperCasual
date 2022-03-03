using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour{

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    void Start(){
        SpawnTile();
        SpawnTile();
        SpawnTile();
    }

    // Update is called once per frame
    void Update(){
        
    }
    void SpawnTile(){
        //GameObject temp = (groundTile, nextSpawnPoint, Quaternion.Identity);
        //nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
}
