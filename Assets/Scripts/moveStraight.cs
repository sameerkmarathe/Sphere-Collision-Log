using UnityEngine;
using System.Collections;

public class moveStraight : MonoBehaviour 
	{
		private Rigidbody _rb;
		private Vector3 _velocity;
	//private GameController;

		// Use this for initialization
		void Start()
		{
			_rb = this.GetComponent<Rigidbody>();
		float xa = 10*Random.value;
		float ya = 10*Random.value;
		float za = 10*Random.value;
		_velocity = new Vector3(xa,ya,za);
		//add a force upon impact
			_rb.AddForce(_velocity, ForceMode.VelocityChange);
		}


		void OnCollisionEnter(Collision collision){
		//implement the function below once collision is detected
			ReflectProjectile(_rb, collision.contacts[0].normal);
		}

		private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
	{    //actual reflection funtion for more info refer https://docs.unity3d.com/ScriptReference/Vector3.Reflect.html
			_velocity = Vector3.Reflect(_velocity, reflectVector);
			_rb.velocity = _velocity;
		}
	}