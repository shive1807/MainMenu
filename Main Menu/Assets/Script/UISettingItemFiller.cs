using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public enum SettingFieldType
{
    Volume_SFx,
    Volume_Music,
    Volume_Master,
}
public class UISettingItemFiller : MonoBehaviour
{
    [SerializeField] private SettingFieldType _fieldType = default;
    [SerializeField] private UIPaginationFiller _pagination = default;
    [SerializeField] private TextMeshProUGUI _title = default;
    [SerializeField] private TextMeshProUGUI _currentSelectedOption_Text = default;
    [SerializeField] private Image _bg = default;
    [SerializeField] private Color _colorSelected = default;
    [SerializeField] private Color _colorUnselected = default;
    [SerializeField] private Sprite _bgSelected = default;
    [SerializeField] private Sprite _bgUnselected = default;
    [SerializeField] private Button _buttonNext = default;
    [SerializeField] private Button _buttonPrevious = default;

    public event UnityAction OnNextOption = delegate { };
    public event UnityAction OnPreviousOption = delegate { };

    public void FillSettingField(int paginationCount, int selectedPaginationIndex, string selectedOption){
        _pagination.SetPagination(paginationCount, selectedPaginationIndex);
        _title.text = _fieldType.ToString();

        _buttonNext.interactable = selectedPaginationIndex < paginationCount - 1;
        _buttonPrevious.interactable = selectedPaginationIndex > 0;
    }

    public void SelectItem(){
        _bg.sprite = _bgSelected;
        _title.GetComponent<TextMeshProUGUI>().color = _colorSelected;
        _currentSelectedOption_Text.color = _colorSelected;
    }    

    public void UnselectItem(){
        _bg.sprite = _bgUnselected;
        _title.GetComponent<TextMeshProUGUI>().color = _colorUnselected;
        _currentSelectedOption_Text.color = _colorUnselected;
    }

    public void NextOption(){
        OnNextOption.Invoke();
    }

    public void PreviousOption(){
        OnPreviousOption.Invoke();
    }

    public void SetNavigation(Button buttonToSelectDown, Button buttonToSelectOnUp){
        
    }
}
