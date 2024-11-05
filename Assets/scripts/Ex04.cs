using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
//    Um jogador possui itens limitados
//no inventário.Verifique se o jogador possui uma "Poção de Vida".
//Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
//indisponível".

   [SerializeField] bool itemPocao;  //true

    void Start()
    {
        if (itemPocao == true)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
