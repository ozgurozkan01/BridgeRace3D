    using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Camera _cam;
    private Collider _planeCollider;
    private RaycastHit _raycastHit;
    private Ray _ray;
    
    private void Start()
    {
        _cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        _planeCollider = GameObject.Find("Plane").GetComponent<Collider>();
    }

    private void Update()
    {
        GetMousePos();
        
        if (Input.GetMouseButton(0))
        {
            PlayerFollowTheMouse();    
        }
    }

    private void GetMousePos()
    {
        _ray = _cam.ScreenPointToRay(Input.mousePosition);
    }

    private void PlayerFollowTheMouse()
    {
        if (Physics.Raycast(_ray, out _raycastHit))
        {
            if (_raycastHit.collider == _planeCollider)
            {
                transform.position = Vector3.MoveTowards(transform.position, _raycastHit.point, Time.deltaTime * speed);
                transform.LookAt(new Vector3(_raycastHit.point.x, transform.position.y, _raycastHit.point.z));
            }
        }
    }
}
