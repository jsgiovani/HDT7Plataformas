using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJugador : MonoBehaviour {
	Rigidbody myRigitbody;
	public float velocidad = 10;
	Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
		myRigitbody = GetComponent<Rigidbody>();
		posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//se crean floats para detectar que teclas se esta presionando y de esa manera se mueve la esfera ya sea horizontal o verticalmente
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");
		myRigitbody.AddForce (new Vector3(horizontal, 0, vertical)*velocidad);
	}
	  
	void OnTriggerEnter(Collider col)

	{
		//se crean los respectivos Triggerts para verificar si la esfera se topa o no con un enemigo o sea esfera roja y se reinicia su posicion en en la posicicon de inicio
			if (col.CompareTag ("enemigo")) {
			myRigitbody.MovePosition (posicionInicial);
			myRigitbody.velocity = Vector3.zero;
			myRigitbody.angularVelocity = Vector3.zero;

		}
	}

}
