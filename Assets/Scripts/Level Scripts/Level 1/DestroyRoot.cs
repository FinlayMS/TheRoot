using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyRoot : MonoBehaviour, IInteract
{
    public bool destroyedRoot = false;

    public void Start()
    {
        gameObject.SetActive(true);
}

    public void Interact()
    {
        destroyedRoot = true;
        gameObject.SetActive(false);
    }

    public void OnHover()
    {

    }

    public void OnHoverExit()
    {

    }

}
