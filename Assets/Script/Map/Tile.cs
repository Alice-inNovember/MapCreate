using System;
using UnityEngine;

namespace Script.Map
{
    public class Tile : MonoBehaviour
    {
        private MapType _type;
        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void UpdateType(MapType type)
        {
            _type = type;
            _spriteRenderer.color = _type switch
            {
                MapType.Null => Color.black,
                MapType.Plain => new Color(0.5f, 1, 0.5f),
                MapType.Forest => Color.green,
                MapType.RockyHill => Color.gray,
                MapType.Settlement => new Color(0.8f, 0.5f, 0.4f),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
