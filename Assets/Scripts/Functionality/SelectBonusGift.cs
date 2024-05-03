using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBonusGift : MonoBehaviour
{
    [SerializeField]
    private Button this_Button;
    [SerializeField]
    private GameObject this_GameObject;
    [SerializeField]
    private GameObject selected_GameObject;

    private void Start()
    {
        if (this_Button) this_Button.onClick.RemoveAllListeners();        
        if (this_Button) this_Button.onClick.AddListener(SelectGift);
    }

    private void SelectGift()
    {
        if (this_GameObject) this_GameObject.SetActive(false);
        if (selected_GameObject) selected_GameObject.SetActive(true);
    }
}
