using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ColorUtility;

public class Vence : MonoBehaviour
{

    public bool flaglayer=true;

    public Text texto;

    public Color corP1;
    public Color corP2;

    private int pontuacaoP1;
    private int pontuacaoP2;

    // Start is called before the first frame update
    void Start()
    {
        pontuacaoP1 = 0;
        pontuacaoP2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(flaglayer){
            //mostra canvas jogador 1
            texto.text = "<color=#"+ToHtmlStringRGB(corP1)+">É a vez do jogador 1!</color>";
            Debug.Log("É a vez do jogador 1!");

            //somar pontuação da carta ao jogador 1 aqui e após click inverte a flag
            //pontuacaoP1 = //valor da carta selecionada
        }else{
            //mostra canvas jogador 2
            texto.text = "<color=#"+ToHtmlStringRGB(corP2)+">É a vez do jogador 2!</color>";
            Debug.Log("É a vez do jogador 2!");

            //somar pontuação da carta ao jogador 2 aqui e após click inverte a flag
            //pontuacaoP2 = //valor da carta selecionada
        }
    }
}
