using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTrigger : MonoBehaviour
{
    public GameObject cutscene;
    public GameObject canvas;
    public GameObject video;
    public GameObject blackScreen;
    public GameObject fadeOut;
    public GameObject fadeIn;
    public GameObject thanksText;
    private TriggerCutscene triggered;
    private bool startTransition;

    private void Start()
    {
        triggered = cutscene.GetComponent<TriggerCutscene>();
        startTransition = false;
        blackScreen.SetActive(false);
        fadeOut.SetActive(false);
        fadeIn.SetActive(false);
        thanksText.SetActive(false);
    }
    private void Update()
    {
        if (triggered.cutsceneStarted == true)
        {
            StartCoroutine(StartTransition());
            if (startTransition == true)
            {
                Debug.Log("transition loaded");
                SceneManager.LoadScene("Main Menu");
            }
        }
    }

    IEnumerator StartTransition()
    {
        blackScreen.SetActive(true);
        yield return new WaitForSeconds(22);
        canvas.SetActive(false);
        video.SetActive(false);
        thanksText.SetActive(true);
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        startTransition = true;
        Debug.Log("transition started");

    }
}
