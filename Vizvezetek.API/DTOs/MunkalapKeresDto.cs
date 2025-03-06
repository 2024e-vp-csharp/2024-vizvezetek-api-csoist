namespace Vizvezetek.API.DTOs
{
    public class MunkalapKeresDto
    {
        public int Helyszin_Id { get; set; }
        public int Szerelo_Id { get; set; }

        public MunkalapKeresDto(int helyszin_Id, int szerelo_Id)
        {
            Helyszin_Id = helyszin_Id;
            Szerelo_Id = szerelo_Id;
        }
    }
}
