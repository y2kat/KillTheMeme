using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemLocked : Interactable
{
    [SerializeField]
    private int necesaryItems = 3;

    public int index;

    public override void OnInteraction()
    {
        Debug.Log("Trying to access...");

        if (Inventory.HasItems(necesaryItems))
            OpenLock();
        else
            Debug.Log("Can not access...");
    }

    void OpenLock()
    {
        Debug.Log("Open");
        GetComponent<Animator>().enabled = true;
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(index);
    }
}
