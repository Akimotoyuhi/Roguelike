using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;
//using DG.Tweening;

public class MapCell : MonoBehaviour
{
    [SerializeField] SpriteRenderer _sr;
    [SerializeField] Sprite _sprite;
    private CellState _state;

    public void Setup()
    {

    }

    public static MapCell Init(MapCell original, Vector2 position, Transform parent)
    {
        MapCell ret = Instantiate(original, position, Quaternion.identity);
        ret.Setup();
        ret.transform.position = position;
        ret.transform.SetParent(parent);
        return ret;
    }
}

public enum CellState
{
    none = -1,
    Wall,
    Floor,
}