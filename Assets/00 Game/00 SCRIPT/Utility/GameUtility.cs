using UnityEngine;


public static class GameUtility
{
    // Phương thức tiện ích để di chuyển GameObject đến vị trí mới
    public static void MoveTo(GameObject obj, Vector3 newPosition)
    {
        obj.transform.position = newPosition;
    }

    // Phương thức tiện ích để thay đổi kích thước GameObject
    public static void Resize(GameObject obj, Vector3 newSize)
    {
        obj.transform.localScale = newSize;
    }

    // Phương thức tiện ích để bật/tắt GameObject
    public static void SetActive(GameObject obj, bool isActive)
    {
        obj.SetActive(isActive);
    }
}
