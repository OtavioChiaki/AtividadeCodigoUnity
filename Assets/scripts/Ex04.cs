using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
//    Um jogador possui itens limitados
//no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
//Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
//indispon�vel".

   [SerializeField] bool itemPocao;  //true

    void Start()
    {
        if (itemPocao == true)
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
