using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AK_TimerBar : MonoBehaviour
{
    Image timerBar;

    public float maxTime;

    float shootMoment;
    float shootMoment2;

    public float timeLeft;


    public GameObject timesUpText;

    public GameObject shootIndicator;


    private void Start()
    {
        //timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        shootMoment = Random.Range(1, maxTime - 1);
        shootMoment2 = shootMoment - 0.5f;
    }

    private void Update()
    {
        

        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }

        if(timeLeft > shootMoment2 && timeLeft < shootMoment)
        {
            shootIndicator.SetActive(true);
            if (Input.GetKeyDown(KeyCode.O))
            {

            }
        }
        if(timeLeft < shootMoment2)
        {
            shootIndicator.SetActive(false);
        }
    }
}
