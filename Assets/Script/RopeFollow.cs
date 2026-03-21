using UnityEngine;

public class RopeFollow : MonoBehaviour
{
    public Transform ball;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direction = ball.position - transform.parent.position;
        transform.up = direction;
    }
}
