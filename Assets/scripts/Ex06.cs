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
            print("Amigo (m�o no ombro) s� um ;)");
        }
        else if (Monge == true)
        {
            print("Querido, esse personagem � o errado, n�o pode Monge");
        }
        else if (Druida == true)
        {
            print("Querido, esse personagem � o errado, Mesmo que cuidadr da natureza seja bom n�o pode druida");
        }
        else if (Ladino == true)
        {
            print("Querido, Roubar � errado n�o pode Ladino");
        }
        else
        {
            print("Ent�o n�o joga");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
