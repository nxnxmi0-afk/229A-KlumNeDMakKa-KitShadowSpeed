using UnityEngine;

public class AutoMoveRB : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    bool IsAvoid;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 move;
        if (IsAvoid == true)
        {
            move = Vector3.left * speed * Time.fixedDeltaTime;
        }
        else
        {
            move = Vector3.back * speed * Time.fixedDeltaTime;
        }
            rb.MovePosition(rb.position + move);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            IsAvoid = true;
        }        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            IsAvoid = false;
        }
    }
}