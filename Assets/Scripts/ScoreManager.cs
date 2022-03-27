using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    

    public Text scoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        scoreText.text = "Score : " + ScoreNum;
        
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Mycoin")
        {
            
            ScoreNum += 1;
            
            Destroy(Coin.gameObject);
            scoreText.text = "Score : " + ScoreNum;
            

        }
        
    }
}
