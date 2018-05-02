using System;
using UnityEngine;

public class ScoreCallback : MonoBehaviour
{
    public static float CurrentScore;
    public static float CurrentSpeed = -0.1f;
    public static bool GameArePlaying = true;
    private TextMesh _text;

    // Use this for initialization
    void Start()
    {
        _text = gameObject.GetComponent("TextMesh") as TextMesh;
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Score: " + Math.Ceiling(CurrentScore) + "   " + CurrentSpeed;
        if (GameArePlaying)
        {
            CurrentScore += 0.1f;
        }

        if (CurrentScore > 0 && Math.Ceiling(CurrentScore) % 100 == 0)
        {
            CurrentSpeed = CurrentSpeed - 0.02f;
        }
    }
}