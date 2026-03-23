using UnityEngine;

public class AutoMoveRB : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 move = Vector3.back * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);
    }
}