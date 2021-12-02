using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
   
    public static GameManager Instance;
    internal bool isGameOver;
    public float time = 60f;
    
    public TextMeshProUGUI GameOver;
    // Start is called before the first frame update
    void Start()
    {

        GameOver.gameObject.SetActive(false);
        Instance = this;
        timeText.text ="Time: " + time;
        isGameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {

            GameOver.gameObject.SetActive(true);
            isGameOver = false;

        }
        else
        {
            timeText.text = "Time: " + Mathf.Round(time);
        }

        
    }

   
}
