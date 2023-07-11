namespace Congratulator.Models
{
    public class People
    {
        public int Id { get; set; }
        public byte[]? Photo { get; set; } // Тип byte[] используется для хранения фотографии в виде байтового массива
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
