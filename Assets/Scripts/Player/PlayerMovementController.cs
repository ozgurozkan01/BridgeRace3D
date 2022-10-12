using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Camera _cam;
    private RaycastHit _raycastHit;
    private Ray _ray;

    private Vector3 _mousePoint;
    private bool _iscolliderNotNull;

    /*private void Start()
    {
        _iscolliderNotNull = _raycastHit.collider != null;
        _cam = GameObject.Find("Main Camera").GetComponent<Camera>();
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
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(_raycastHit.point.x, transform.position.y, _raycastHit.point.z), Time.deltaTime * speed);
            transform.LookAt(new Vector3(_raycastHit.point.x, transform.position.y, _raycastHit.point.z));
        }
    }*/
}
