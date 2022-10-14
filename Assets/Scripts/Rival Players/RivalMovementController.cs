using System.Collections.Generic;
using UnityEngine;
public class RivalMovementController : MonoBehaviour
{
    /*public static List<GameObject> greenBlockList;
    public static List<GameObject> blueBlockList;
    [SerializeField] private float speed;
    private Vector3 _movementDirection;
    private Rigidbody _rb;
    private float _speedMultiplier = 100f;
    private GameObject _target;

    private Vector3 blockPosHolder;
    private Vector3 blockComparePos;
    private void Awake()
    {
        greenBlockList = new List<GameObject>();
        blueBlockList = new List<GameObject>();
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("BlueBlock"))
            blueBlockList.Add(block);
        

        foreach (GameObject block in GameObject.FindGameObjectsWithTag("GreenBlock"))
            greenBlockList.Add(block);
    }
    
    void Update()
    {
        DetermineWhichBlockIsClosest();
    }

    private void DetermineWhichBlockIsClosest()
    {
        if (gameObject.CompareTag("Green"))
        {
            blockPosHolder = greenBlockList[greenBlockList.Count - 1].transform.position;
            _target = greenBlockList[greenBlockList.Count - 1];

            foreach (GameObject greenPos in greenBlockList)
            {
                blockComparePos = greenPos.transform.position;

                if (Vector3.Distance(blockPosHolder, transform.position) >
                    Vector3.Distance(blockComparePos, transform.position))
                {
                    blockPosHolder = blockComparePos;
                    _target = greenPos;
                }
            }

            _movementDirection = blockPosHolder - transform.position;
        }    
        
        else if (gameObject.CompareTag("Blue"))
        {
            blockPosHolder = blueBlockList[blueBlockList.Count - 1].transform.position;
            _target = blueBlockList[blueBlockList.Count - 1];

            foreach (GameObject bluePos in blueBlockList)
            {
                blockComparePos = bluePos.transform.position;

                if (Vector3.Distance(blockPosHolder, transform.position) >
                    Vector3.Distance(blockComparePos, transform.position))
                {
                    blockPosHolder = blockComparePos;
                    _target = bluePos;
                }
            }
        
            _movementDirection = (blockPosHolder - transform.position).normalized; ;
        }
        
        RivalMove(_movementDirection, _target);
    }

    private void RivalMove(Vector3 moveDirection, GameObject target)
    {
        _rb.velocity = moveDirection * (speed * Time.deltaTime * _speedMultiplier);
        transform.LookAt(new Vector3(target.transform.position.x,
            transform.position.y, 
            target.transform.position.z));
    }*/
}
