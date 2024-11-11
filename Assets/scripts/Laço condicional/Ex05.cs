using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using static Unity.Burst.Intrinsics.X86;

public class Ex05 : MonoBehaviour
{
    //    Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".

    [SerializeField] int PontosDaMissao = 50;
    string resultado;


    void Start()
    {

        if (PontosDaMissao >= 50)
        {
            print("Missão bem-sucedida ;D");
        }
        else
        {
            print("Missão incompleta :( ");

            resultado = (PontosDaMissao >= 50) ? "Missão bem-sucedida ;D" : "Missão incompleta :(";
            print(resultado);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
    }
}
