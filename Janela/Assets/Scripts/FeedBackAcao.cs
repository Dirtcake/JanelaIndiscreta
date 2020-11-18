using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedBackAcao : MonoBehaviour
{
    //Fade time in seconds
    public float fadeOutTime;
    private void OnEnable()
    {
        FadeOut();
    }
    public void FadeOut()
    {
        if(gameObject.GetComponent<Text>() != null)
        StartCoroutine(TextFadeOutRoutine());
        else StartCoroutine(ImageFadeOutRoutine());

    }
    private IEnumerator TextFadeOutRoutine()
    {
        Text text = GetComponent<Text>();
        Color originalColor = text.color;
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }

        text.color = Color.white;
        gameObject.SetActive(false);
    }
    private IEnumerator ImageFadeOutRoutine()
    {
        Image text = GetComponent<Image>();
        Color originalColor = text.color;
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }

        text.color = Color.white;
        gameObject.SetActive(false);
    }
}
