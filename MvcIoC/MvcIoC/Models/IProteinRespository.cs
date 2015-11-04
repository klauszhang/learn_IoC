using System;

namespace MvcIoC.Models
{
  public interface IProteinRespository
  {
    ProteinData GetData(DateTime date);
    void SetGoal(DateTime date, int value);
    void SetTotal(DateTime date, int value);
  }
}