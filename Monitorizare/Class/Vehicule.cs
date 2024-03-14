using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorizare.Class
{
    public class Vehicule
    {
        public long? Id { get; set; }
        public string? TipVehicul { get; set; }
        public string? NrRutei { get; set; }
        public string? Locatia { get; set; }
        public string? Disponibil { get; set; }
        public string? Utilizat { get; set; }
        public string? Functionare { get; set; }
        public string? TimpulSosire { get; set; }
        public string? ProblemeTehnice { get; set; }
        public double NivelCombustibil { get; set; }
        public string? PunctInteres { get; set; }
        public int NrCalatori { get; set; }
        public string? ZonaRisc { get; set; }
        public double Viteza { get; set; }
        public Vehicule(string tipVehicul, string nrRutei, string locatia, string disponibil, string utilizat, string functionare, string timpSosire, string problemeTehnice, double nivelCombustibil, string punctInteres, int nrCalatori, string zonaRisc, double viteza)
        {
            TipVehicul = tipVehicul;
            NrRutei = nrRutei;
            Locatia = locatia;
            Disponibil = disponibil;
            Utilizat = utilizat;
            Functionare = functionare;
            TimpulSosire = timpSosire;
            ProblemeTehnice = problemeTehnice;
            NivelCombustibil = nivelCombustibil;
            PunctInteres = punctInteres;
            NrCalatori = nrCalatori;
            ZonaRisc = zonaRisc;
            Viteza = viteza;
        }
        public Vehicule(long id, string tipVehicul, string nrRutei, string locatia, string disponibil, string utilizat, string functionare, string timpSosire, string problemeTehnice, double nivelCombustibil, string punctInteres, int nrCalatori, string zonaRisc, double viteza) : this(tipVehicul, nrRutei, locatia, disponibil, utilizat, functionare, timpSosire, problemeTehnice, nivelCombustibil, punctInteres, nrCalatori, zonaRisc, viteza)
        {
            Id = id;
        }
        public Vehicule() { }
    }
}
