using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using static Unity.Burst.Intrinsics.X86;

public class Ex05 : MonoBehaviour
{
    //    Ap�s completar uma miss�o, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    //incompleta".

    [SerializeField] int PontosDaMissao = 50;
    string resultado;


    void Start()
    {

        if (PontosDaMissao >= 50)
        {
            print("Miss�o bem-sucedida ;D");
        }
        else
        {
            print("Miss�o incompleta :( ");

            resultado = (PontosDaMissao >= 50) ? "Miss�o bem-sucedida ;D" : "Miss�o incompleta :(";
            print(resultado);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
    }
}
