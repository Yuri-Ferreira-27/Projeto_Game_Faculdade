//Player aula 29/09

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá, Eu sou o objeto" + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
		float movVertical = Input.GetAxis("Vertical");
		
		Vector3 movimento = new Vector3(movHorizontal,0,movVertical);
		
		gameObject.transform.GetComponent<Rigidbody>().AddForce(movimento * velocidade);
    }
}
