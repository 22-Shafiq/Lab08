using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollector : MonoBehaviour
{
    public Text scoreText;

    private int ScoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        ScoreCounter = 0;
        scoreText.text = "Score: " + ScoreCounter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Obstacle")
        {
            ScoreCounter += 1;
            scoreText.text = "Score: " + ScoreCounter;

        }
    }
}
