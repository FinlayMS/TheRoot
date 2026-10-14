using NUnit.Framework.Constraints;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpPickaxe : MonoBehaviour, IInteract
{
    public bool isInteracted;

    private void Start()
    {
        isInteracted = false;
        gameObject.SetActive(true);
    }

    public void Interact()
    {
        isInteracted = true;
        gameObject.SetActive(false);
    }

    public void OnHover()
    {

    }

    public void OnHoverExit()
    {

    }


}
