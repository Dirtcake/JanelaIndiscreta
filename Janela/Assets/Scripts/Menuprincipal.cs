using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuprincipal : MonoBehaviour
{
    public Animator transition;
    public float TransitionTime = 1f;

    public void PlayGame ()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

   public void QuitGame ()
    {
        Application.Quit();
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("comeco");

        yield return new WaitForSeconds(TransitionTime);

        SceneManager.LoadScene(levelIndex);
    }

}

