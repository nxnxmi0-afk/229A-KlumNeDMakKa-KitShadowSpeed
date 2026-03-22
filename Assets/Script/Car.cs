using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(0, rb.linearVelocity.y, speed);
    }
}
