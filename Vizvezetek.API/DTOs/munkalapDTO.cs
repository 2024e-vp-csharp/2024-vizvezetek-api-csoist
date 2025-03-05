namespace Vizvezetek.API.DTOs
{
    public class munkalapDTO
    {
        public munkalapDTO(int id, DateOnly beadasi_datum, DateOnly javitasi_datum, string telepules, string utca, string szerelo, int munkaora, int anyagar)
        {
            Id = id;
            Beadasi_datum = beadasi_datum;
            Javitasi_datum = javitasi_datum;
            Helyszin = telepules + ", " + utca;
            Szerelo = szerelo;
            Munkaora = munkaora;
            Anyagar = anyagar;
        }

        public int Id { get; set; }
        public DateOnly Beadasi_datum { get; set; }
        public DateOnly Javitasi_datum { get; set; }
        public string Helyszin { get;set; }
        public string Szerelo { get; set; }
        public int Munkaora { get; set; }
        public int Anyagar { get; set; }

    }
}
