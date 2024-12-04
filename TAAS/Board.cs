namespace TAAS;

public class Board
{
    public const int Height = 9;
    public const int Weight = 20;

    public MyRandom Random { get; private set; }
    public int TurnCount { get; set; }
    public Stack <Move?> Moves { get; set; }
    public (Tile tile, object? unit)[,] Tiles { get; private set; }


    public Board(int seed)
    {
        Random = new MyRandom(seed);
        TurnCount = 0;
        Moves = new Stack<Move>();
        Tiles = new (Tile tile, object? unit)[Height,Weight];

    }

}