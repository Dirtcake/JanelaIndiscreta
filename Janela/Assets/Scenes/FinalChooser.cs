using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChooser : MonoBehaviour
{
    private void OnEnable()
    {
        transform.GetChild(PlayerPrefs.GetInt("Final")).gameObject.SetActive(true);
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
