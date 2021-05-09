
using UnityEngine;

public class InteracTable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    bool isFocus = false;   // Is this interactable currently being focused?
    Transform player1;		// Reference to the player transform

    bool hasInteracted = false;

    public virtual void Interact()
    {
        // this method is grant to be overithing
        Debug.Log("interacting with" + transform.name);                             
    }
    void Update()     
    {
        if (isFocus && !hasInteracted)    // If currently being focused
        {
            float distance = Vector3.Distance(player1.position, interactionTransform.position);
            // If we haven't already interacted and the player is close enough
            if (distance <= radius)
            {
                Interact();                                         // 1
                // Interact with the object
                Debug.Log("Interact");                              // 3
                hasInteracted = true;
            }
        }
    }
    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        hasInteracted = false;
        player1 = playerTransform;
    }

    public void OnDefocused()
    {
        isFocus = false;
        hasInteracted = false;
        player1 = null;
    }
    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
