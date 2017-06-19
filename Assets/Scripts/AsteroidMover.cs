using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{

    public float speed;
    public float speedRange;

    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = transform.forward * (Random.Range (speed - speedRange, speed + speedRange));

    }
}

