using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Item")]
public class ItemDataSO : ScriptableObject
{
    public int _ID;
    public string _name;
    public Sprite _image;
}
