using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour{

    [SerializeField]
    float speed = 2f;

    [SerializeField]
    float jumpForce = 1f;

    [Space()]

    [SerializeField]
    float rayDistanceGrounded = 1f;

    [SerializeField]
    LayerMask groundedLayerMask;

    public bool CanMove { set; get; } = true;
    public bool IsGrounded { set; get; } = true;

    public float xVelocity { 
        get {
            return rigidbody2D.velocity.x;
        } 
    }

    public float yVelocity {
        get {
            return rigidbody2D.velocity.y;
        }
    }

    new Rigidbody2D rigidbody2D;
    float xDirection = 0f;
    bool wantJump = false;

    void Start(){
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (CanMove) {
            GetInputs();
        }
    }

    void FixedUpdate() {
        if (CanMove) {
            Move();
        }

        RaycastHit2D raycasthit2d = Physics2D.Raycast(transform.position, Vector2.down, rayDistanceGrounded, groundedLayerMask);
        IsGrounded = raycasthit2d.transform != null;

    }

    void Move() {
        bool jump = IsGrounded && wantJump;
        rigidbody2D.velocity = new Vector2(speed * xDirection , !jump ? rigidbody2D.velocity.y : jumpForce);
        wantJump = false;
    }

    void GetInputs() {

        xDirection = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump")) {
            wantJump = true;
        }

    }
}
