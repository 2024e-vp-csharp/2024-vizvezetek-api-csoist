using Vizvezetek.API.DTOs;
using Vizvezetek.API.Models;

namespace Vizvezetek.API.Conversion
{
    public static class Conversion
    {
        public static munkalapDTO ToDTO(this munkalap munkalap)
        {
            return new munkalapDTO(munkalap.id, munkalap.beadas_datum, munkalap.javitas_datum, munkalap.hely.telepules, munkalap.hely.utca, munkalap.szerelo.nev, munkalap.munkaora, munkalap.anyagar);
        }

        public static List<munkalapDTO> ToDTO(this IEnumerable<munkalap> munkalap)
        {
            return munkalap.Select(ToDTO).ToList();
        }
    }
}
