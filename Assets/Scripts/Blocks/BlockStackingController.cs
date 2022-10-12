using UnityEngine;

public class BlockStackingController : MonoBehaviour
{
    [SerializeField] private Transform firstBlockPoint;
    private static int _blockAmount;
    private static float _blockHeightFromGround;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
            Stacking(other.gameObject);
        }
    }

    private void Stacking(GameObject block)
    {
        block.transform.SetParent(transform);
        block.transform.position = new Vector3(firstBlockPoint.position.x, firstBlockPoint.position.y + _blockHeightFromGround, firstBlockPoint.position.z);
        block.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        _blockHeightFromGround += 0.41f;
        _blockAmount++;
    }
}
