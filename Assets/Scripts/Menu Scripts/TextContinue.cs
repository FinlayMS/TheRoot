using UnityEngine;
using UnityEngine.SceneManagement;

public class TextContinue : MonoBehaviour
{
    public void DestroyText()
    {
        gameObject.SetActive(false);
    }


    public void LoadScene(string sceneName)
    {
        Debug.Log("Level loaded");
        SceneManager.LoadScene(sceneName);
    }

}
