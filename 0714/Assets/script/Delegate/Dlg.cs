using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dlg : MonoBehaviour
{
    public static string[] CITYLIST = { "서울", "전주", "부산" };
    [SerializeField] TextItem[] TextItem = null;
    [SerializeField] Text txtResult = null;

    [SerializeField] Button btnResult = null;
    [SerializeField] Button btnClear = null;

    int SelectIndex = -1;
    private void Start()
    {
        btnResult.onClick.AddListener(OnClick_Result);
        btnClear.onClick.AddListener(OnClick_Clear);
        Init();
    }

    public void Init()
    {
        for (int i = 0; i < TextItem.Length; i++)
        {
            TextItem[i].OnAddListner(OnCallBack_TextItem);
            TextItem[i].Init(i, CITYLIST[i]);
        }
    }

    void OnCallBack_TextItem(TextItem kItem,bool Select)
    {
        ClearAllSelectItem();
        kItem.SetSelectColor(Select);
        SelectIndex = kItem.Index;

        PrintResult(SelectIndex);
    }

    void ClearAllSelectItem()
    {
        for (int i = 0; i < TextItem.Length; i++) 
        {
            TextItem[i].ClearSelect();
        }
    }

    public void PrintResult(int SelectIdx)
    {
        string sName = CITYLIST[SelectIndex];
        txtResult.text = sName;
    }

    public void OnClick_Result()
    {
        string sName = CITYLIST[SelectIndex];
        txtResult.text = string.Format("선택된 도시는 {0} 입니다", sName);
    }

    public void OnClick_Clear()
    {
        txtResult.text = "";
        ClearAllSelectItem();
        SelectIndex = -1;
    }
}
