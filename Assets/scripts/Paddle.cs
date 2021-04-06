using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float velocity = 0.5f;

    [SerializeField]
    float paddleHeight = 1f;

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;

    // Update is called once per frame
    void Update()
    {
        /*
         * se tecla para cima premida
         * então subir
         * senao tecla para baixo premida
         * entao descer
         */

        //Move raquetes
        if (Input.GetKey(upKey))
        {
            //sobe
            transform.position += velocity * Vector3.up * Time.deltaTime;
        }
        else if (Input.GetKey(downKey)) {
            //desce
            transform.position += velocity * Vector3.down * Time.deltaTime;
        }

        //Verifica limites

        /*float cameraHeight = Camera.main.orthographicSize;

        if (transform.position.y >= cameraHeight - 0.5f) {
            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - 0.5f;
            transform.position = positionAux;
        }

        if (transform.position.y <= -cameraHeight + 0.5f)
        {
            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + 0.5f;
            transform.position = positionAux;
        }*/

        //Verifica limites (Clamp)
        float cameraHeight = Camera.main.orthographicSize;
        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(positionAux.y, -cameraHeight + (paddleHeight * 0.5f), cameraHeight - (paddleHeight * 0.5f));
        transform.position = positionAux;
    }
}
