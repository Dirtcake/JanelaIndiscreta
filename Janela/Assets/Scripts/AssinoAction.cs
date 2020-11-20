using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssinoAction : MonoBehaviour
{
    int animationIndex = 0;
    public float targetTime = 10;


    private void OnEnable()
    {
        animationIndex = 0;
        targetTime = 10;

        for (int i = 0; i < transform.childCount; i++)
        {
            if (i == animationIndex) transform.GetChild(i).gameObject.SetActive(true);
            else transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            animationIndex++;

            if (animationIndex == transform.childCount)
            {
                Assasino.resetCount();
                //transform.GetChild(transform.childCount-1).gameObject.SetActive(false);
                gameObject.SetActive(false);
                return;
            }

            for (int i = 0; i < transform.childCount; i++)
            {
                if (i == animationIndex) transform.GetChild(i).gameObject.SetActive(true);
                else transform.GetChild(i).gameObject.SetActive(false);
            }

            targetTime = 10;
        }
    }
}
