using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MapData")]
public class MapData : ScriptableObject
{
    [SerializeField] List<MapDatabase> _datas;
    public List<MapDatabase> Datas => _datas;
}

[System.Serializable]
public class MapDatabase
{
    [SerializeField, Tooltip("区画の初期サイズ")] Vector2 _eriaSize;
    [SerializeField, Tooltip("区画の最小数")] int _minEriaNum;
    [SerializeField, Tooltip("区画の最小サイズ")] int _minEriaSize;
    /// <summary>区画の初期サイズ</summary>
    public Vector2 EriaSize => _eriaSize;
    /// <summary>区画の最小数</summary>
    public int MinEeriaNum => _minEriaNum;
    /// <summary>区画の最小サイズ</summary>
    public int MinEriaSize => _minEriaSize;
}
