using UnityEngine;

public class RemoveText : MonoBehaviour
{
    public GameObject byebye;
    private DestroyRoot bool_script;
   
    void Start()
    {
        bool_script = byebye.GetComponent<DestroyRoot>();
    }

    void Update()
    {
        removeTheText();
    }

    public void removeTheText()
    {
        if (bool_script.byebyeText == true)
        {
            byebye.SetActive(false);
        }
    }
}
