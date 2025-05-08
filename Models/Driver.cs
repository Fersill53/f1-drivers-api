namespace F1DriversApi.Models

{
    public class Driver
    {
        public int Id { get; set; } 
        public int CarNumber{ get; set; }
        public string? Name { get; set; }
        public string? Team { get; set; }
        public string? Country { get; set; }
        public int Points { get; set; }

        public string? DriverPhotoUrl { get; set; }

        public string? CarPhotoUrl { get; set; } 
    }
}