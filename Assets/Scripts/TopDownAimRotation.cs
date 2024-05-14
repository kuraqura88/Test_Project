using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    TopDownController controller;
    [SerializeField] SpriteRenderer characterRenderer;
    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    void OnAim(Vector2 aimDirection)
    {
        float rotZ = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90;
    }
}
