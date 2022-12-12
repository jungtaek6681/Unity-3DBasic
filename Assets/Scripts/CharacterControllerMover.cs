using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerMover : MonoBehaviour
{
	private CharacterController controller;
	private float moveY;

	[SerializeField]
	private float moveSpeed;
	[SerializeField]
	private float gravity;

	private void Awake()
	{
		controller = GetComponent<CharacterController>();
	}

	private void Update()
	{
		Vector3 input = Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical");

		controller.Move(input * moveSpeed * Time.deltaTime);

		// CharacterController는 Rigidbody의 물리를 활용하지 않으므로 상하이동을 구현해야함
		if (controller.isGrounded)
		{
			moveY = 0;
		}
		else
		{
			moveY += gravity * Time.deltaTime;
		}
		controller.Move(Vector3.up * moveY * Time.deltaTime);
	}
}
