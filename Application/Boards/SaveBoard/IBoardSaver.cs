using Domian.Entities;
namespace Application.Boards.SaveBoard
{
    public interface IBoardSaver
    {
        bool HasBoard();
        Board Get();
        void Set(Board board);
    }
}
