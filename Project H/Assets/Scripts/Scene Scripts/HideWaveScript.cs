﻿using UnityEngine;
using UnityEngine.UI;

public class HideWaveScript : MonoBehaviour
{
    public float hideTime = 30f;

    private float minute;
    private float second;
    private float timer;

    public Text timerDisplay;
    public Text objectiveDisplay;

    private bool officialSpawned = false;

    [SerializeField]
    private GameObject Official;

    void Update()
    {
        if (hideTime > 0)
        {
            officialSpawned = false;
            hideTime -= 1.0f * Time.deltaTime;
            minute = Mathf.Floor(hideTime / 60f);
            second = (hideTime % 60f);
            timerDisplay.text = "Time Left: " + string.Format("{0:00}:{1:00}", minute, second);
            objectiveDisplay.text = "Objective: Hide the money until the time runs out.";
        }
        else    //TODO: breakup redundant loop on every frame.
        {
            hideTime = 0.0f;
            timerDisplay.text = "";
            objectiveDisplay.text = "Objective: Act natural.";
            if (officialSpawned == false)
            {
                Official.SetActive(true);
                officialSpawned = true;
            }
        }

    }
}
