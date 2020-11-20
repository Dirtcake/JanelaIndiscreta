using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assasino : MonoBehaviour
{
    public static bool change = true;

    void Update()
    {
        if (change)
        {
            targetTime -= Time.deltaTime;
        }

        if (targetTime <= 0.0f && change)
        {
            transform.GetChild((int)Random.Range(1,3)).gameObject.SetActive(true);
            change = false;
        }
    }

    public static float targetTime = 5;

    public static void resetCount()
    {
        targetTime = 5;
        change = true;
    }

}
