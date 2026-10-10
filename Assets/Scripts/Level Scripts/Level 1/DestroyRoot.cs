using Unity.VisualScripting;
using UnityEngine;

public class DestroyRoot : MonoBehaviour, IInteract
{
    public bool byebyeText = false;
    public void Interact()
    {
        Destroy(gameObject);
        byebyeText = true;
    }

    public void OnHover()
    {

    }

    public void OnHoverExit()
    {

    }

}
