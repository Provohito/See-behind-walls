using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[Header("Settings")]
	public float speed = 10f;

	// COMPONENTS
	private CharacterController cc;

	//============================================
	// FUNCTIONS (UNITY)
	//============================================

	void Awake()
	{
		cc = GetComponent<CharacterController>();
	}

	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		Vector3 forward = transform.forward * v * speed * Time.deltaTime;
		Vector3 right = transform.right * h * speed * Time.deltaTime;

		cc.Move(forward + right);
	}
}
