using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Trigger : MonoBehaviour
{
    public GameObject allGone;
    private RootsDestroyed1 counter;
    void Start()
    {
        counter = allGone.GetComponent<RootsDestroyed1>();
    }
   // void OnTriggerEnter(Collider other)
  //  {
   //     if (counter.rootsGoneTotal >= 6)
   //         SceneManager.LoadScene("Level2_Forest");
   // }
}
