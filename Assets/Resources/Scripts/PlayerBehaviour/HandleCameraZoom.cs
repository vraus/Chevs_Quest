using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCameraZoom : MonoBehaviour
{
    public Camera cam;

    private float maxZoom = 2;
    private float minZoom = 10;

    private float sensitivity = 1;
    private float speed = 15;

    private float maxH = 12;
    private float minH = -12;

    private float maxV = 8;
    private float minV = -8;

    float targetZoom;

    private void Start()
    {
        targetZoom = cam.orthographicSize;
    }

    private void Update()
    {
        if (!AnswerBoxManager.GetInstance().talking && !GeneralMenu.GetInstance().isOpenMenu)
        {
            ZoomHandler();
            CameraMove();
        }
    }
    private void ZoomHandler()
    {
        targetZoom -= Input.mouseScrollDelta.y * sensitivity;
        targetZoom = Mathf.Clamp(targetZoom, maxZoom, minZoom);
        float newSize = Mathf.MoveTowards(cam.orthographicSize, targetZoom, speed * Time.deltaTime);
        cam.orthographicSize = newSize;
    }
    private void CameraMove()
    {
        float move_h = Input.GetAxis("Horizontal");
        float move_v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(move_h, move_v, 0);
        Vector3 currentPosition = cam.transform.position;
        Vector3 newPosition = currentPosition + move * Time.deltaTime * speed;

        newPosition.x = Mathf.Clamp(newPosition.x, minH, maxH);
        newPosition.y = Mathf.Clamp(newPosition.y, minV, maxV);

        cam.transform.position = newPosition;
    }

}
