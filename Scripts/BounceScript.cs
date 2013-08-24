using UnityEngine;
using System.Collections;

public class BounceScript : MonoBehaviour 
{
	
	private bool bounce = false;
	public float bounceForce = 10.0f;
	public Transform player;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{		
		if(bounce)
		{
			player.rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
			player.rigidbody.AddForce(0.0f, bounceForce, 0.0f, ForceMode.Impulse);
			bounce = false;
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.transform == player)
		{
			bounce = true;
		}
	}
}
