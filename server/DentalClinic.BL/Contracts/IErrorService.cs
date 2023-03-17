namespace DentalClinic.BL.Contracts
{
    public interface IErrorService
    {
        Task DCLog(Exception ex);
    }
}
