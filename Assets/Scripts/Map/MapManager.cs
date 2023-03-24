using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

/// <summary>
/// map����̎�������
/// </summary>
public class MapManager : MonoBehaviour
{
    [SerializeField] MapCell _cell;
    [SerializeField] Transform _cellParent;
    [SerializeField] MapData _mapData;
    [SerializeField] int _xSize;
    [SerializeField] int _ySize;
    [SerializeField] float _cellInterval;
    [SerializeField] Vector2 _basepoint;
    private MapCell[,] _cells;
    private List<Eria> _erias;

    void Start()
    {
        EriaDivision(_mapData.Datas[0]);
        //Create();
    }

    /// <summary>
    /// ���̕���
    /// </summary>
    private void EriaDivision(MapDatabase mapData)
    {
        int rx = Random.Range(mapData.MinEriaSize, (int)mapData.EriaSize.x - mapData.MinEriaSize);
        int ry = Random.Range(mapData.MinEriaSize, (int)mapData.EriaSize.y - mapData.MinEriaSize);
    }

    /// <summary>
    /// Map�̐���
    /// </summary>
    private void Create()
    {
        //cell�̐���
        _cells = new MapCell[_xSize, _ySize];
        for (int y = 0; y < _ySize; y++)
        {
            for (int x = 0; x < _xSize; x++)
            {
                MapCell cell = MapCell.Init(_cell, new Vector2(_basepoint.x + _cellInterval * x, _basepoint.y + _cellInterval * y), _cellParent);
                //_cell.name = $"cell {x},{y}";
                _cells[x, y] = cell;
            }
        }

        //cell�ɖ��O����@�����Ɠ����ɂ�����炤�܂������Ȃ������̂ŕ�����
        for (int y = 0; y < _ySize; y++)
        {
            for (int x = 0; x < _xSize; x++)
            {
                _cells[x, y].gameObject.name = $"cell:{x},{y}";
            }
        }
    }
}
