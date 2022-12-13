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
			// Camera.main : 태그가 "Camera"인 오브젝트 = "Main Camera"
			// 카메라로부터 마우스 좌표(Input.mousePosition) 위치를 관통하는 광선 생성
			// Ray ray = new Ray(시작점, 방향);
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
