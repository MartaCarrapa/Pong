using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField]
    float velocidade = 5f;

    bool bolaFoiLancada = false;

    [SerializeField]
    float tempoDeEspera = 2f;

    float tempoDecorrido = 0f;

    // Start is called before the first frame update
    void Start()
    {
        /*if (Random.value < 0.5f)
        {
            GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
        }
        else {
            GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
        }*/ 
    }

    public void Reset()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        bolaFoiLancada = false;
        tempoDecorrido = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (bolaFoiLancada == false) {

            tempoDecorrido += Time.deltaTime;

            if (tempoDecorrido >= tempoDeEspera) {
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.onUnitSphere;
                bolaFoiLancada = true;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Alterar velocidade ligeiramente

    }
}
