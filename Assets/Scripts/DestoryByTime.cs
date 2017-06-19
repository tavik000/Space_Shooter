using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float LifeTime;
    
	void Start ()
    {
        Destroy(gameObject, LifeTime);
    }
	
}
