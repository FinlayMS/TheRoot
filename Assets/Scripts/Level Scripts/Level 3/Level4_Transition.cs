using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4_Transition : MonoBehaviour
{
    public GameObject fadeOutStart;
    public GameObject pickaxe;
    private PickUpPickaxe pickedUp;
    private bool startTransition;

    private AudioSource hitRock;

    private void Start()
    {
        pickedUp = pickaxe.GetComponent<PickUpPickaxe>();
        startTransition = false;
        hitRock = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (pickedUp.isInteracted == true)
        {
            StartCoroutine(StartTransition());
            if (startTransition == true)
            {
                SceneManager.LoadScene("Level3_Level4");
            }
        }
    }

    IEnumerator StartTransition()
    {
        fadeOutStart.SetActive(true);
        yield return new WaitForSeconds(3);
        hitRock.Play();
        yield return new WaitForSeconds(2);
        startTransition = true;
        Debug.Log("transition started");

    }
}
