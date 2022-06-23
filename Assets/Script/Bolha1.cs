using System.Net.Mime;
using System.Net.Http.Headers;
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolha1 : MonoBehaviour
{
    //Este script gerencia toda a movimentacao e comportamento das bolhas

    public int varTrigger; //essa variável serve para avisar o GameController que foi detectado uma colisão
    public float speed;
    Rigidbody rig;
    Transform trans;

    private float gravidade;
    private float aleatorio; //guarda um número aleatório

    // Start is called before the first frame update
    void Start()
    {
        //inicializa as variáveis usadas
        speed = 0.5f;
        gravidade = 0.002f;
        rig = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        //faz o metodo e movimentacao acontecer a cada 1 segundo
        InvokeRepeating("movimentacao", 0, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void movimentacao(){
        //gera um número aleatório que será usado para mudar a posição horizontal aleatoriamente
        aleatorio = Random.Range(-1.0f, 1.0f);
        
        //muda a posição
        gravidade = 0.2f + gravidade; //calcula a gravidade
        Vector3 Position = new Vector3(aleatorio,gravidade,Input.GetAxisRaw("Vertical"));

        //multiplica a posicao com a velocidade gerando uma nova posicao pro objeto
        rig.velocity = Position * speed;
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Se a colisão aconteceu com um objeto do tipo Bolha
        if(collider.gameObject.name == "Bolha2")
        {
            varTrigger = 1; 
        }
    }
}
