
using UnityEngine;

public class GearReceiver : MonoBehaviour
{
    public Inventory inventory;
    public GameObject ironGate;

    public void InsertGear()
    {
        if (inventory == null || ironGate == null)
        {
            Debug.Log("연결이 빠졌어!");
            return;
        }

        if (inventory.UseGear())
        {
            Destroy(ironGate);
            Debug.Log("철창이 열렸어!");
        }
    }
}
