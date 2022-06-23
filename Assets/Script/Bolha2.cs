using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolha2 : MonoBehaviour
{

    public float speed;
    Rigidbody rig;

    private float aleatorio;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        InvokeRepeating("movimentacao", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void movimentacao(){
        //gera um número aleatório
        aleatorio = Random.Range(-1.0f, 1.0f);
        
        //muda a posição
        Vector3 Position = new Vector3(aleatorio,0,Input.GetAxisRaw("Vertical"));

        //multiplica a posicao com a velocidade gerando uma nova posicao pro objeto
        rig.velocity = Position * speed;
    }
}
