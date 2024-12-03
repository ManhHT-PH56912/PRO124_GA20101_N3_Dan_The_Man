using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ShopManager : MonoBehaviour
{
    [System.Serializable]
    public class ShopItem
    {
        public string itemName; // Tên sản phẩm
        public int itemPrice;   // Giá sản phẩm
    }

    public int playerBalance = 100; // Số tiền ban đầu của người chơi

    public List<ShopItem> shopItems; // Danh sách sản phẩm trong shop
    public GameObject buttonPrefab;  // Prefab cho các nút sản phẩm
    public Transform buttonContainer; // Vị trí chứa các nút trong UI

    void Start()
    {
        // Tạo các nút sản phẩm động
        GenerateShopButtons();
    }

    public void SelectItem(int itemCost, string itemName)
    {
        if (CheckBalance(itemCost))
        {
            ConfirmPurchase(itemCost, itemName);
        }
        else
        {
            ShowError("Not enough money to buy " + itemName);
        }
    }

    private bool CheckBalance(int cost)
    {
        return playerBalance >= cost;
    }

    private void ConfirmPurchase(int cost, string itemName)
    {
        DeductMoney(cost);
        ApplyItemEffects(itemName);
        ShowSuccessMessage(itemName);
    }

    private void DeductMoney(int amount)
    {
        playerBalance -= amount;
        Debug.Log("Money deducted. New balance: " + playerBalance);
    }

    private void ApplyItemEffects(string itemName)
    {
        Debug.Log("Applied effects of: " + itemName);
        // Thêm hiệu ứng của item vào đây
    }

    private void ShowSuccessMessage(string itemName)
    {
        Debug.Log("Purchase successful: " + itemName);
    }

    private void ShowError(string message)
    {
        Debug.LogError(message);
    }

    private void GenerateShopButtons()
    {
        foreach (ShopItem item in shopItems)
        {
            // Tạo một nút mới từ prefab
            GameObject newButton = Instantiate(buttonPrefab, buttonContainer);

            // Cập nhật text hiển thị trên nút
            Text buttonText = newButton.GetComponentInChildren<Text>();
            buttonText.text = $"{item.itemName} - {item.itemPrice}$";

            // Lấy component Button và gán sự kiện
            Button buttonComponent = newButton.GetComponent<Button>();
            int price = item.itemPrice;
            string name = item.itemName;

            buttonComponent.onClick.AddListener(() => SelectItem(price, name));
        }
    }
}