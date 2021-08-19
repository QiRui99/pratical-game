using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{ 
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public int score = 0;

    void Start()
    {
        text2.enabled = false;
    }

    public void changeScore(int gemValue)
    {
        score += gemValue;
        text.text = score.ToString();
        if(score == 120)
        {
            text2.enabled = true;
        }
    }

}
