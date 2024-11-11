using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex09 : MonoBehaviour
{
    //9. (Placar final) Crie um script que lê o placar de uma partida entre
    //time A e time B.Depois, escreva no console qual dos três
    //resultados possíveis aconteceu: vitória do time A, vitória do time B
    //ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //escreva que foi “um empate emocionante”.


    [SerializeField] int placarTimeA;
    [SerializeField] int placarTimeB;
    void Start()
    {

        //placarTimeA = UnityEngine.Random.Range(1, 5);
        //placarTimeB = UnityEngine.Random.Range(1, 5);

        if (placarTimeA > placarTimeB)
        {
            print("Vitória do Time A!");
        }
        else if (placarTimeB > placarTimeA)
        {
            print("Vitória do Time B!");
        }
        else //Caso de empate
        {
            if (placarTimeA > 3 && placarTimeB > 3)
            {
                print("Foi um empate emocionante!");
            }
            else
            {
                print("Foi um empate!");
            }
        }
    
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
