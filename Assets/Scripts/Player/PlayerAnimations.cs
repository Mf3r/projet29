using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]

public class PlayerAnimations : MonoBehaviour, IPlayerAnim
{
    private Animator animator;

    private void Awake()
    {
      animator = GetComponent<Animator>();
    }

   public void SetStand(bool isStanding)
   {
      animator.SetBool("Standing", isStanding);
   }

   public void SetJump(bool isJumping)
   {
      animator.SetBool("Jumping", isJumping);
   }

   public void SetRun(bool isRunning)
   {
      animator.SetBool("Running", isRunning);
   }
}
