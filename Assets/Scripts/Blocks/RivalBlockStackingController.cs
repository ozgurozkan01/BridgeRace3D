using System;
using System.Collections.Generic;
using UnityEngine;

public class RivalBlockStackingController : MonoBehaviour
{
    public static List<GameObject> _greenBlockList;
    public static List<GameObject> _blueBlockList;
    [SerializeField] private Transform firstBlockPos;
    private float _blockHeightFromGround;

    private void Awake()
    {
        _greenBlockList = new List<GameObject>();
        _blueBlockList = new List<GameObject>();
    }

    private void Start()
    {
        firstBlockPos = GetComponent<Transform>().GetChild(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Blue") && other.gameObject.CompareTag("BlueBlock"))
            Stacking(other.gameObject, _blueBlockList);
        

        else if (gameObject.CompareTag("Green") && other.gameObject.CompareTag("GreenBlock"))
            Stacking(other.gameObject, _greenBlockList);
    }

    private void Stacking(GameObject block, List<GameObject> blockList)
    {
        block.transform.SetParent(gameObject.transform);
        block.GetComponent<Collider>().isTrigger = false;
        blockList.Add(block);
        RivalMovementController.blueBlockList.Remove(block);
        block.transform.position = new Vector3(firstBlockPos.position.x,
            firstBlockPos.position.y + _blockHeightFromGround,
            firstBlockPos.position.z);
        block.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        _blockHeightFromGround += .41f;
    }
}
