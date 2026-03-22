using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    [SerializeField] float speedTurn = 1.0f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()//ขยับตามช่วงเวลา
    {
        float turn = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector3(turn * speed, rb.linearVelocity.x, speed);
        Debug.Log(rb.linearVelocity);
    }
}