using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    [SerializeField]
    Text score;
    [SerializeField]
    Button start;
    [SerializeField]
    Button end;

    ScoreCounter scoreCounter;

    private void Start()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();

        if (scoreCounter)
        {
            score.text = scoreCounter.GetScoreText();
        }

        start.onClick.AddListener(() => SceneManager.LoadScene("Main"));
        end.onClick.AddListener(() => Application.Quit());

        Destroy(scoreCounter.gameObject);
    }
}
