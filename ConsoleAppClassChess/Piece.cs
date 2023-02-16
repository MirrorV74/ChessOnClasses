namespace ConsoleAppClassChess;

class Piece
{
    public int _id;
    public int _coordinateX;
    public int _coordinateY;
    public string _consoleChar;
    public string _type;
    public bool _moved;
    public ConsoleColor _color;

    public Piece(int id, int coordinateX, int coordinateY, string consoleChar, string type, bool moved, ConsoleColor color)
    {
        _id = id;
        _coordinateX = coordinateX;
        _coordinateY = coordinateY;
        _consoleChar = consoleChar;
        _type = type;
        _moved = moved;
        _color = color;
    }

    public override string ToString()
    {
        return $"id: {_id} coordinateX: {_coordinateX} coordinateY: {_coordinateY} consoleChar: {_consoleChar} type: {_type} moved: {_moved} color: {_color}";
    }
}