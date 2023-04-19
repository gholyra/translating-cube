using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTransf : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] private float velocity;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Código importante para que o jogo e seu processamento se torne frame independent
        /*Que seria quando o jogo é renderizado não de acordo com o poder da máquina do usuário,
          mas de acordo com o tempo em si*/
        //playerTransform.Translate(1f * Time.deltaTime, 0f, 0f);

        //if (Input.GetAxis("Horizontal") != 0)
        //{
        //    playerTransform.Translate(Vector2.left * Time.deltaTime);
        //}
        //else if (Input.GetAxis("Vertical") != 0)
        //{
        //    playerTransform.Translate(Vector2.down * Time.deltaTime);
        //}

        MovePlayer();
        
    }

    private void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * velocity;
        playerTransform.Translate(moveX, moveY, 0);
        //playerTransform.localScale = new Vector3(0, 8, 10));
    }

}
