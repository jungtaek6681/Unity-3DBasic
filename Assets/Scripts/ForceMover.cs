using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ForceMover : MonoBehaviour
{
	private Rigidbody rigid;

	[SerializeField]
	private float moveForce;
	[SerializeField]
	private float maxVelocity;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		Vector3 input = Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical");

		rigid.AddForce(input * moveForce, ForceMode.Force);

		// �ְ� �ӵ��� �������� ���� ��� ����ؼ� ������
		if (rigid.velocity.magnitude > maxVelocity)
		{
			rigid.velocity = rigid.velocity.normalized * maxVelocity;
		}
	}
}
