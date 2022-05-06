using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text puzzleCounter;
    int puzzlePieces = 0;
    //public Transform objectHolder;
    //int numeroDeObjetosParaRecolectar;
    //public int numeroDeObjetosRecolectados;

    void Start()
    {
        puzzleCounter.text = puzzlePieces + "/3";
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Puzzle"))
        {
            puzzlePieces++;
            puzzleCounter.text = puzzlePieces + "/3";
        }
    }

    //void UpdateRecolected()
    //{
    //    numeroDeObjetosRecolectados++;
    //    Debug.Log($"{numeroDeObjetosRecolectados}/{numeroDeObjetosParaRecolectar}");
    //    MenuManager.instance.UpdateTextoRecolectados(numeroDeObjetosRecolectados, numeroDeObjetosParaRecolectar);
    //}
}
