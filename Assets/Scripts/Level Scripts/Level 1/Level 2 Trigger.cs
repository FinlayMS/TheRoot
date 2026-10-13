using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Trigger : MonoBehaviour
{
    public GameObject totalRootCounter;
    public GameObject fadeInStart;
    private TotalRootAreas counter;
    private bool startTransition;
    void Start()
    {
        counter = totalRootCounter.GetComponent<TotalRootAreas>();
        startTransition = false;
    }
   
    private void Update()
    {
        if (counter.activateLevel2Trigger == true)
        {
            if (startTransition == true)
            {
                fadeInStart.SetActive(true);
                Debug.Log("level transition triggered");
                SceneManager.LoadScene("Level1_Level2");
            }
        }
    }

    IEnumerator OnTriggerEnter(Collider player)
    {
        startTransition = true;
        yield return new WaitForSeconds(3);

    }
}
