using UnityEngine;

public class MedicalBoxReceiver : MonoBehaviour
{
    public Inventory inventory;
    public GameObject medicalBoxObject;

    public void GetMedicalBox()
    {
        if (inventory != null)
        {
            inventory.AddMedicalBox();
        }

        if (medicalBoxObject != null)
        {
            Destroy(medicalBoxObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}