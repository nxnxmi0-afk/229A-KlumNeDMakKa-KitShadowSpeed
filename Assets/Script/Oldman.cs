using UnityEngine;

public class Oldman : MonoBehaviour
{

    public float speed = 80f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(Vector3.right * speed);
    }
}