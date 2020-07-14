using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextItem : MonoBehaviour
{
    public delegate void DeleagateFunc(TextItem kItem, bool bSelect);
    public DeleagateFunc OnSelectFunc = null;

    [SerializeField] Text m_txtName = null;

    Button btnSelect = null;
    Color OriColor = Color.white;

    public int Index = 0;

    private void Start()
    {
        OriColor = GetComponent<Image>().color;

        btnSelect = GetComponent<Button>();
        btnSelect.onClick.AddListener(OnClicked_Select);
    }

    public void Init(int idx,string sName)
    {
        Index = idx;
        m_txtName.text = sName;
    }

    public void OnAddListner(DeleagateFunc func)
    {
        OnSelectFunc = new DeleagateFunc(func);
    }

    public void OnClicked_Select()
    {
        if (OnSelectFunc != null)
        {
            OnSelectFunc(this, true);
        }
    }

    public void ClearSelect()
    {
        SetSelectColor(false);
    }

    public void SetSelectColor(bool Select)
    {
        Image kImage = GetComponent<Image>();

        if(Select)
        {
            kImage.color = Color.green;
        }
        else
        {
            kImage.color = OriColor;
        }
    }
}
