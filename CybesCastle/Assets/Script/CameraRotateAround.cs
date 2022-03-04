using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAround : MonoBehaviour
{
	public float zoomOutMin = 1;
	public float zoomOutMax = 90;

	public Transform target;
	private Vector3 offset;
	public float sensitivity = 1; // чувствительность мышки
	public float limit = 80; // ограничение вращения по Y
	public float zoomMax = 10; // макс. увеличение
	public float zoomMin = 3; // мин. увеличение
	private float X, Y;

	bool flag = false;

	void Start()
	{

	}

	void Update()
	{
		if (Input.touchCount == 2)
		{
			Touch touchZero = Input.GetTouch(0);
			Touch touchOne = Input.GetTouch(1);

			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

			float difference = currentMagnitude - prevMagnitude;

			zoom(difference * 0.1f);

			flag = true;

		} else if (Input.touchCount == 0 | flag == false) //else if (Input.touchCount == 1 && flag == false)
		{
			limit = Mathf.Abs(limit);
			if (limit > 90) limit = 90;
			offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax) / 2);
			transform.position = target.position + offset;

			X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
            Y += Input.GetAxis("Mouse Y") * sensitivity;
            Y = Mathf.Clamp(Y, -limit, -10);
            transform.localEulerAngles = new Vector3(-Y, X, 0);
            transform.position = transform.localRotation * offset + target.position;
        }
		else if (Input.touchCount == 0)
        {
			flag = false;
        }

		void zoom(float increment)
		{
			Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView - increment, zoomOutMin, zoomOutMax);
		}
	}

}