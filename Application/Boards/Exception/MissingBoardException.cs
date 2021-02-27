using System;

namespace Application.Boards
{
  public class MissingBoardException : Exception
  {
    public MissingBoardException() : base("No active board was found.") { }
  }
}