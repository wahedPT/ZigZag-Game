using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    //stop at 2.02.56
    public GameObject[] tiles;
    public GameObject currentTile;
    

    //objectpooling
    //this is stack in that gameobj or anything we want then name it
    //Stack<GameObject> forwardTilePoool;//this the way to create a stack
    //Stack<GameObject> leftTilePool; or
    Stack<GameObject> forwardTilePoool = new Stack<GameObject>();
    Stack<GameObject> leftTilePool = new Stack<GameObject>();

    //singleton instance for spawning
    private static TileManager instance;

    public static TileManager Instance 
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<TileManager>();
            }
            return instance;
        }
       
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void createTilesP(int value)// to create the pool tiles
     {
        for(int i=0; i<value; i++)
        {
            forwardTilePoool.Push(Instantiate(tiles[0]));
            leftTilePool.Push(Instantiate(tiles[1]));
            forwardTilePoool.Peek().SetActive(false);
           leftTilePool.Peek().SetActive(false);
            forwardTilePoool.Peek().name = "ForwardTile";
            leftTilePool.Peek().name = "LeftTile";
           
        }
     }
    public void AddForwardTilePool(GameObject tempObj)
    {
        forwardTilePoool.Push(tempObj);
        forwardTilePoool.Peek().SetActive(false);
    }
    public void AddLeftTilePool(GameObject tempObj)
    {
       leftTilePool.Push(tempObj);
        leftTilePool.Peek().SetActive(false);
    }


    public void SpawnTile()
    {

        if (forwardTilePoool.Count == 0 || leftTilePool.Count == 0)
        {
            createTilesP(5);
        }
        //this is the method to generate game obj(prefabs)
        //instantiate(obj,vector3 position,Quaternion.identity);
        //currentTile =Instantiate(tiles[0], currentTile.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
        int index = Random.Range(0,2);

        if(index == 0)
        {
            GameObject temp = forwardTilePoool.Pop();
            temp.SetActive(true);
            temp.transform.position = currentTile.transform.GetChild(index).position;
            currentTile = temp;
        }
        else if (index == 1)
        {
            GameObject temp = leftTilePool.Pop();
            temp.SetActive(true);
            temp.transform.position = currentTile.transform.GetChild(index).position;
            currentTile = temp;
        }

      
        //currentTile = Instantiate(tiles[index],currentTile.transform.GetChild(index).position, Quaternion.identity);


    }

}
