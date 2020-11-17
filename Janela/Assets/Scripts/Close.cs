using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            GameStatus.PlayerMovement = true;
            gameObject.SetActive(false);
        }
    }
}
