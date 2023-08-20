using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private bool isClickable = true;
    private bool isPaired = false;
    private int pairID = -1;

    // 設定方塊的圖案ID，不同ID表示不同的圖案
    public int cubeID;

    // 被點選的方塊列表
    private static List<CubeController> selectedCubes = new List<CubeController>();

    // 處理方塊被點選的事件
    private void OnMouseDown()
    {
        if (isClickable && !isPaired && CanPick())
        {
            AddCubeToPairList(this);
            ToggleHighlight(true);

            if (selectedCubes.Count == 2)
            {
                // 有兩個方塊被點選，進行連接檢查
                if (selectedCubes[0].cubeID == selectedCubes[1].cubeID)
                {
                    // 成功連成一對，可以消除這兩個方塊
                    selectedCubes[0].Pair();
                    selectedCubes[1].Pair();
                }
                else
                {
                    // 未連成一對，重置這兩個方塊的狀態
                    selectedCubes[0].Reset();
                    selectedCubes[1].Reset();
                }
                // 清空已選擇方塊的列表
                selectedCubes.Clear();
            }
        }
    }

    // 檢查是否可以點選方塊
    private bool CanPick()
    {
        return selectedCubes.Count < 2; // 只有當已選擇方塊數目少於2個時，才允許點選新的方塊
    }

    // 將方塊加入被點選的方塊列表
    private void AddCubeToPairList(CubeController cube)
    {
        selectedCubes.Add(cube);
    }

    // 將方塊標記為已連成一對
    public void Pair()
    {
        isClickable = false;
        isPaired = true;
        ToggleHighlight(false);
    }

    // 重置方塊狀態
    public void Reset()
    {
        isClickable = true;
        isPaired = false;
        ToggleHighlight(false);
    }

    // 開啟或關閉方塊的高亮顯示（示意被選中）
    private void ToggleHighlight(bool highlight)
    {
        if (highlight)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
