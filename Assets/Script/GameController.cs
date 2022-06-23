
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    //Essa classe gerencia o aparecimento e desaparecimento de cada objeto na tela

    public GameObject bolha1; 
    public GameObject bolha2;
    private GameObject clone; //guarda o objeto que deve ser criado


    private int var;
    private int aux; //vairável auxiliar para caso de existirem diversas bolhas(evita que em 1 colisão se crie mais de 1 bolha)


    // Start is called before the first frame update
    void Start()
    {
        aux = 0;

        //Deixa as bolhas 1 e 2 ativas
        bolha1.SetActive(true);
        bolha2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Verifica se aconteceu colisao
        var = bolha1.GetComponent<Bolha1>().varTrigger;
        
        if((var == 1)&&(aux == 0)){  //se a colisao aconteceu

            //cria nova bolha na posição da explosão 
            clone = Instantiate(bolha1,gameObject.transform, true) as GameObject; 

            //desativa as bolhas
            bolha1.SetActive(false);
            bolha2.SetActive(false);
            //ativa a nova bolha
            clone.SetActive(true);

            aux = 1;
        }
    }
}
