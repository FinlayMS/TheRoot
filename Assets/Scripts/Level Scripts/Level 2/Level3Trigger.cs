using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider player)
    {
        Debug.Log("level transition triggered");
        SceneManager.LoadScene("Level2_Level3");
    }
}
