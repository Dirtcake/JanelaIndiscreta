using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDisable : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            GameStatus.PlayerMovement = true;
            gameObject.SetActive(false);
        }
    }
    private void OnDisable()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
