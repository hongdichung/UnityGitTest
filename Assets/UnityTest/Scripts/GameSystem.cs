using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class GameSystem : MonoBehaviour
{
    public AssetReference m_AssetReference;

    // Start is called before the first frame update
    void Start()
    {
        m_AssetReference.InstantiateAsync();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
