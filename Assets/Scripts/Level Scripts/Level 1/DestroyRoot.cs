using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyRoot : MonoBehaviour, IInteract
{
    public bool byebyeText = false;
    public bool destroyedRoot = false;

    public void Start()
    {
        gameObject.SetActive(true);
}

    public void Interact()
    {
        destroyedRoot = true;
        byebyeText = true;
        gameObject.SetActive(false);
    }

    public void OnHover()
    {

    }

    public void OnHoverExit()
    {

    }

}
