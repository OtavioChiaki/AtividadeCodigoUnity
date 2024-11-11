using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    [SerializeField] int NumeroAtaque;
    
    void Start()
    {
        for (int i = 1; i <= NumeroAtaque; i+=2)
        {

            print(i);

        }
        print("Dano maximo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
