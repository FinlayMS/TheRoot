using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5Transition : MonoBehaviour
{
    public GameObject fadeOutStart;
    public GameObject tree;
    private HitTree hit;
    private bool startTransition;
    private bool hasPlayed;

    private AudioSource hitTree;

    private void Start()
    {
        hit = tree.GetComponent<HitTree>();
        startTransition = false;
        hasPlayed = true;
        hitTree = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (hit.isInteracted == true)
        {
            StartCoroutine(StartTransition());
            if (startTransition == true)
            {
                Debug.Log("transition loaded");
                SceneManager.LoadScene("Level4_Level5");
            }
        }
    }

    IEnumerator StartTransition()
    {
        fadeOutStart.SetActive(true);
        yield return new WaitForSeconds(3);

        if (hasPlayed == true)
        {
            hitTree.Play();
            hasPlayed = false;
        }

        yield return new WaitForSeconds(2);
        startTransition = true;
        Debug.Log("transition started");

    }
}
