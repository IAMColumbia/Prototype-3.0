using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerRB.AddForce(Vector3.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
