using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{

    public GameObject[] panels;
    GameObject currentPanel;
    UIAudioManager audioManager;

    private void Start()
    {
        audioManager = GetComponent<UIAudioManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentPanel == null) return;
            currentPanel.SetActive(false);
            audioManager.PlaySFX(2);
        }
    }

    public void EnablePanel(int index)
    {
        currentPanel = panels[index];
        currentPanel.SetActive(true);
    }
}
