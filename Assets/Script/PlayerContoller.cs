using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    [SerializeField] float speedTurn = 1.0f;
    [SerializeField] public float timeLeft = 10.0f ;
    [SerializeField] public int health = 3 ;
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
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject)
        {
            if (health >= 1)
            {
                health -= 1;
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }

}