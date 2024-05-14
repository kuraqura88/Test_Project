using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerInputController : TopDownController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 mosPos = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mosPos);
        Vector2 dir = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(dir);
    }
}
