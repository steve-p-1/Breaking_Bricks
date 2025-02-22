using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    //variables
    [SerializeField] protected TMP_Text scoreText;
    [SerializeField] protected string preText = "Score: ";
    [SerializeField] protected string postText = " pts";

    // methods
    private void Start()
    {
        ChangeScore();
    }

    public void ChangeScore()
    {
        scoreText.text = preText + GameManager.Instance.PlayerScore + postText;
    }
}
