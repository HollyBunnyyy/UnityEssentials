using System.Collections.Generic;
using UnityEngine;

public class GridMap<T>
{
    public readonly int Width;
    public readonly int Height;

    public readonly Vector2 CellGap;
    public readonly Vector2 CellSize;

    public Vector2 CellArea     => CellSize + CellGap;
    public Vector2 CellCenter   => CellArea / 2.0f;
    public Vector2 Origin       => new Vector2( Width * CellCenter.x, Height * CellCenter.y ) - CellCenter;

    private T[,] _tileGrid;

    public T this[int x, int y]
    {
        get => _tileGrid[x, y];
        set => _tileGrid[x, y] = value;

    }

    public GridMap( int width, int height )
    {
        this.Width  = width;
        this.Height = height;

        this._tileGrid = new T[width, height];

        for( int x = 0; x < width; x++ )
        {
            for( int y = 0; y < height; y++ )
            {
                _tileGrid[x, y] = default;

            }
        }

    }

    public GridMap( int width, int height, Vector2 cellSize, Vector2 cellGap ) : this( width, height )
    {
        this.CellSize = cellSize;
        this.CellGap  = cellGap;

    }

    /// <summary>
    /// Returns whether the given index is in the grid.
    /// </summary>
    public bool IsIndexInMap( int x, int y ) 
    { 
        return x >= 0 && y >= 0 && x < Width && y < Height; 

    }

    /// <summary>
    /// Converts a worldspace position to tilespace coordinates.
    /// </summary>
    public Vector2Int WorldToTilePosition( Vector3 worldPosition )
    {
        Vector2Int cellPositionOnGrid = new Vector2Int()
        {
            x = Mathf.RoundToInt( ( worldPosition.x + Origin.x ) / CellSize.x ),
            y = Mathf.RoundToInt( ( worldPosition.y + Origin.y ) / CellSize.y )

        };

        return cellPositionOnGrid;

    }


    /// <summary>
    /// Returns the tile's object from the given world position.
    /// </summary>
    public T WorldToTile( Vector3 worldPosition )
    {
        Vector2Int positionToGrid = WorldToTilePosition( worldPosition );

        if( !IsIndexInMap( positionToGrid.x, positionToGrid.y ) )
        {
            return default;

        }

        return this[positionToGrid.x, positionToGrid.y];

    }

    /// <summary>
    /// Returns a list of valid surrounding tiles within the grid around the index of x and y.
    /// </summary>
    public List<T> GetSurroundingTiles( int x, int y, DirectionType directionType )
    {
        List<T> surroundingNodes = new List<T>();

        foreach( Direction2D direction in directionType )
        {
            int xIndex = x + Mathf.FloorToInt( direction.X );
            int yIndex = y + Mathf.FloorToInt( direction.Y );

            if( IsIndexInMap( xIndex, yIndex ) )
            {
                surroundingNodes.Add( this[xIndex, yIndex] );

            }
        }

        return surroundingNodes;

    }

    /// <summary>
    /// Returns a list of valid surrounding tiles within the grid around the worldposition.
    /// </summary>
    public List<T> GetSurroundingTiles( Vector3 worldPosition, DirectionType directionType )
    {
        Vector2Int positionToGrid = WorldToTilePosition( worldPosition );

        return GetSurroundingTiles( positionToGrid.x, positionToGrid.y, directionType );

    }

    /// <summary>
    /// Returns a dictionary with corresponding tile objects mapped to their directions relative to the index of x and y.
    /// </summary>
    public Dictionary<Direction2D, T> GetSurroundingTileDirections( int x, int y, DirectionType directionType )
    {
        Dictionary<Direction2D, T> surroundingNodes = new Dictionary<Direction2D, T>();

        foreach( Direction2D direction in directionType )
        {
            int xIndex = x + Mathf.FloorToInt( direction.X );
            int yIndex = y + Mathf.FloorToInt( direction.Y );

            if( IsIndexInMap( xIndex, yIndex ) )
            {
                surroundingNodes.Add( direction, _tileGrid[xIndex, yIndex] );

            }
        }

        return surroundingNodes;

    }

    /// <summary>
    /// Returns a kvp dictionary with corresponding objects mapped to their directions relative to the given worldposition.
    /// </summary>
    public Dictionary<Direction2D, T> GetSurroundingTileDirections( Vector3 worldPosition, DirectionType directionType )
    {
        Vector2Int positionToGrid = WorldToTilePosition( worldPosition );

        return GetSurroundingTileDirections( positionToGrid.x, positionToGrid.y, directionType );

    }

    /// <summary>
    /// Returns a clamped value of the given world position to the nearest logical cell's center.
    /// </summary>
    public Vector3 ClampToTilePosition( Vector3 worldPosition )
    {
        Vector2 worldPositionConvertedToGrid = worldPosition;
        Vector2 clampedCellPosition = WorldToTilePosition( worldPositionConvertedToGrid - ( Origin + CellCenter ) );

        Vector3 clampedWorldPosition = clampedCellPosition;
        clampedWorldPosition.x *= CellSize.x;
        clampedWorldPosition.y *= CellSize.y;
        clampedWorldPosition.z = worldPosition.z;

        clampedWorldPosition.x += CellCenter.x;
        clampedWorldPosition.y += CellCenter.y;

        return clampedWorldPosition;

    }

}
