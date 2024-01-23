using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIGenericButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI buttonText = default;
    [SerializeField] private Button button = default;
    public UnityAction Clicked = default;
    private bool isDefaultSelection = false;

    private void OnDisable(){
        
    }
}
