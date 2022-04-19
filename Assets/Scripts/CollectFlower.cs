using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFlower : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Scoring.theScore += 1;
        Destroy(gameObject);
    }
}
