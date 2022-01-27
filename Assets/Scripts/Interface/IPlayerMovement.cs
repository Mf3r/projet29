using UnityEngine.InputSystem;

internal interface IPlayerMovement
{
   void OnMovePerformed(InputAction.CallbackContext obj);
   void OnMoveCanceled(InputAction.CallbackContext obj);
   void OnJumpPerformed(InputAction.CallbackContext obj);

   void UpdateSpeed(int axe);

   float GravityScale { set; }
}