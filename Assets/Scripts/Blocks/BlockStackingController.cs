using System.Collections.Generic;
using UnityEngine;

public class BlockStackingController : MonoBehaviour
{
    [SerializeField] private Transform firstBlockPoint;
    public static List<GameObject> redBlockList;
    public static float _blockHeightFromGround;

    private void Awake()
    {
        redBlockList = new List<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
            redBlockList.Add(other.gameObject);
            other.gameObject.GetComponent<Collider>().isTrigger = false;        
            Stacking(other.gameObject);
        }
    }
    
    private void Stacking(GameObject block)
    {
        block.transform.SetParent(transform);
        block.transform.position = new Vector3(firstBlockPoint.position.x, firstBlockPoint.position.y + _blockHeightFromGround, firstBlockPoint.position.z);
        block.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        _blockHeightFromGround += 0.41f;
    }
}
