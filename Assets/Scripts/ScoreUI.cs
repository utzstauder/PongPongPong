using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text textComponent;

    private int count = 0;

    void Awake()
    {
        if (textComponent == null)
        {
            Debug.LogError("No textComponent assigned!!!!!!");
        } else
        {
            UpdateScoreUI();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
            UpdateScoreUI();
        }
    }

    private void UpdateScoreUI()
    {
        textComponent.text = $"P1: {count}";
    }
}
