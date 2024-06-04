using UnityEngine;

public class InteractableZone : MonoBehaviour
{
    private IInteractable _interactable;

    private void Start()
    {
        _interactable = GetComponent<IInteractable>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerInput>() != null)
        {
            _interactable.Interact();
        }
    }
}
