namespace MvcIoC.Models
{
  public interface IProteinTrackingService
  {
    int Goal { get; set; }
    int Total { get; set; }

    void AddProtein(int amount);
  }
}