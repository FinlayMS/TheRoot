using UnityEngine;

public class HitTree : MonoBehaviour, IInteract
{
    public bool isInteracted;
    private void Start()
    {
        isInteracted = false;
    }

    public void Interact()
    {
        isInteracted = true;
    }

    public void OnHover()
    {

    }

    public void OnHoverExit()
    {

    }
}
