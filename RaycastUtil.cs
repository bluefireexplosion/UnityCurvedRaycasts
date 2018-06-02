using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastUtil : MonoBehaviour
{
Vector3[] GravCast(Vector3 startPos, Vector3 direction, int killAfter, int velocity)
	{
		RaycastHit hit;
		Vector3[] vectors = new Vector3[killAfter];
		Ray ray = new Ray(startPos, direction);
		for (int i = 0; i < killAfter; i++)
		{
            if(Physics.Raycast(ray,out hit,1f))
			{
				return vectors;
			}
			Debug.DrawRay(ray.origin, ray.direction, Color.blue);
			ray = new Ray(ray.origin + ray.direction, ray.direction + (Physics.gravity / killAfter / velocity));
			vectors[i] = ray.origin;

		}
		return vectors;
	}
}