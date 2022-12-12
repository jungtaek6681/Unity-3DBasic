using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMover : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed;

	private void Update()
	{
		Vector3 input = Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical");

		transform.Translate(input * moveSpeed * Time.deltaTime);
	}
}
