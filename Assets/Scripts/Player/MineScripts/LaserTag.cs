using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTag : MonoBehaviour
{
    public float raycastDistance = 10f;
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = raycastDistance;

            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector3 raycastOrigin = transform.position;
            Vector3 raycastDirection = worldMousePosition - raycastOrigin;

            RaycastHit hitInfo;
            if (Physics.Raycast(raycastOrigin, raycastDirection, out hitInfo, raycastDistance))
            {
                GameObject hitObject = hitInfo.collider.gameObject;

                lineRenderer.SetPosition(0, raycastOrigin);
                lineRenderer.SetPosition(1, hitInfo.point);

                hitObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                lineRenderer.SetPosition(0, raycastOrigin);
                lineRenderer.SetPosition(1, raycastOrigin + raycastDirection.normalized * raycastDistance);
            }
        }
    }
}
