using System.Collections.Generic;
using Demo_Boekhouding.ViewModels;

namespace Demo_Boekhouding.Services
{
    public interface IBoekhoudingDataService
    {
        IList<AankoopFactuur> GeefAankoopDagboek();
        IList<KasVerrichting> GeefKasboek();
        IList<VerkoopFactuur> GeefVerkoopDagboek();
        IList<AankoopFactuur> VerwijderAankoopFactuur(AankoopFactuur factuur);
        IList<AankoopFactuur> VoegAankoopFactuurToe(AankoopFactuur factuur);
        void WijzigAankoopFactuur(AankoopFactuur nieuwefactuur);
        IList<Klant> GeefAlleKlanten();
        IList<Leverancier> GeefAlleLeveranciers();
        //verder aan te vullen
    }
}