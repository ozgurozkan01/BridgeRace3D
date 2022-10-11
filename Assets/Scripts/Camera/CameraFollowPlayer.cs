using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    
    [SerializeField] private float lerpMultiplier;
    private Vector3 _offset;
    private GameObject _player;
    
    void Start()
    {
        _player = GetComponent<GameObject>();
        _player = GameObject.Find("Player");
        _offset = transform.position - _player.transform.position;
    }
    
    void Update()
    {
        CameraMove();
    }

    private void CameraMove()
    {
        transform.position = Vector3.Lerp(transform.position, _player.transform.position + _offset, lerpMultiplier * Time.deltaTime);
    }
}
