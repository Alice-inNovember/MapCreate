using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Script.Map
{
    public class TileGenerator : MonoBehaviour
    {
        public GameObject tilePrefab;
        [SerializeField] private const int MapSize = 18;
        [SerializeField] private GameObject[,] _tileObjArray = new GameObject[MapSize, MapSize];
        [SerializeField] private Tile[,] _tileArray = new Tile[MapSize, MapSize];
        void Start()
        {
            for (var x = 0; x < MapSize; x++)
            {
                for (var y = 0; y < MapSize; y++)
                {
                    _tileObjArray[x,y] = Instantiate(tilePrefab, this.transform);
                    _tileArray[x, y] = _tileObjArray[x, y].GetComponent<Tile>();
                }
            }

            for (int i = 0; i < 5; i++)
            {
                CreationStep();
            }
        }

        private void CreationStep()
        {
            
        }
    }
}
