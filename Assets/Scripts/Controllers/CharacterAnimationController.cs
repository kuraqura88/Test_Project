using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("isMove");
    //private static readonly int IsHit = Animator.StringToHash("IsHit");
    //private static readonly int Attack = Animator.STringToHash("attack");
    Animator anim;

    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        //contoroller.OnAttackEvent += Attacking;
        controller.OnMoveEvent += Move;

        anim.SetBool("isMove", true);
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(IsWalking, vector.magnitude > magnituteThreshold);
    }
}