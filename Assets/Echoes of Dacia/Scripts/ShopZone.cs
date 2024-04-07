using UnityEngine;

public class ShopZone : MonoBehaviour, IInteractable
{
    public GameObject shopPanel; // Assign the shop UI panel in the inspector

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && shopPanel.activeSelf)
        {
            CloseShop();
        }
    }

    public void Interact()
    {
        shopPanel.SetActive(true);
    }

    private void CloseShop()
    {
        shopPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact();
            }
        }
    }
}
