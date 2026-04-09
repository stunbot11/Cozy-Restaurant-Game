using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public PlayerActions controls;
    private Rigidbody rb;

    public float acceleration;
    public float maxMoveSpeed;

    private void Start()
    {
        controls = new PlayerActions();
        rb = GetComponent<Rigidbody>();
        gameObject.AddComponent<PlayerMovement>();
        BindControlls();
    }

    private void BindControlls()
    {
        controls.Enable();
    }

    private void Update()
    {
        if (controls.Basic.Move.inProgress)
            Move();
    }

    private void Move()
    {
        Vector3 moveAngle = new Vector3(controls.Basic.Move.ReadValue<Vector2>().x, 0, controls.Basic.Move.ReadValue<Vector2>().y);
        rb.AddForce(moveAngle * acceleration);
    }
}
