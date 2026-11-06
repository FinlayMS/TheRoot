using UnityEngine;

public class TriggerCutscene : MonoBehaviour, IInteract
{
    public bool cutsceneStarted;
    public GameObject videoPlayer;
    public GameObject canvas;
    private void Start()
    {
        cutsceneStarted = false;
        videoPlayer.SetActive(false);
        canvas.SetActive(false);
    }

    public void Interact()
    {
        videoPlayer.SetActive(true);
        canvas.SetActive(true);
        cutsceneStarted = true;
    }

    public void OnHover()
    {

    }

    public void OnHoverExit()
    {

    }
}
