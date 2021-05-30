using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
            
                TileManager.Instance.SpawnTile();
                 StartCoroutine("FallDown");


        }
        
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(5);
        rb.isKinematic = false;
        //GetComponent<Rigidbody>().isKinematic = false;

    }
}
