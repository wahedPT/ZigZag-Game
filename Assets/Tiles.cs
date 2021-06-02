using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Tiles : MonoBehaviour
//{
//    Rigidbody tempRigidbody;
//    // Start is called before the first frame update
//    void Start()
//    {
//        tempRigidbody = GetComponentInParent<Rigidbody>();
//        //Debug.Log(tempRigidbody.name);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        // Debug.Log(tempRigidbody.gameObject.name);
//    }
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.tag == "Player")
//        {

//            TileManager.Instance.SpawnTile();
//            StartCoroutine("FallDown");

//            //Debug.Log("Triggered");


//        }
//    }
//    IEnumerator FallDown()
//    {
//        yield return new WaitForSeconds(3);
//        tempRigidbody.isKinematic = false;
//        yield return new WaitForSeconds(1);
//        tempRigidbody.isKinematic = true;
//        if (tempRigidbody.gameObject.name == "ForwardTile")
//        {

//            TileManager.Instance.AddForwardTilePool(tempRigidbody.gameObject);
//            //Debug.Log("Added to forward pool");
//        }
//        else if (tempRigidbody.gameObject.name == "LeftTile")
//        {

//            TileManager.Instance.AddLeftTilePool(tempRigidbody.gameObject);
//            //Debug.Log("Added to left pool");
//        }
//    }
//}
public class Tiles : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
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

            //Debug.Log("Triggered");


        }
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(5);
        rb.isKinematic = false;
        yield return new WaitForSeconds(2);
        rb.isKinematic = true;
        if (rb.gameObject.name=="ForwardTile")
        {
            TileManager.Instance.AddForwardTilePool(rb.gameObject);
        }
        else if(rb.gameObject.name=="LeftTile")
        {
            TileManager.Instance.AddLeftTilePool(rb.gameObject);
        }
      
        //GetComponent<Rigidbody>().isKinematic = false;

    }
}
