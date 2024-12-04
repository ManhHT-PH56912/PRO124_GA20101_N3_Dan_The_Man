// using UnityEngine;
// using UnityEngine.UI;
// using System.Collections.Generic;


// // Lớp tăng sát thương
// public class AttackItem : ShopItem
// {
//     protected PlayerHealth playerHealth;
//     private int attackIncrease;

//     public AttackItem(string name, int price, int attackIncrease) : base(name, price)
//     {
//         this.attackIncrease = attackIncrease;
//     }

//     public override void ApplyEffect(Player player)
//     {
//         player.Attack += attackIncrease;
//         Debug.Log($"{Name} applied. Attack increased by {attackIncrease}.");
//     }
// }

// // Lớp tăng giáp
// public class DefenseItem : ShopItem
// {
//     private int defenseIncrease;

//     public DefenseItem(string name, int price, int defenseIncrease) : base(name, price)
//     {
//         this.defenseIncrease = defenseIncrease;
//     }

//     public override void ApplyEffect(Player player)
//     {
//         player.Defense += defenseIncrease;
//         Debug.Log($"{Name} applied. Defense increased by {defenseIncrease}.");
//     }
// }

// // Lớp tăng máu
// public class HealthItem : ShopItem
// {
//     private int healthIncrease;

//     public HealthItem(string name, int price, int healthIncrease) : base(name, price)
//     {
//         this.healthIncrease = healthIncrease;
//     }

//     public override void ApplyEffect(Player player)
//     {
//         player.Health += healthIncrease;
//         Debug.Log($"{Name} applied. Health increased by {healthIncrease}.");
//     }
// }

// // Lớp quản lý shop
// public class ShopManager : MonoBehaviour
// {
//     public GameObject buttonPrefab;
//     public Transform buttonContainer;
//     public Text itemDescriptionText;

//     private Player player;
//     private ScoreManager scoreManager;
//     private List<IShopItem> shopItems = new List<IShopItem>();

//     void Start()
//     {
//         // Khởi tạo Player và ScoreManager
//         player = new Player(10, 5, 100); // Chỉ số ban đầu: Sát thương 10, Giáp 5, Máu 100
//         scoreManager = new ScoreManager(100); // Số dư ban đầu 100$

//         // Tạo danh sách vật phẩm
//         shopItems.Add(new AttackItem("Sword", 30, 5));
//         shopItems.Add(new DefenseItem("Shield", 40, 10));
//         shopItems.Add(new HealthItem("Potion", 20, 50));

//         // Tạo nút động trong shop
//         GenerateShopButtons();
//     }

//     private void GenerateShopButtons()
//     {
//         foreach (var item in shopItems)
//         {
//             GameObject newButton = Instantiate(buttonPrefab, buttonContainer);

//             // Cập nhật text hiển thị trên nút
//             Text buttonText = newButton.GetComponentInChildren<Text>();
//             buttonText.text = $"{item.Name} - {item.Price}$";

//             // Gán sự kiện khi nhấn nút
//             Button button = newButton.GetComponent<Button>();
//             button.onClick.AddListener(() => OnItemClicked(item));
//         }
//     }

//     private void OnItemClicked(IShopItem item)
//     {
//         // Hiển thị thông tin vật phẩm
//         itemDescriptionText.text = $"Item: {item.Name}\nPrice: {item.Price}$";

//         // Kiểm tra và thực hiện mua
//         if (scoreManager.DeductBalance(item.Price))
//         {
//             item.ApplyEffect(player);
//             Debug.Log($"Purchased {item.Name}. Remaining Balance: {scoreManager.GetBalance()}$");
//         }
//         else
//         {
//             Debug.LogError($"Not enough money to buy {item.Name}.");
//         }
//     }
// }
