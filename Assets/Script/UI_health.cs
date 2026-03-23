using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_health : MonoBehaviour
{
    public PlayerContoller playerContoller;
    int maxHealth;
    int currHealth;

    public Slider healthbarSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currHealth = playerContoller.health;
        maxHealth = currHealth;
    }

    // Update is called once per frame
    void Update()
    {
        currHealth = playerContoller.health;
        healthbarSlider.value = currHealth;
        healthbarSlider.maxValue = maxHealth;
    }
}
