using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCubeStackController : MonoBehaviour
{

    public List<GameObject> blockList=new List<GameObject>();
    public GameObject lastBlockObject;


    
    void Start()
    {
        UpdateLastBlockObject();
    }

    public void IncreaseBlockState(GameObject _gameobject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);

        _gameobject.transform.position = new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - 2f, lastBlockObject.transform.position.z);
        //buradaki transform bu scriptin baðlý olduðu object anlamýna geliyor
        _gameobject.transform.SetParent(transform);
        blockList.Add(_gameobject);
        UpdateLastBlockObject();
    }

    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObject();
    }

    private void UpdateLastBlockObject()
    {
        lastBlockObject = blockList[blockList.Count - 1];
    }
}
