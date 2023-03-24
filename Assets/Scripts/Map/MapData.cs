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
    [SerializeField, Tooltip("���̏����T�C�Y")] Vector2 _eriaSize;
    [SerializeField, Tooltip("���̍ŏ���")] int _minEriaNum;
    [SerializeField, Tooltip("���̍ŏ��T�C�Y")] int _minEriaSize;
    /// <summary>���̏����T�C�Y</summary>
    public Vector2 EriaSize => _eriaSize;
    /// <summary>���̍ŏ���</summary>
    public int MinEeriaNum => _minEriaNum;
    /// <summary>���̍ŏ��T�C�Y</summary>
    public int MinEriaSize => _minEriaSize;
}
