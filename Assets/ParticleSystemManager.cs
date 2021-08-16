using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemManager : MonoBehaviour
{
    ParticleSystem particle;
    // Start is called before the first frame update 4137
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // != this is for if notplayer
        if(!particle.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
