using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public InputAction jumpAction;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

        jumpAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    
    private void OnCollisionEnter(Collision Collision)
    {
        isOnGround = true;
    }
}
