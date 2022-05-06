using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    [SerializeField] TMP_Text textoDeRecolectados;

    public void UpdateTextoRecolectados(int recolectados, int aRecolectar)
    {
        textoDeRecolectados.text = $"{recolectados}/{aRecolectar}";
    }

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}
