using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    int x = 0; //While
    int y = 10; //DoWhile

    List<int> nums = new List<int>();
    void Start()
    {
        //for (inicializador; condição; incremento / decremento)
            for (int i = 5; i >= 1; i--)
            {

                print(i);
              
            }
        print("Início da partida!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
