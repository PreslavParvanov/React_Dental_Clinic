using DentalClinic.BL.Contracts;



namespace DentalClinic.BL.Service
{
    public class ErrorService : IErrorService
    {
        public async Task DCLog(Exception ex)
        {
            
            if (!Directory.Exists("Logs")) { Directory.CreateDirectory("Logs"); }
            var defaultPath = Path.GetDirectoryName("Logs");
            string errorDateTime = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            File.AppendAllText($"~/Log.txt", $"Error: {ex.Message} {ex.StackTrace}");
        }
    }
}
