using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentPointsText;
    [SerializeField] private Button[] itemButtons;
    [SerializeField] private int[] itemCosts;

    private ScoreData scoreData;

    private void Start()
    {
        scoreData = new ScoreData();
        UpdateUI();
    }

    public void PurchaseItem(int itemIndex)
    {
        if (itemIndex < 0 || itemIndex >= itemCosts.Length) return;

        int cost = itemCosts[itemIndex];
        if (scoreData.CurrentScore >= cost)
        {
            scoreData.CurrentScore -= cost;
            OnPurchaseSuccess(itemIndex);
            UpdateUI();
        }
        else
        {
            OnPurchaseFailed();
        }
    }

    private void OnPurchaseSuccess(int itemIndex)
    {
        Debug.Log($"Item {itemIndex} purchased successfully!");
        // Add item to inventory logic here
    }

    private void OnPurchaseFailed()
    {
        Debug.Log("Not enough points to purchase!");
    }

    private void UpdateUI()
    {
        currentPointsText.text = $"Points: {scoreData.CurrentScore}";
        
        for (int i = 0; i < itemButtons.Length; i++)
        {
            itemButtons[i].interactable = scoreData.CurrentScore >= itemCosts[i];
        }
    }
}