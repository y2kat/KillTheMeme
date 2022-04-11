using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    private bool enableInteraction = false;
    public GameObject interactionMessage;

    bool firstClickDone = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !enableInteraction)
        {
            if (!firstClickDone)
            {
                firstClickDone = true;
                return;
            }
            if (!enableInteraction)
                enableInteraction = true;
        }
    }

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 100))
        {
            var interactable = hit.transform.gameObject.GetComponent<Interactable>();
            
            if (interactable == null)
            {
                interactionMessage.SetActive(false);
                return;
            }

            interactionMessage.SetActive(true);
            interactable.OnLookingAt(true);

            if (!enableInteraction) return;

            enableInteraction = false;
            interactable.OnInteraction();
        }

        interactionMessage.SetActive(false);
    }
}
