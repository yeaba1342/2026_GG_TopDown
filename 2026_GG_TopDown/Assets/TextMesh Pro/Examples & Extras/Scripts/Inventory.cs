
using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    // 열쇠
    public int keys = 0;
    public TMP_Text keyText;

    // 톱니바퀴
    public int gears = 0;
    public TMP_Text gearText;
    public GameObject gearObject;

    // 라이프
    public int lives = 3;
    public TMP_Text lifeText;

    // 아이템 목록
    public List<string> items = new List<string>();

    // 처음 화면 표시
    void Start()
    {
        UpdateUI();
    }

    // UI 업데이트
    void UpdateUI()
    {
        if (keyText != null)
            keyText.text = "열쇠 " + keys;

        if (gearText != null)
            gearText.text = "톱니바퀴 " + gears;

        if (lifeText != null)
            lifeText.text = "목숨 " + lives;
    }

    // 열쇠 획득
    public void AddKey()
    {
        keys++;
        UpdateUI();
        Debug.Log("열쇠 획득!");
    }

    // 톱니바퀴 획득
    public void AddGear()
    {
        gears++;
        items.Add("Gear");

        UpdateUI();

        Debug.Log("톱니바퀴 획득!");

        if (gearObject != null)
        {
            Destroy(gearObject);
        }
    }

    // 톱니바퀴 사용
    public bool UseGear()
    {
        if (gears <= 0)
        {
            Debug.Log("톱니바퀴가 없어!");
            return false;
        }

        gears--;

        if (items.Contains("Gear"))
        {
            items.Remove("Gear");
        }

        UpdateUI();

        Debug.Log("톱니바퀴 사용!");
        return true;
    }

    // 메디컬 박스 획득
    public void AddMedicalBox()
    {
        lives++;

        UpdateUI();

        Debug.Log("라이프 1개 획득!");
    }
}
