using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Trigger : MonoBehaviour
{
    public GameObject totalRootCounter;
    private TotalRootAreas counter;
    void Start()
    {
        counter = totalRootCounter.GetComponent<TotalRootAreas>();
    }
    void OnTriggerEnter(Collider player)
    {
        if (counter.activateLevel2Trigger == true)
            SceneManager.LoadScene("Level2_Forest");
    }
}
