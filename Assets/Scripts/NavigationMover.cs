using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Apple;

[RequireComponent(typeof(NavMeshAgent))]
public class NavigationMover : MonoBehaviour
{
    private NavMeshAgent agent;
	private PlayerData data;

	[SerializeField]
	private Vector3 destination;

	private void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
		data = GetComponent<PlayerData>();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			// Camera.main : �±װ� "Camera"�� ������Ʈ = "Main Camera"
			// ī�޶�κ��� ���콺 ��ǥ(Input.mousePosition) ��ġ�� �����ϴ� ���� ����
			// Ray ray = new Ray(������, ����);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				destination = hit.point;
			}
		}

		agent.destination = destination;
		data.speed = agent.velocity.magnitude;
	}
}
