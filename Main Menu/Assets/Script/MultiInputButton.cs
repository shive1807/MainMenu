using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ReadOnlyAttribute = Unity.Collections.ReadOnlyAttribute;


[AddComponentMenu("Shivam/UI/MultiInputButton")]
public class MultiInputButton : MonoBehaviour
{
    [ReadOnly] public bool IsSelected;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
