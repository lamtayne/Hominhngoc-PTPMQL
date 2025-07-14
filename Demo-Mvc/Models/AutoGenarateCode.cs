namespace Demo_Mvc.Models
{
    public static class AutoGenerateId
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
