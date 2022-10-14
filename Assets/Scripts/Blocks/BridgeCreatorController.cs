using System;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCreatorController : MonoBehaviour
{/*
    [SerializeField] private List<Transform> bridgePartCollisions;
    
    private void Awake()
    {
        bridgePartCollisions = new List<Transform>();
    }

    private void Start()
    {
        foreach (GameObject bridgeCol in GameObject.FindGameObjectsWithTag("BridgeCol"))
        {
            bridgePartCollisions.Add(bridgeCol.transform);        
        }
    }

    private void Update()
    {
        CheckBlockListIsEmpty();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BridgeCol") && BlockStackingController.redBlockList.Count > 0)
        {
            ReplaceTheBlockOnTheBridge(other.gameObject.transform.GetChild(0).position);
            other.gameObject.tag = "DeactivateBridgeCol";
            bridgePartCollisions.Remove(other.transform);
        }
    }

    private void ReplaceTheBlockOnTheBridge(Vector3 bridgePos)
    {
        
        BlockStackingController.redBlockList[BlockStackingController.redBlockList.Count - 1].transform.SetParent(null);
        BlockStackingController.redBlockList[BlockStackingController.redBlockList.Count - 1].transform.position = bridgePos;
        BlockStackingController.redBlockList[BlockStackingController.redBlockList.Count - 1].transform.rotation =
            new Quaternion(0f, 0f, 0f, 0f);
        BlockStackingController.redBlockList.Remove(
            BlockStackingController.redBlockList[BlockStackingController.redBlockList.Count - 1]);
        
        BlockStackingController._blockHeightFromGround -= 0.41f;
    }

    private void CheckBlockListIsEmpty()
    {
        if (BlockStackingController.redBlockList.Count == 0)
        {
            foreach (Transform bridgeCol in bridgePartCollisions)
            {
                bridgeCol.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
        
        else if (BlockStackingController.redBlockList.Count > 0)
        {
            foreach (Transform bridgeCol in bridgePartCollisions)
            {
                bridgeCol.gameObject.GetComponent<Collider>().isTrigger = true;
            }
        }
    }*/
}
