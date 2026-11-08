using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public InputAction jumpAction;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        jumpAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered)
        {
            playerRB.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
