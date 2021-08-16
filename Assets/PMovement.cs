using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PMovement : MonoBehaviour
{
    public float speed;
    [SerializeField]
    Vector3 direction;
    public GameObject ParticleEffectPrefab;
    //[SerializeField]
    //int Score= 0;
  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            if(direction==Vector3.forward)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            ScoreMan.Score += 1;
            Debug.Log("Score:" + ScoreMan.Score);
            //Score++;
           

        }

        transform.Translate(direction * speed * Time.deltaTime);
      


    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        //raycast(origin(te starting point of the ray),direction(the dir of the ray), distance(the max dista the ray should check for collisons)
        if (Physics.Raycast(transform.position, Vector3.forward, Mathf.Infinity))
        {


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject. tag == "Coin") 
        {
            ScoreMan.Score = ScoreMan.Score + 5;
            //Score = Score + 5;
            
            
           //to inactive coin
            other.gameObject.SetActive(false);
            Instantiate(ParticleEffectPrefab, transform.position, Quaternion.identity);
        }



    }
}
