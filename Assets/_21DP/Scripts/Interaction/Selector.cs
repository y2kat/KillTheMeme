using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    private bool enableInteraction = false;
    public GameObject interactionMessage;
    bool firstClickDone = false;

    Interactable lastInteractedObject;
    Interactable interactable;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !enableInteraction)
        {
            if (!firstClickDone)
            {
                firstClickDone = true;
                return;
            }

            if (!enableInteraction && interactable)
                enableInteraction = true;
        }
    }

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10))
        {
            interactable = hit.transform.gameObject.GetComponent<Interactable>();

            if (interactable)
            {
                lastInteractedObject = interactable;
                interactionMessage.SetActive(true);
                interactable.OnLookingAt(true);

                if (!enableInteraction) return;

                interactable.OnInteraction();
            }

            else
            {
                interactionMessage.SetActive(false);
                if (lastInteractedObject != null)
                {
                    lastInteractedObject.OnLookingAt(false);
                    lastInteractedObject = null;
                    interactable = null;
                }
            }
        }

        else
        {
            interactionMessage.SetActive(false);
            if (interactable != null)
            {
                interactable.OnLookingAt(false);
                interactable = null;
            }
        }
    }
}
