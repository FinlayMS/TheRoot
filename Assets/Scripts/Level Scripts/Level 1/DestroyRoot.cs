using Unity.VisualScripting;
using UnityEngine;

public class DestroyRoot : MonoBehaviour, IInteract
{
    public bool byebyeText = false;
    public bool destroyedRoot = false;

    public void Interact()
    {
        gameObject.SetActive(false);
        destroyedRoot = true;
        byebyeText = true;
    }

    public void OnHover()
    {

    }

    public void OnHoverExit()
    {

    }

}
