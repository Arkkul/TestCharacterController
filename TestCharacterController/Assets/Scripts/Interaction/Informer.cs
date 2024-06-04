using UnityEngine;
using UnityEngine.UI;

public class Informer : MonoBehaviour, IInteractable
{
    [SerializeField] private Text _text;
    [SerializeField] private string _info;

    public void Interact()
    {
        _text.text = _info;
    }
}
