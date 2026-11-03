using UnityEngine;

public class Hyperlinks : MonoBehaviour
{
    public void OpenUrl(string link)
    {
        Application.OpenURL(link);
    }
}
