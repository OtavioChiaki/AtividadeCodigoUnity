using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio04 : MonoBehaviour
{
    //4. (Pontuação em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontuação total após 7 combos.

    [SerializeField] int pontuacao = 0;
    void Start()
    {

        for (int combo = 1; combo <= 7; combo++)
        {
            //pontuacao = pontuacao + 10;
            pontuacao += 10;
        }

        print("Pontuação total: " + pontuacao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
