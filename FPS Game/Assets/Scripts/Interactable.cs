using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // add or remove an interacationEvent component to this gameObject.
    public bool useEvents;
    //message displayed to player when looking at interactable
    [SerializeField]
    public string promptMessage;

    public void BaseInteract()
    {
        if (useEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }
    
    protected virtual void Interact()
    {
        // not code in here
        //template function to be overriden by our subclasses
    }
}
