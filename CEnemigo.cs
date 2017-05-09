using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemigo : MonoBehaviour {

	public Transform desde;
	public Transform hasta;

	public float velocidad;
	bool llendo;

	// Use this for initialization
	void Start () {
		llendo = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 objetivo;
		if (llendo) {
			objetivo = hasta.position;
		} 
		else 
		{
			objetivo = desde.position;
		}
		// se crean 2 games objetcts para hacer que la esfera enemiga se mueva del game object DESDE hasta HASTA infinitamente para que 
		//se pueda reiniciar al jugador desde el punto de partida.
		Vector3 distancia = objetivo - transform.position;
		Vector3 desplazamiento = distancia.normalized * velocidad * Time.deltaTime;

		if (desplazamiento.sqrMagnitude >= distancia.sqrMagnitude) 
		{
			desplazamiento = distancia;
		}
		transform.position = transform.position + desplazamiento;

		if (desplazamiento.sqrMagnitude < 0.00001) {
			llendo = !llendo;
		}
	}
}
