using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [Header("Swing Setting")]
    float startForce = 7000f;

    [Header("Hit Setting")]
    float hitForce = 2000f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * startForce);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player")) ;
        {
            Rigidbody carRb = col.gameObject.GetComponent<Rigidbody>();

            if (carRb != null)
            {
                Vector3 dir = (col.transform.position - transform.position).normalized;
                carRb.AddForce(dir * hitForce, ForceMode.Impulse);
            }
        }
    }

    void Update()
    {
        
    }
}
