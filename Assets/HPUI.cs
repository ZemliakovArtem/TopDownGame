using UnityEngine;
using TMPro;

public class HPUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI hpText;

    void Update()
    {
        hpText.text = "HP: " + playerHealth.hp;
    }
}