using UnityEngine;
using UnityEngine.InputSystem;

public interface IInteract
{
    void Interact();
    void OnHover();
    void OnHoverExit();
}

public class InteractSystem : MonoBehaviour
{
    public Camera cam;
    public float dist = 50f;

    private IInteract current;
    private Renderer r;

    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, dist) && hit.collider.TryGetComponent(out IInteract i))
        {
            if(current != i)
            {
                Clear();
                current = i;
                current.OnHover();
            }

            if (Keyboard.current.eKey.IsActuated()) current.Interact();
        }
        else
        {
            Clear();
        }

    }

    void Clear()
    {
        if (current != null) current.OnHoverExit();
        current = null;
    }
}
