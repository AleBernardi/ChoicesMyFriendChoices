using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class RevelaCarta : MonoBehaviour
{
    public GameObject[] cartas;
    public Button[] botoes;
    public Sprite As;
    public Sprite Rainha;
    public Sprite Rei;
    public Sprite Virada;
    public int qtdCartas = 3;
    public int pesoCarta1;
    public int pesoCarta2;
    public int pesoCarta3;
    public int contJogadas;
    public int contRodadas = 0;
    public int[] escolha;
    public int[] baralho;

    private int posAs;
    private int posRei;
    private int posRainha;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        escolha = new int[2];
        baralho = new int[qtdCartas];
        botoes = new Button[qtdCartas];
        cartas = GameObject.FindGameObjectsWithTag("Carta");
        for(int i=0; i<qtdCartas; i++){
            baralho[i] = -1;
        }
        do {
            Random.InitState(System.Environment.TickCount);
            pesoCarta1 = Random.Range(0,qtdCartas);
            pesoCarta2 = Random.Range(0,qtdCartas);
            pesoCarta3 = Random.Range(0,qtdCartas);

            if(baralho[0] == -1){
                baralho[0] = pesoCarta1;
            }
            if(baralho[0] != pesoCarta2 && baralho[1] == -1 && baralho[2] != pesoCarta2){
                baralho[1] = pesoCarta2;
            }
            if(baralho[0] != pesoCarta3 && baralho[1] != pesoCarta3 && baralho[2] == -1){
                baralho[2] = pesoCarta3;
            }
        }while(baralho[0] == -1 || baralho[1] == -1 || baralho[2] == -1);
        for(int x = 0; x < qtdCartas; x++){
            Debug.Log(baralho[x]);
            if(baralho[x] == 2){
                posAs = x;
            }
            if(baralho[x] == 1){
                posRei = x;
            }
            if(baralho[x] == 0){
                posRainha = x;
            }
        }  
        for(int k = 0; k < cartas.Length; k++){
            botoes[k] = cartas[k].GetComponent<Button>();
        }   
        for(int j = 0; j < botoes.Length; j++){
            botoes[j].onClick.AddListener(ExecutarAcaoCarta);
        }
        botoes[0].onClick.AddListener(() => ButtonClicked(0));
        botoes[1].onClick.AddListener(() => ButtonClicked(1));
        botoes[2].onClick.AddListener(() => ButtonClicked(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExecutarAcaoCarta(){
        Debug.Log("Clicou em uma carta");
    }

    void ButtonClicked(int botao){
        if(botao == posAs) {
            botoes[botao].image.sprite = As;
        } 
        if(botao == posRei) {
            botoes[botao].image.sprite = Rei;
        } 
        if(botao == posRainha) {
            botoes[botao].image.sprite = Rainha;
        }
    }
}
