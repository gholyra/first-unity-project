using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //Variável: camelCase
    //Função: PascalCase
    //Tipos de variável:
    //string
    //int
    //float
    //bool
    //Declarar variável: PRIVACIDADE - TIPO - NOME;
    private string frase;

    // Start is called before the first frame update
    void Start()
    {
        //Atribuir valor a uma variável: nomeDaVariavel = valorParaAtribuir
        int numero1 = 1;
        int numero2 = 2;
        int soma = numero1 + numero2;
        print("Hello World!");
        frase = "Me chamo Tiago, tenho 18 anos =)";
        print(frase);
        string resultado = "O resultado da soma é ";
        print(resultado + soma);
    }

    // Update is called once per frame
    void Update()
    {

    }
}