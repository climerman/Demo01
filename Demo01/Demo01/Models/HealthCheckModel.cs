namespace Demo01.Models
{
    public class HealthCheckModel
    {
        public string environment { get; set; }
        public bool db { get; set; }
        public string configErrors { get; set; }
    }
}
