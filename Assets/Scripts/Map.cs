using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

/// <summary>
/// mapü‚è‚Ì–‚ğ‚·‚é
/// </summary>
public class Map : MonoBehaviour
{
    [SerializeField] MapCell _cell;
    [SerializeField] Transform _cellParent;
    [SerializeField] int _xSize;
    [SerializeField] int _ySize;
    [SerializeField] float _cellInterval;
    [SerializeField] Vector2 _basepoint;
    private MapCell[,] _cells;

    void Start()
    {
        Create();
    }

    /// <summary>
    /// Map‚Ì¶¬
    /// </summary>
    private void Create()
    {
        //cell‚Ì¶¬
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

        //cell‚É–¼‘O‚Â‚¯‚é@¶¬‚Æ“¯‚É‚â‚Á‚½‚ç‚¤‚Ü‚­‚¢‚©‚È‚©‚Á‚½‚Ì‚Å•ª‚¯‚½
        for (int y = 0; y < _ySize; y++)
        {
            for (int x = 0; x < _xSize; x++)
            {
                _cells[x, y].gameObject.name = $"cell:{x},{y}";
            }
        }
    }
}
