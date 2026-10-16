using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level6Transition : MonoBehaviour
{
    public GameObject fadeOutStart;
    private bool startTransition;
    private bool playerCollides;
    private void Start()
    {
        startTransition = false;
        playerCollides = false;
    }
    private void Update()
    {
        if (playerCollides == true)
        {
            StartCoroutine(StartTransition());
            if (startTransition == true)
            {
                Debug.Log("scene loaded");
                SceneManager.LoadScene("Level6_RedCabin");
            }
        }
    }

    private void OnTriggerEnter()
    {
        Debug.Log("triggered");
        playerCollides = true;
    }

    IEnumerator StartTransition()
    {
        fadeOutStart.SetActive(true);
        yield return new WaitForSeconds(3);
        startTransition = true;
        Debug.Log("transition started");

    }
}
