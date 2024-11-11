using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex06 : MonoBehaviour
{
    //    O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.

    [SerializeField] bool Guerreiro; //true
    [SerializeField] bool Mago; //true
    [SerializeField] bool Monge;
    [SerializeField] bool Druida;
    [SerializeField] bool Ladino;
    string resultado;
    void Start()
    {
        if (Mago == true && Guerreiro == false)
        {
            print("Mago escolhido");
        }
        else if (Mago == false && Guerreiro == true)
        {
            print("Guerreiro escolhido");
        }
        else if (Mago && Guerreiro)
        {
            print("Amigo (mão no ombro) só um ;)");
        }
        else if (Monge == true)
        {
            print("Querido, esse personagem é o errado, não pode Monge");
        }
        else if (Druida == true)
        {
            print("Querido, esse personagem é o errado, Mesmo que cuidadr da natureza seja bom não pode druida");
        }
        else if (Ladino == true)
        {
            print("Querido, Roubar é errado não pode Ladino");
        }
        else
        {
            print("Então não joga");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
