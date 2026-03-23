using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public PlayerContoller playerContoller;
    [SerializeField] TextMeshProUGUI timerText;
    float time ;

    // Update is called once per frame
    void Update()
    {
        time = playerContoller.timeLeft;
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
