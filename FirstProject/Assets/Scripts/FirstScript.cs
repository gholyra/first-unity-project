using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //Vari�vel: camelCase
    //Fun��o: PascalCase
    //Tipos de vari�vel:
    //string
    //int
    //float
    //bool
    //Declarar vari�vel: PRIVACIDADE - TIPO - NOME;
    private string frase;

    // Start is called before the first frame update
    void Start()
    {
        //Atribuir valor a uma vari�vel: nomeDaVariavel = valorParaAtribuir
        int numero1 = 1;
        int numero2 = 2;
        int soma = numero1 + numero2;
        print("Hello World!");
        frase = "Me chamo Tiago, tenho 18 anos =)";
        print(frase);
        string resultado = "O resultado da soma � ";
        print(resultado + soma);
    }

    // Update is called once per frame
    void Update()
    {

    }
}