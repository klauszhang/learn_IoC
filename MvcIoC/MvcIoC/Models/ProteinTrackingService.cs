using System;

namespace MvcIoC.Models
{
  public class ProteinTrackingService : IProteinTrackingService
  {
    IProteinRespository _repository;

    public ProteinTrackingService(IProteinRespository repository)
    {
      _repository = repository;
    }

     public int Total
    {
      get { return _repository.GetData(new DateTime().Date).Total; }
      set { _repository.SetTotal(new DateTime().Date, value); }
    }

    public int Goal {
      get { return _repository.GetData(new DateTime().Date).Goal; }
      set { _repository.SetGoal( new DateTime().Date,value); }
    }

    public DateTime TimeCreated { get; set; }

    public void AddProtein(int amount)
    {
      Total += amount;
    }
  }
}