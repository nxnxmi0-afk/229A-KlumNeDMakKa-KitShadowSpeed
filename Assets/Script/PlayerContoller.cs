using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    [SerializeField] float speedTurn = 1.0f;
    [SerializeField] float timeLeft = 10.0f ;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()//ขยับตามช่วงเวลา
    {
        if(timeLeft>=0)
        {
            timeLeft -= Time.deltaTime;
            float turn = Input.GetAxis("Horizontal");

            rb.linearVelocity = new Vector3(turn * speed, rb.linearVelocity.x, speed);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    
}