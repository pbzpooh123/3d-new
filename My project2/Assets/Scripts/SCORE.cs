using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SCORE : MonoBehaviour
{
    public static SCORE isntance;
    
    public TMP_Text ScoreText;

    private int score = 0;

    void Awake()
    {
        isntance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Point:" + score.ToString();
    }

    // Update is called once per frame
    public void Addpoint()
    {
        score += 10;
        ScoreText.text = "Point:" + score.ToString();
    }
    
    public void Removepoint()
    {
        score -= 10;
        ScoreText.text = "Point:" + score.ToString();
    }
    
    public void Killpoint()
    {
        score += 50;
        ScoreText.text = "Point:" + score.ToString();
    }
}
