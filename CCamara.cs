using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCamara : MonoBehaviour {
	//se crea un objeto de tipo jugador y se crea un vector para determinar la distancia del entre la camara y el jugador

	public GameObject jugador;
	Vector3 distancia;

	// Use this for initialization
	void Start () {
		//Se determina la distancia entre la puscionn de la camara y el jugador al principio
		distancia = transform.position - jugador.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		//se actualiza la posicion de la camara dependiendo del movimiento que se le de y se mueve la camara junto a la esfefa
		transform.position = jugador.transform.position + distancia;
		
	}
}
