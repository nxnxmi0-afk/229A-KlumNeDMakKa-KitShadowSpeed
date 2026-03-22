using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float time = 10.0f;
    float timeLeft = 4.0f ;

    // Update is called once per frame
    void Update()
    {
        if (time > 5)
        {
            time -= Time.deltaTime;
            timerText.text = time.ToString("00");
        }

        else if (time < 5 && time > 3)
        {
            time -= Time.deltaTime;
            timerText.color = Color.yellow;
            timerText.text = time.ToString("00");
        }
        else if (time < 3 && time > 0)
        {
            time -= Time.deltaTime;
            timerText.color = Color.red;
            timerText.text = time.ToString("00"+"!!!!!");
        }
        else if (time == 0)
        {
            time -= Time.deltaTime;
            timerText.color = Color.black;
            timerText.text = time.ToString("Game Over");
        }


    }
}
