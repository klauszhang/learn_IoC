using System;
using System.Collections.Generic;

namespace MvcIoC.Models
{
  public class ProteinRespository : IProteinRespository
  {
    private ProteinData service=new ProteinData();

    public ProteinRespository()
    {
      service.Goal = 0;
      service.Total = 0;
      service.TimeCreated = new DateTime().Date;
    }

    public ProteinData GetData(DateTime date)
    {
      return service;
    }

    public void SetTotal(DateTime date, int value)
    {
      service.Total = value;
      service.TimeCreated = date;
    }

    public void SetGoal(DateTime date, int value)
    {
      service.Goal = value;
      service.TimeCreated = date;
    }
  }
}