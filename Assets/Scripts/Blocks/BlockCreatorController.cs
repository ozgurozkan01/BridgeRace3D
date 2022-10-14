using UnityEngine;

public class BlockCreatorController : MonoBehaviour
{
    /*[SerializeField] private GameObject greenBlockPrefab;
    [SerializeField] private GameObject blueBlockPrefab;
    [SerializeField] private GameObject redBlockPrefab;

    private float _redBlockAmount;
    private float _blueBlockAmount;
    private float _greenBlockAmount;
    
    void Start()
    {
        _redBlockAmount = BlockStackingController.redBlockList.Count;
        _blueBlockAmount = RivalMovementController.blueBlockList.Count;
        _greenBlockAmount = RivalMovementController.greenBlockList.Count;
    }

    void Update()
    {
        BlockCreation();
    }

    private void BlockCreation()
    {
        if (BlockStackingController.redBlockList.Count < _redBlockAmount)
        {
            Vector3 blockPos = new Vector3(
                Random.Range(-30, 31),
                1.5f,
                Random.Range(-12.5f, 15));
            GameObject redBlock = Instantiate(redBlockPrefab, blockPos, transform.rotation);
        }
        
        else if (RivalMovementController.blueBlockList.Count < _blueBlockAmount)
        {
            Vector3 blockPos = new Vector3(
                Random.Range(-30, 31),
                1.5f,
                Random.Range(-12.5f, 15));
            GameObject blueBlock = Instantiate(blueBlockPrefab, blockPos, transform.rotation);
            RivalMovementController.blueBlockList.Add(blueBlock);
        }
        
        else if (RivalMovementController.greenBlockList.Count < _greenBlockAmount)
        {
            Vector3 blockPos = new Vector3(
                Random.Range(-30, 31),
                1.5f,
                Random.Range(-12.5f, 15));
            GameObject greenBlock = Instantiate(greenBlockPrefab, blockPos, transform.rotation);
            RivalMovementController.greenBlockList.Add(greenBlock);
        }
    }*/
}
