using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{    //3 - (Desafio) Considere que o jogo tem um power-up que revive o
    //personagem caso ele morra.Caso o jogador morra e tiver
    //coletado o power-up ele volta a vida com 50% de sua vida total e
    //deve ser exibido a mensagem "Ainda não, vida atual XX". Caso ele
    //não tenha coletado o power-up exiba "Game Over".

    /*
        Operadores Lógicos

        && (E/ AND)
        || (OU / OR)
        ! (NÃO / NOT)

     */

    [SerializeField] bool playerVivo; //true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;

    int vidaPlayerIncial = 100;
    double vidaplayerAtual = 100;

    void Start()
    {
        if (playerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda não, vida atual " + vidaPlayer);
        }
        else
        {
            print("Game Over");
        }

        //if(vidaplayerAtual <= 0 && powerUp == true)
        //{
        //    vidaplayerAtual = vidaPlayerIncial * 0.5;
        //    print("Ainda não, vida atual " + vidaPlayer);
        //}
        //else
        //{
        //    print("Game Over");
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
