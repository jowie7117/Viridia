using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float acceleration = 30f;
    [SerializeField] private float deceleration = 25f;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float verticalMultiplier = 0.5f;
    private Rigidbody2D rb;
    Vector2 moveInput;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
{
    Vector2 targetVelocity = new Vector2(
        moveInput.x,
        moveInput.y * verticalMultiplier
    ) * speed;

    targetVelocity = Vector2.ClampMagnitude(targetVelocity, speed);

    float rate = moveInput == Vector2.zero ? deceleration : acceleration;

    rb.linearVelocity = Vector2.MoveTowards(
        rb.linearVelocity,
        targetVelocity,
        rate * Time.fixedDeltaTime
    );
}

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }


}
