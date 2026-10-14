using System.Collections;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Trigger : MonoBehaviour
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
                SceneManager.LoadScene("Level2_Level3");
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
