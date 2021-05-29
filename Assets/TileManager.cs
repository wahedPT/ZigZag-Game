using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    //stop at 2.02.56
    public GameObject[] tiles;
    public GameObject currentTile;
    //private static TileManager instance;
    //public static TileManager instance
    //{
    //    get
    //    {

    //        for (instance == null)
    //        {
    //            instance = GameObject.FindObjectOfType<TileManager>();
    //        }
    //        return instance
    //    }
    //}

    

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            //TileManager.instance.SpawnTile();
            SpawnTile();
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnTile()
    {
        //this is the method to generate game obj(prefabs)
        //instantiate(obj,vector3 position,Quaternion.identity);
        //currentTile =Instantiate(tiles[0], currentTile.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
        int index = Random.Range(0,2);
       
        currentTile = Instantiate(tiles[index],currentTile.transform.GetChild(index).position, Quaternion.identity);
        

    }
}
