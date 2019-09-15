using UnityEngine;
using System.Collections;

public class collide_and_reflect : MonoBehaviour 
{
	private Rigidbody _rb;
	private Vector3 _velocity;


	// Use this for initialization
	void Start()
	{
		_rb = this.GetComponent<Rigidbody>();
		float xa = Random.value;
		float ya = Random.value;
		float za = Random.value;
		_velocity = new Vector3(xa,ya,za);
		_rb.AddForce(_velocity, ForceMode.VelocityChange);
	}
	/*
	void OnTriggerExit(Collider other){
	
		ReflectProjectile(_rb, other.contacts.normal);
	
	}*/

	void OnCollisionExit(Collision collision){
		ReflectProjectile(_rb, collision.contacts[0].normal);
	}

	private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
	{    
		_velocity = Vector3.Reflect(_velocity, reflectVector);
		_rb.velocity = _velocity;
	}
}