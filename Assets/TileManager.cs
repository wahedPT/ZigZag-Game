using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    //stop at 2.02.56
    public GameObject leftTile,forwardTile;
    public GameObject currentTile;
    void Start()
    {
        for(int i =0; i < 10; i++)
        {
            SpawnTile();
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTile()
    {
        //this is the method to generate game obj(prefabs)
        //instantiate(obj,vector3 position,Quaternion.identity);
       currentTile= Instantiate(forwardTile, currentTile.transform.GetChild(0).GetChild(1).position, Quaternion.identity);
    }
}
