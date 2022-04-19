using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;

    private Scene scene;

    public Text countdownText;

    void Start()
    {
        currentTime = startingTime;
        scene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            SceneManager.LoadScene(scene.name);

        }
        
    }
}
