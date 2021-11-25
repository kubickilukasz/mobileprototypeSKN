using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerMovement), typeof(Animator), typeof(SpriteRenderer))]
public class PlayerAnimations : MonoBehaviour{

    Animator animator;
    PlayerMovement playerMovement;
    SpriteRenderer spriteRenderer;

    void Start(){
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update(){
        if (!playerMovement.IsGrounded) {
            if (playerMovement.yVelocity > 0) {
                animator.Play("HeroJump");
            } else {
                animator.Play("HeroFalling");
            }
        } else if (playerMovement.xVelocity != 0f) {
            animator.Play("HeroRun");
        }  else {
            animator.Play("HeroIdle");
        }

        ChangeFlipX();
    }

    void ChangeFlipX() {
        if (playerMovement.xVelocity > 0f) {
            spriteRenderer.flipX = false;
        } else if (playerMovement.xVelocity < 0f) {
            spriteRenderer.flipX = true;
        }
    }
}
