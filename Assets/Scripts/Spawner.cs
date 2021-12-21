using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Spawner : MonoBehaviour
{

    [SerializeField] private Button _spawnButton;
    [SerializeField] private AssetReference _assetReference;

    // Start is called before the first frame update
    private void Start()
    {
        _spawnButton.onClick.AddListener(SpawnObject);
       var asyncOperationHandle = _assetReference.LoadAssetAsync<GameObject>();
        asyncOperationHandle.Completed += OnCompleted;
    }

    // Update is called once per frame
    private void SpawnObject()
    {
        _assetReference.InstantiateAsync();
    }

    private void OnCompleted(AsyncOperationHandle<GameObject> obj )
    {
        Debug.Log(message:"Completed");
    }

}
