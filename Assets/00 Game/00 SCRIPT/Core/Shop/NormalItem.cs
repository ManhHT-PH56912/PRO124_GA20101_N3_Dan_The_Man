using UnityEngine;
using UnityEngine.UI;

public class NormalItem : ItemBase
{
    [SerializeField] Image _imageItem;
    [SerializeField] Text _nameItem;
    [SerializeField] Text _quantityItem;

    void Start()
    {
        if (_info.Equals(null)) return;
        _imageItem.sprite = _info._image;
        _nameItem.text = _info._name;
        _quantityItem.text = this._quantity.ToString();
    }

    void OnDrawGizmosSelected()
    {
        if (_info.Equals(null)) return;
        _imageItem.sprite = _info._image;
        _nameItem.text = _info._name;
        _quantityItem.text = this._quantity.ToString();
    }
}