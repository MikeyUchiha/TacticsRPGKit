﻿using UnityEngine;
using System.Collections;

public class CameraRig : MonoBehaviour
{
	public float speed = 3.0f;
	public Transform follow;
	Transform _transform;

	void Awake()
	{
		_transform = transform;
	}

	// Update is called once per frame
	void Update()
	{
		if(follow)
		{
			_transform.position = Vector3.Lerp(_transform.position, follow.position, speed * Time.deltaTime);
		}
	}
}
