using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car_Player"))
        {
            SceneManager.LoadScene("End");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
