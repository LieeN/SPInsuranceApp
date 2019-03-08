using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BLKlasser;
using DataLayer;

namespace BusinessLayer
{
    public class BusinessManager
    {
        DataManager dm = new DataManager();

        #region Create funktioner
        // Funktion 1 - Lägger till personal
        public void SkapaPersonal(string rollNamn, Personal nyPersonal)
        {
            dm.SkapaPersonal(rollNamn, nyPersonal);
        }

        // Funktion 2 - Lägger till behörighet och roll
        public void SkapaBehörighet(Behörighet nyBehörighet, Roll nyRoll)
        {
            dm.SkapaBehörighet(nyBehörighet, nyRoll);
        }

        //Funktion 3 Lägger till företagsansökan
        public void SkapaFöretagsAnsökan(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            dm.SkapaFöretagsAnsökan(ID, nyFöretagsansökan, nyFörsäkringstagareFöretag);
        }

        //Funktion 4 - Lägger till privatansökan
        public void SkapaPrivatAnsökan(int ID, string Försäkringstyp, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {
            dm.SkapaPrivatAnsökan(ID, Försäkringstyp, nyPrivatansökan, nyFörsäkringstagarePrivat);
        }

        //Funktion 5 - Lägger till grundbelopp
        public void SkapaGrundbelopp(Grundbelopp nyGrundbelopp, string FörsäkringsTyp)
        {
            dm.SkapaGrundbelopp(nyGrundbelopp, FörsäkringsTyp);
        }

        //Funktion 6 - Lägger till försäkringstyp
        public void SkapaFörsäkringstyp(FörsäkringsTyp nyFörsäkringstyp)
        {
            dm.SkapaFörsäkringstyp(nyFörsäkringstyp);
        }

        //Funktion 7 - Lägger till tillval
        public void SkapaTillval(Tillval nyTillval)
        {
            dm.SkapaTillval(nyTillval);
        }

        //Funktion 8 - Lägger till tillvalsbelopp
        public void SkapaTillvalsbelopp(TillvalGrundbelopp nyTillvalsgrundbelopp, string Tillval)
        {
            dm.SkapaTillvalsbelopp(nyTillvalsgrundbelopp, Tillval);
        }

        // Funktion 9 - Lägg till provisionstabellvärden
        public void SkapaProvisionstabell(Provisionstabell nyProvisiontabell)
        {
            dm.SkapaProvisionstabell(nyProvisiontabell);
        }
        // Funktion 10 - Lägg till semesterersättning
        public void SkapaSemesterersättning(Semesterersättning nySemesterersättning)
        {
            dm.SkapaSemesterersättning(nySemesterersättning);
        }

        // Funktion 11 - Lägg till företagsförsäkring
        public void SkapaFöretagFörsäkring(int ID, FörsäkringFöretag nyFöretagsFörsäkring)
        {
            dm.SkapaFöretagFörsäkring(ID, nyFöretagsFörsäkring);
        }

        public void SkapaUpdateFöretagFörsäkring(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            dm.SkapaUpdateFöretagFörsäkring(ID, nyFöretagsansökan, nyFörsäkringstagareFöretag);
        }

        // Funktion 12 - Skapa privatförsäkring
        public void SkapaPrivatFörsäkring(int ID, Försäkring nyPrivatFörsäkring)
        {
            dm.SkapaPrivatFörsäkring(ID, nyPrivatFörsäkring);
        }

        public void SkapaUpdatePrivatFörsäkring(int ID, string Försäkringstyp, int AgentturNr, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {
            dm.SkapaUpdatePrivatFörsäkring(ID, Försäkringstyp, AgentturNr, nyPrivatansökan, nyFörsäkringstagarePrivat);
        }

        #endregion

        #region Read funktioner
        //Funktion 1 - Visa behörighet och roll       
        public List<BehörighetRollNamn> VisaBehörighetRollNamn()
        {
            return dm.dmVisaBehörighetRollNamn();
        }

        //Funktion 2 - Visa Personal och roll 
        public List<PersonalRoll> VisaPersonalRoll()
        {
            return dm.dmVisaPersonalRoll();
        }

        //Funktion 3 - Visa försäkringstyp och grundbelopp
        public List<FörsäkringTypsGrundbelopp> VisaFörsäkringTypsGrundbelopp(string FörsäkringsTyp)
        {
            return dm.VisaFörsäkringTypsGrundbelopp(FörsäkringsTyp);
        }


        //Funktion 4 - Visa tillval och tillvalsbelopp
        public List<TillvalTillvalsbelopp> VisaTillvalTillvalsbelopp(string Tillval)
        {
            return dm.VisaTillvalTillvalsbelopp(Tillval);
        }

        //Funktion 5 - Visa säljarens provision 
        public List<Säljare> HämtaSäljare(string fNamn)
        {

            return dm.HämtaSäljare(fNamn);
        }

        // Funktion 6 - Visa grundbelopp för vald försäkringstyp
        public List<Grundbelopp> VisaFörsäkringstyp(string FörsäkringsTyp)
        {
            return dm.VisaFörsäkringstyp(FörsäkringsTyp);
        }

        //Funktion 7 - Visa företagsansökan med försäkringstagare
        public List<FöretagsansökanFörsäkringstagare> VisaFöretagsansökanFörsäkringstagare()
        {
            return dm.VisaFöretagsansökanFörsäkringstagare();
        }

        // Funktion 9 - Visa privatansökan och försäkringstagareprivat med dess försäkringstyper och grundbelopp samt tillval och dess grundbelopp
        public List<PrivatansökanFörsäkringstagareprivat> VisaPrivatansökanFörsäkringstagareprivat()
        {
            return dm.VisaPrivatansökanFörsäkringstagareprivat();
        }

        //Funktion 10 - Visa tillsvalsgrundbelopp
        public List<TillvalGrundbelopp> VisaTillval(string Tillval)
        {
            return dm.VisaTillval(Tillval);
        }

        // Funktion 11 - Visa provisionsvärdetabell
        public List<Provisionstabell> VisaProvisionstabell()
        {
            return dm.VisaProvisionstabell();
        }

        // Funktion 12 - Visa semesterersättning
        public List<Semesterersättning> VisaSemesterersättning()
        {
            return dm.VisaSemesterersättning();
        }

        //Funktion 13 - Sök företagsansökan med försäkringstagare
        public List<SökFöretagsansökanFörsäkringstagare> SökaFöretagsansökanFörsäkringstagare(long orgNr, string FöretagsNamn)
        {
            return dm.SökaFöretagsansökanFörsäkringstagare(orgNr, FöretagsNamn);
        }

        //Funktion 14 - Visa Företagsförsäkring och dess Försäkringstagare
        public List<FörsäkringFöretagsansökanFörsäkringstagare> VisaFörsäkringFöretagsansökanFörsäkringstagare()
        {
            return dm.VisaFörsäkringFöretagsansökanFörsäkringstagare();
        }

        // Funktion 15 - Visa Privatförsäkring och försäkringstagareprivat med dess försäkringstypper och grundbelopp samt tillval och dess grundbelopp
        public List<FörsäkringPrivatansökanFörsäkringstagareprivat> VisaFörsäkringFörsäkringstagarePrivat()
        {
            return dm.VisaFörsäkringFörsäkringstagarePrivat();
        }

        //Funktion 16 - Visa privatregister
        public List<Privatregister> VisaPrivatregister()
        {
            return dm.VisaPrivatregister();
        }

        //Funktion 17 - Visa företagsregister
        public List<Företagsregister> VisaFöretagsregister()
        {
            return dm.VisaFöretagsregister();
        }

        //Funktion 18 - Visa användaren som är inloggad till Min Profil
        public List<PersonalRoll> HämtaInloggningsprofil(string fNamn)
        {

            return dm.HämtaInloggadminprofil(fNamn);
        }

        // Funktion 19 - Hämta Barn ackvärde beroende på valt år, månad, säljarens förnamn samt att det är en barnförsäkring
        public double HämtaBaAckvärde(int Year, int Month, string fNamn)
        {
            return dm.HämtaBaAckvärde(Year, Month, fNamn);
        }

        // Funktion 19 - Hämta Vuxen ackvärde beroende på valt år, månad, säljarens förnamn samt att det är en vuxenförsäkring
        public double HämtaVuAckvärde(int Year, int Month, string fNamn)
        {
            return dm.HämtaVuAckvärde(Year, Month, fNamn);
        }

        //Funktion 19 - Hämta provisionsvariabler barn
        public double HämtaProvisionVariablerBarn(double sumAckvärde, string Year)
        {
            return dm.HämtaProvisionVariablerBarn(sumAckvärde, Year);
        }

        //Funktion 19 - Hämta provisionsvariabler vuxen
        public double HämtaProvisionVariablerVuxen(double sumAckvärde, string Year)
        {
            return dm.HämtaProvisionVariablerVuxen(sumAckvärde, Year);
        }

        //Funktion 19 - Hämta semesterersättningsavdrag
        public double HämtaSemesterersättningAvdrag(string Year)
        {
            return dm.HämtaSemesterersättningAvdrag(Year);
        }


        // Funktion 19 - Hämta semesterersättningssats
        public double HämtaSemesterersättningSats(string Year)
        {
            return dm.HämtaSemesterersättningSats(Year);
        }

        // Funktion 19 - Hämta livssumma ackvärde beroende på valt år, månad, säljarens förnamn samt att det är en barnförsäkring
        public double HämtaLivsSummaAckvärde(int Year, int Month, string fNamn)
        {
            return dm.HämtaLivsSummaAckvärde(Year, Month, fNamn);
        }

        // Funktion 19 - Hämta livssumma grundbelopp beroende på valt år, månad, säljarens förnamn samt att det är en vuxenförsäkring
        public double HämtaLivsSummaGrundbelopp(int Year, int Month, string fNamn)
        {
            return dm.HämtaLivsSummaGrundbelopp(Year, Month, fNamn);
        }

        // Funktion 19 - Hämta prov övrigt summa provisionsbelopp beroende på valt år, månad, säljarens förnamn samt att det är en vuxenförsäkring
        public int HämtaProvÖvrigtSummaProvisionsbeloppPrivat(int Year, int Month, string fNamn)
        {
            return dm.HämtaProvÖvrigtSummaProvisionsbeloppPrivat(Year, Month, fNamn);
        }
        // Funktion 19 - Hämta prov övrigt summa provisionsbelopp företag beroende på valt år, månad, säljarens förnamn
        public int HämtaProvÖvrigtSummaProvisionsbeloppFöretag(int Year, int Month, string fNamn)
        {
            return dm.HämtaProvÖvrigtSummaProvisionsbeloppFöretag(Year, Month, fNamn);
        }

        // Funktion 19 - Hämta skattesats
        public double HämtaSkattesats(string fNamn)
        {
            return dm.HämtaSkattesats(fNamn);
        }

        //Funktion 20 - Sök person i privatregister
        public List<sökPersonPrivat> sökPersonPrivatregister(long persNr, string eNamn)
        {
            return dm.SökPersonPrivatregister(persNr, eNamn);
        }

        //Funktion 21 - Söka i företagsregister
        public List<sökPersonFöretag> sökpersonföretagsregister(long orgNr1, string företagsNamn)
        {
            return dm.sökpersonföretagsregister(orgNr1, företagsNamn);
        }

        //Funktion 22 - Söka privatansökningar
        public List<KlassSökPrivatAnsökan> sökprivatperson(long persNr, string eNamn)
        {
            return dm.sökPrivatAnsökan(persNr, eNamn);
        }

        //Funktion 23 - Sök privatförsäkringar
        public List<KlassSökPrivatFörsäkringar> Sökförsäkringprivat(long persNr, string eNamn)
        {
            return dm.SökförsäkringPrivat(persNr, eNamn);
        }
        //Funktion 24 - Sök företagsförsäkring
        public List<sökförsäkringföretag> Sökförsäkringföretag(long orgNr, string företagsNamn)
        {
            return dm.Sökförsäkringföretag(orgNr, företagsNamn);
        }

        //Funktion 25 - Sök befintlig försäkringstagare i skapa ansökan
        public List<KlassSökPrivatAnsökan> sökpersnummer(long persNr)
        {
            return dm.sökPersonNummer(persNr);
        }

        //Funktion 26 - Sök försäkrad i skapa ny ansökan
        public List<KlassSökPrivatAnsökan> sökpersnrförsäkrad(long persNr)
        {
            return dm.sökpersnrförsäkrad(persNr);
        }

        //Funktion 27 - Sök företag i skapa ny företagsansökan
        public List<sökPersonFöretag> sökorgnamn(string företagsNamn)
        {
            return dm.sökoOrganisationsNamn(företagsNamn);
        }

        // Funktion 28 - Hämta försäkringsprospekt
        public List<FörsäkringtagareProspekt> HämtaFörsäkringsProspekt()
        {
            return dm.HämtaFörsäkringsProspekt();
        }

        // Funktion 29 - Hämta AckVärdenBarn för trend 
        //public List<AckVärdenBarn> Hämtaackvärden(int Year)
        public Trend Hämtaackvärden(int Year)
        {
            Trend trend = new Trend();
            foreach(AckVärdenBarn a in dm.HämtaAckvärdenBarn(Year))
                trend.LäggTill(a.anstId, a.fNamn, a.eNamn, a.typ, a.månad, a.ackVärdeSumma);
            return trend;
        }

        //Funktion 29 - Hämta AckVärdenTotalt för trend
        public List<AckVärdenTotalt> HämtaAckvärdenTotalt(int Year)
        {
            return dm.HämtaAckvärdenTotalt(Year);
        }

        //Funktion 31 - Hämta HämtaAckVärdeSummaBarnSOOFB för statistik
        public double HämtaAckVärdeSummaBarnSOOFB(int Year, int Month, string fNamn)
        {
            return dm.HämtaAckVärdenSummaBarnSOOFB(Year, Month, fNamn);
        }

        // Funktion 31 - Hämta HämtaAckVärdenSummaVuxenSOOFV för statistik 
        public double HämtaAckVärdenSummaVuxenSOOFV(int Year, int Month, string fNamn)
        {
            return dm.HämtaAckVärdenSummaVuxenSOOFV(Year, Month, fNamn);
        }

        // Funktion 31 - Hämta AckVärdenSummaVuxenLFFV för statistik 
        public double HämtaAckVärdenSummaVuxenLFFV(int Year, int Month, string fNamn)
        {
            return dm.HämtaAckVärdenSummaVuxenLFFV(Year, Month, fNamn);
        }

        // Funktion 31 - Hämta Antal SOOFB för statistik 
        public double HämtaAntalSOOFB(int Year, int Month, string fNamn)
        {
            return dm.HämtaAntalSOOFB(Year, Month, fNamn);
        }

        // Funktion 31 - Hämta antal SOOFV för statistik 
        public double HämtaAntalSOOFV(int Year, int Month, string fNamn)
        {
            return dm.HämtaAntalSOOFV(Year, Month, fNamn);
        }

        // Funktion 31 - Hämta antal LFFV för statistik 
        public double HämtaAntalLFFV(int Year, int Month, string fNamn)
        {
            return dm.HämtaAntalLFFV(Year, Month, fNamn);
        }

        // Funktion 31 - Hämta antal ÖPF för statistik 
        public double HämtaAntalÖPF(int Year, int Month, string fNamn)
        {
            return dm.HämtaAntalÖPF(Year, Month, fNamn);
        }

        // Funktion 31 - Hämta antal företagsförsäkringar
        public double HämtaAntalFöretagsFörsäkringar(int Year, int Month, string fNamn)
        {
            return dm.HämtaAntalFöretagsFörsäkringar(Year, Month, fNamn);
        }
        #endregion

        #region Update funktioner
        // Funktion 1 - Uppdatera personal med nya valda värden
        public void UppdateraPersonal(int ID, Personal nyPersonal, string RollNamn)
        {
            dm.UppdateraPersonal(ID, nyPersonal, RollNamn);
        }

        // Funktion 2 - Uppdatera behörighet med nya valda värden
        public void UppdateraBehörighet(int ID, int BehörighetsTyp, string RollNamn)
        {
            dm.UppdateraBehörighet(ID, BehörighetsTyp, RollNamn);
        }

        // Funktion 3 - Uppdatera Företagsansökan med nya valda värden
        public void UppdateraFöretagsansökan(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            dm.UppdateraFöretagsansökan(ID, nyFöretagsansökan, nyFörsäkringstagareFöretag);
        }
        // Funktion 4 - Uppdatera privatansökan med nya valda värden
        public void UppdateraPrivatansökan(int ID, string FörsäkringsTyp, int AgentturNr, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {
            dm.UppdateraPrivatansökan(ID, FörsäkringsTyp, AgentturNr, nyPrivatansökan, nyFörsäkringstagarePrivat);
        }

        // Funktion 5 - Uppdatera företagsförsäkring med nya valda värden
        public void UppdateraFöretagsFörsäkring(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag, FörsäkringFöretag nyFörsäkringFöretag)
        {
            dm.UppdateraFöretagsförsäkring(ID, nyFöretagsansökan, nyFörsäkringstagareFöretag, nyFörsäkringFöretag);
        }

        // Funktion 6 - Uppdatera privatförsäkring med nya valda värden
        public void UppdateraPrivatFörsäkring(int ID, string FörsäkringsTyp, int AgentturNr, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat, Försäkring nyFörsäkring)
        {
            dm.UppdateraPrivatFörsäkring(ID, FörsäkringsTyp, AgentturNr, nyPrivatansökan, nyFörsäkringstagarePrivat, nyFörsäkring);
        }

        //Funktion 7 - Uppdatera privatprofil med nya valda värden
        public void UppdateraPrivatprofil(long ID, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {
            dm.UppdateraPrivatprofil(ID, nyPrivatansökan, nyFörsäkringstagarePrivat);
        }

        //Funktion 8 - Uppdatera grundbelopp vid skapande av försäkring
        public void UpdateGrundbeloppFörsäkring(int ID, int Grundbelopp)
        {
            dm.UpdateGrundbeloppFörsäkring(ID, Grundbelopp);
        }

        //Funktion 9 - Updatera min profil med nya valda värden
        public void UppdateraMinProfil(int ID, Personal nyPersonal)
        {
            dm.UppdateraMinProfil(ID, nyPersonal);
        }

        //Funtion 10 - Update företagsprofil med nya valda värden
        public void UppdateraFöretagsprofil(int ID, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            dm.UppdateraFöretagsprofil(ID, nyFörsäkringstagareFöretag);
        }
        
            #endregion





        }
}

