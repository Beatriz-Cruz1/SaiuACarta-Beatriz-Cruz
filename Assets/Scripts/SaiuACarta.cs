using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiuACarta : MonoBehaviour
{
    string[] carta = new string[] { " o Rei " , " o Ás " , " a Dama " , " o Valete " , " Dez " , " Nove " , " Oito " , " Sete " , " Seis " , " Cinco ", " Quatro " , " Três " , " Dois " };
    string[] naipe = new string[] { " de Copas" , " de Ouro ", " de Paus ", " de Espadas " };
    string cartarandom;

    // Start is called before the first frame update
    void Start()
    {
        Iniciar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //quando a jogador pressiona o enter 
        {
             Criarcarta();
        }
             
    }

    void Iniciar()
    {
        Debug.Log("Olá! Pressiona Enter para receberes uma carta");
    }

    void Criarcarta() //criacao das cartas
    {
        cartarandom = carta[Random.Range(0, carta.Length)] + naipe[Random.Range(0, naipe.Length)];
        Debug.Log("Saiu a carta" + cartarandom); //mensagem 
    }
    

}
