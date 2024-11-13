using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    // (Cálculo de moedas coletadas) O jogador coleta 3 moedas a
    // cada fase.Após 10 fases, exiba o total de moedas coletadas.

    int moedas;
    int fases;
    int totalMoeda;

    void Start()
    {
        for (int fase = 1; fase <= 10; fase++)
        {
            //totalMoeda = totalMoeda + 3;
            totalMoeda += 3;

            print("O total de moedas até agora é: " + totalMoeda);
        }

        print("Total de moedas: " + totalMoeda);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
