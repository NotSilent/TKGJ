using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    Text text;

    public int Score
    {
        get; private set;
    }

    private void Awake()
    {
        Score = 0;
    }

    private void Start()
    {
        UpdateText();
    }

    public void Add(int val)
    {
        Score += val;
        UpdateText();
    }

    public string GetScoreText()
    {
        return $" SCORE: {Score.ToString()}";
    }

    private void UpdateText()
    {
        text.text = GetScoreText(); ;
    }
}
