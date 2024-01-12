using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AppleGravity : MonoBehaviour
{
    [SerializeField] private Transform _centerOfGravity;
    
    const float ForceMagnitude = 9.8f;

    void Update()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Snake"))
        {
            if (obj != gameObject)
            {
                var direction = gameObject.transform.position - obj.transform.position;
                
                var force = direction.normalized * ForceMagnitude;

                var rb = obj.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(force);
                }
            }
        }
    }
}
