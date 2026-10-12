using UnityEngine;

public class L1NotDone : MonoBehaviour
{
    public GameObject byebye;
    public GameObject script;
    private TotalRootAreas bool_script;

    void Start()
    {
        bool_script = script.GetComponent<TotalRootAreas>();
    }

    void Update()
    {
        removeTheText();
    }

    public bool removeTheText()
    {
        if (bool_script.activateLevel2Trigger == true)
        {
            byebye.SetActive(true);
            Destroy(byebye);
            Debug.Log("TEXT GONE");
        }
        return byebye;
    }
}
