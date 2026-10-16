using UnityEngine;

public class RootTextTrigger : MonoBehaviour
{
    public GameObject uiObj;

    private void Start()
    {
        uiObj.SetActive(false);

    }

    private void OnTriggerEnter(Collider player) // upd8 called once per frame
    {
        if (player.gameObject.tag == "Player")
        {
            uiObj.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider player)
    {
        uiObj.SetActive(false);
    }

}
