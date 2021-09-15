using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScoreController : MonoBehaviour
{

    [Header("UI")]
    public Text CurrentScore;
    public Text HighScore;

    [Header("Score")]
    public ScoreController scoreController;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = scoreController.GetCurrentScore().ToString();
        highScore.text = ScoreData.highScore.ToString();
    }
}
