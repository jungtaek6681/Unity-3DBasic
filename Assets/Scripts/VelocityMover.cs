using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VelocityMover : MonoBehaviour
{
	private Rigidbody rigid;

	[SerializeField]
	private float moveVelocity;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		Vector3 input = Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical");

		// �Է��� ���� ������ velocity�� ������ �ְ� �ȴٸ�, �ܺο� ���� �־ �������� ����.
		// if (input.sqrMagnitude <= 0)
		// 	return;

		rigid.velocity = new Vector3(input.x * moveVelocity, rigid.velocity.y, input.z * moveVelocity);
	}
}
