using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace DataLayer
{
    public class DataManager
    {
        DataModelContainer db = new DataModelContainer();


        #region Create funktioner
        //Funktion 1 - Lägger till en personal
        public void SkapaPersonal(string rollNamn, Personal Personal)
        {
            using (var db = new DataModelContainer())
            {
                Roll query = (from x in db.RollSet
                              where x.rollNamn == rollNamn
                              select x).FirstOrDefault();

                Personal nyaPersonal = new Personal()
                {
                    persNr = Personal.persNr,
                    agenturNr = Personal.agenturNr,
                    skattesats = Personal.skattesats,
                    fNamn = Personal.fNamn,
                    eNamn = Personal.eNamn,
                    gatuAdress = Personal.gatuAdress,
                    ort = Personal.ort,
                    postNr = Personal.postNr,
                    tel1 = Personal.tel1,
                    tel2 = Personal.tel2,
                    email = Personal.email,
                    lösenord = Personal.lösenord
                };
                query.Personal.Add(nyaPersonal);

                db.SaveChanges();
            }

        }

        // Funktion 2 - Lägger till behörighet och Roll
        public void SkapaBehörighet(Behörighet nyBehörighet, Roll nyRoll)
        {
            using (var db = new DataModelContainer())
            {
                db.BehörighetSet.Add(new Behörighet
                {
                    behörighetsTyp = nyBehörighet.behörighetsTyp,
                    Roll = new List<Roll>()
                    {
                        new Roll()
                        {
                            rollNamn = nyRoll.rollNamn
                        }
                    }
                });
                db.SaveChanges();
            }
        }

        //Funktion 3 - Lägger till en företagsansökan
        public void SkapaFöretagsAnsökan(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            using (var db = new DataModelContainer())
            {
                Personal query = (from x in db.PersonalSet
                                  where x.agenturNr == ID
                                  select x).FirstOrDefault();

                Företagsansökan nyaFöretagsansökan = new Företagsansökan()
                {
                    försäkringsbolag = nyFöretagsansökan.försäkringsbolag,
                    begynnelsedatum = nyFöretagsansökan.begynnelsedatum,
                    förfallodag = nyFöretagsansökan.begynnelsedatum,
                    betalningsform = nyFöretagsansökan.betalningsform,
                    premie = nyFöretagsansökan.premie,
                    Anteckning = nyFöretagsansökan.Anteckning,
                    försäkringsTyp = nyFöretagsansökan.försäkringsTyp,
                    FörsäkringstagareFöretag = new FörsäkringstagareFöretag()
                    {
                        orgNr = nyFörsäkringstagareFöretag.orgNr,
                        företagsNamn = nyFörsäkringstagareFöretag.företagsNamn,
                        kFNamn = nyFörsäkringstagareFöretag.kFNamn,
                        kENamn = nyFörsäkringstagareFöretag.kENamn,
                        ort = nyFörsäkringstagareFöretag.ort,
                        postNr = nyFörsäkringstagareFöretag.postNr,
                        tel1 = nyFörsäkringstagareFöretag.tel1,
                        faxNr = nyFörsäkringstagareFöretag.faxNr,
                        email1 = nyFörsäkringstagareFöretag.email1,
                        gatuAdress = nyFörsäkringstagareFöretag.gatuAdress,
                    }
                };
                query.Företagsansökan.Add(nyaFöretagsansökan);
                db.SaveChanges();
            }
        }

        // Funktion 4 - Lägger till privatansökan
        public void SkapaPrivatAnsökan(int ID, string Försäkringstyp, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {
            using (var db = new DataModelContainer())
            {
                Personal query = (from x in db.PersonalSet
                                  where x.agenturNr == ID
                                  select x).FirstOrDefault();

                FörsäkringsTyp query1 = (from x in db.FörsäkringsTypSet
                                         where x.försäkringsTyp == Försäkringstyp
                                         select x).FirstOrDefault();


                Privatansökan nyaPrivatansökan = new Privatansökan()
                {
                    privatFörsäkradFNamn = nyPrivatansökan.privatFörsäkradFNamn,
                    privatFörsäkradENamn = nyPrivatansökan.privatFörsäkradENamn,
                    privatFörsäkradPersNr = nyPrivatansökan.privatFörsäkradPersNr,
                    ankomstdatum = nyPrivatansökan.ankomstdatum,
                    betalningsform = nyPrivatansökan.betalningsform,
                    vuxen = nyPrivatansökan.vuxen,
                    premie = nyPrivatansökan.premie,
                    paGatuadress = nyPrivatansökan.paGatuadress,
                    paOrt = nyPrivatansökan.paOrt,
                    paPostnr = nyPrivatansökan.paPostnr,
                    tillvalsNamn = nyPrivatansökan.tillvalsNamn,
                    grundBelopp = nyPrivatansökan.grundBelopp,
                    tvGrundbelopp = nyPrivatansökan.tvGrundbelopp,
                    försäkringsbolag = nyPrivatansökan.försäkringsbolag,
                    FörsäkringstagarePrivat = new FörsäkringstagarePrivat()
                    {
                        persNr = nyFörsäkringstagarePrivat.persNr,
                        fNamn = nyFörsäkringstagarePrivat.fNamn,
                        eNamn = nyFörsäkringstagarePrivat.eNamn,
                        gatuAdress = nyFörsäkringstagarePrivat.gatuAdress,
                        ort = nyFörsäkringstagarePrivat.ort,
                        postNr = nyFörsäkringstagarePrivat.postNr,
                        tel1 = nyFörsäkringstagarePrivat.tel1,
                        tel2 = nyFörsäkringstagarePrivat.tel2,
                        email1 = nyFörsäkringstagarePrivat.email1,
                        email2 = nyFörsäkringstagarePrivat.email2,
                        prospekt = nyFörsäkringstagarePrivat.prospekt,
                    }
                };

                query.Privatansökan.Add(nyaPrivatansökan);
                query1.Privatansökan.Add(nyaPrivatansökan);

                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                                    validationError.PropertyName,
                                                    validationError.ErrorMessage);
                        }
                    }
                }

            }
        }

        // Funktion 5 - Lägger till grundbelopp
        public void SkapaGrundbelopp(Grundbelopp nyGrundbelopp, string FörsäkringsTyp)
        {
            using (var db = new DataModelContainer())
            {
                FörsäkringsTyp query1 = (from x in db.FörsäkringsTypSet
                                         where x.försäkringsTyp == FörsäkringsTyp
                                         select x).FirstOrDefault();

                Grundbelopp nyaGrundbelopp = new Grundbelopp()
                {
                    grundBelopp = nyGrundbelopp.grundBelopp,
                    datum = nyGrundbelopp.datum,
                    ackVärde = nyGrundbelopp.ackVärde
                };

                query1.Grundbelopp.Add(nyaGrundbelopp);
                db.SaveChanges();
            }
        }

        // Funktion 6 - Lägger till försäkringstyp
        public void SkapaFörsäkringstyp(FörsäkringsTyp nyFörsäkringstyp)
        {
            using (var db = new DataModelContainer())
            {
                db.FörsäkringsTypSet.Add(new FörsäkringsTyp
                {
                    försäkringsTyp = nyFörsäkringstyp.försäkringsTyp
                });
                db.SaveChanges();
            }
        }

        //Funktion 7 - Lägger till tillval
        public void SkapaTillval(Tillval nyTillval)
        {
            using (var db = new DataModelContainer())
            {
                db.TillvalSet.Add(new Tillval
                {
                    tillvalsNamn = nyTillval.tillvalsNamn,
                    datum = nyTillval.datum,
                    ackVärdeVariabel = nyTillval.ackVärdeVariabel
                });
                db.SaveChanges();
            }
        }

        //Funktion 8 - Lägger till tillvalsbelopp
        public void SkapaTillvalsbelopp(TillvalGrundbelopp nyTillvalsgrundbelopp, string Tillval)
        {
            using (var db = new DataModelContainer())
            {
                Tillval query1 = (from x in db.TillvalSet
                                  where x.tillvalsNamn == Tillval
                                  select x).FirstOrDefault();
                TillvalGrundbelopp nyaTillvalgrundbelopp = new TillvalGrundbelopp()
                {
                    grundBelopp = nyTillvalsgrundbelopp.grundBelopp
                };
                query1.TillvalGrundbelopp.Add(nyaTillvalgrundbelopp);
                db.SaveChanges();
            }
        }

        // Funktion 9 - Lägger till provisionstabellvärden
        public void SkapaProvisionstabell(Provisionstabell nyProvisiontabell)
        {
            using (var db = new DataModelContainer())
            {
                db.ProvisionstabellSet.Add(new Provisionstabell
                {
                    totaltMinAckVärde = nyProvisiontabell.totaltMinAckVärde,
                    totaltMaxAckVärde = nyProvisiontabell.totaltMaxAckVärde,
                    provionsAndelVuxen = nyProvisiontabell.provionsAndelVuxen,
                    provisionsAndelBarn = nyProvisiontabell.provisionsAndelBarn,
                    period = nyProvisiontabell.period,
                });
                db.SaveChanges();
            }
        }


        // Funktion 10 - Lägger till semesterersättning
        public void SkapaSemesterersättning(Semesterersättning nySemesterersättning)
        {
            using (var db = new DataModelContainer())
            {
                db.SemesterersättningSet.Add(new Semesterersättning
                {
                    år = nySemesterersättning.år,
                    avdrag = nySemesterersättning.avdrag,
                    procentsats = nySemesterersättning.procentsats,
                });
                db.SaveChanges();
            }
        }

        // Funktion 11 - Lägger till företagsförsäkring
        public void SkapaFöretagFörsäkring(int ID, FörsäkringFöretag nyFöretagsFörsäkring)
        {
            using (var db = new DataModelContainer())
            {
                Företagsansökan query = (from x in db.FöretagsansökanSet
                                         where x.företagsAnsökningsId == ID
                                         select x).FirstOrDefault();

                FörsäkringFöretag nyaFöretagsFörsäkringar = new FörsäkringFöretag()
                {
                    försäkringsNr = nyFöretagsFörsäkring.försäkringsNr,
                    betald = nyFöretagsFörsäkring.betald,
                    provisionsbelopp = nyFöretagsFörsäkring.provisionsbelopp,
                };

                query.FörsäkringFöretag.Add(nyaFöretagsFörsäkringar);
                db.SaveChanges();
            }
        }

        public void SkapaUpdateFöretagFörsäkring(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            var query = from x in db.FöretagsansökanSet
                        where x.företagsAnsökningsId == ID
                        select x;

            Företagsansökan a = query.FirstOrDefault();
            a.försäkringsbolag = nyFöretagsansökan.försäkringsbolag;
            a.begynnelsedatum = nyFöretagsansökan.begynnelsedatum;
            a.förfallodag = nyFöretagsansökan.förfallodag;
            a.betalningsform = nyFöretagsansökan.betalningsform;
            a.premie = nyFöretagsansökan.premie;
            a.Anteckning = nyFöretagsansökan.Anteckning;
            a.försäkringsTyp = nyFöretagsansökan.försäkringsTyp;

            a.FörsäkringstagareFöretag.företagsNamn = nyFörsäkringstagareFöretag.företagsNamn;
            a.FörsäkringstagareFöretag.orgNr = nyFörsäkringstagareFöretag.orgNr;
            a.FörsäkringstagareFöretag.kFNamn = nyFörsäkringstagareFöretag.kFNamn;
            a.FörsäkringstagareFöretag.kENamn = nyFörsäkringstagareFöretag.kENamn;
            a.FörsäkringstagareFöretag.gatuAdress = nyFörsäkringstagareFöretag.gatuAdress;
            a.FörsäkringstagareFöretag.ort = nyFörsäkringstagareFöretag.ort;
            a.FörsäkringstagareFöretag.postNr = nyFörsäkringstagareFöretag.postNr;
            a.FörsäkringstagareFöretag.tel1 = nyFörsäkringstagareFöretag.tel1;
            a.FörsäkringstagareFöretag.faxNr = nyFörsäkringstagareFöretag.faxNr;
            a.FörsäkringstagareFöretag.email1 = nyFörsäkringstagareFöretag.email1;

            db.SaveChanges();

        }
        // Funktion 12 - Lägger till privatförsäkring
        public void SkapaPrivatFörsäkring(int ID, Försäkring nyPrivatFörsäkring)
        {

            using (var db = new DataModelContainer())
            {
                Privatansökan query1 = (from x in db.PrivatansökanSet
                                        where x.privatAnsökningsId == ID
                                        select x).FirstOrDefault();

                Försäkring nyaPrivatansökan = new Försäkring()
                {
                    försäkringsNr = nyPrivatFörsäkring.försäkringsNr,
                    betald = nyPrivatFörsäkring.betald,
                    provisionsbelopp = nyPrivatFörsäkring.provisionsbelopp,
                };


                query1.Försäkring.Add(nyaPrivatansökan);
                db.SaveChanges();
            }
        }



        public void SkapaUpdatePrivatFörsäkring(int ID, string Försäkringstyp, int AgentturNr, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {

            var query = from x in db.PrivatansökanSet
                        where x.privatAnsökningsId == ID
                        select x;

            FörsäkringsTyp query1 = (from x in db.FörsäkringsTypSet
                                     where x.försäkringsTyp == Försäkringstyp
                                     select x).FirstOrDefault();

            Personal query2 = (from x in db.PersonalSet
                               where x.agenturNr == AgentturNr
                               select x).FirstOrDefault();

            Privatansökan a = query.FirstOrDefault();
            a.privatFörsäkradFNamn = nyPrivatansökan.privatFörsäkradFNamn;
            a.privatFörsäkradENamn = nyPrivatansökan.privatFörsäkradENamn;
            a.privatFörsäkradPersNr = nyPrivatansökan.privatFörsäkradPersNr;
            a.ankomstdatum = nyPrivatansökan.ankomstdatum;
            a.betalningsform = nyPrivatansökan.betalningsform;
            a.vuxen = nyPrivatansökan.vuxen;
            a.premie = nyPrivatansökan.premie;
            a.paGatuadress = nyPrivatansökan.paGatuadress;
            a.paOrt = nyPrivatansökan.paOrt;
            a.paPostnr = nyPrivatansökan.paPostnr;
            a.tillvalsNamn = nyPrivatansökan.tillvalsNamn;
            a.grundBelopp = nyPrivatansökan.grundBelopp;
            a.tvGrundbelopp = nyPrivatansökan.tvGrundbelopp;
            a.försäkringsbolag = nyPrivatansökan.försäkringsbolag;

            a.FörsäkringstagarePrivat.fNamn = nyFörsäkringstagarePrivat.fNamn;
            a.FörsäkringstagarePrivat.eNamn = nyFörsäkringstagarePrivat.eNamn;
            a.FörsäkringstagarePrivat.gatuAdress = nyFörsäkringstagarePrivat.gatuAdress;
            a.FörsäkringstagarePrivat.ort = nyFörsäkringstagarePrivat.ort;
            a.FörsäkringstagarePrivat.postNr = nyFörsäkringstagarePrivat.postNr;
            a.FörsäkringstagarePrivat.tel1 = nyFörsäkringstagarePrivat.tel1;
            a.FörsäkringstagarePrivat.tel2 = nyFörsäkringstagarePrivat.tel2;
            a.FörsäkringstagarePrivat.email1 = nyFörsäkringstagarePrivat.email1;
            a.FörsäkringstagarePrivat.email2 = nyFörsäkringstagarePrivat.email2;
            a.FörsäkringstagarePrivat.prospekt = nyFörsäkringstagarePrivat.prospekt;

            query1.Privatansökan.Add(a);
            query2.Privatansökan.Add(a);

            db.SaveChanges();
        }




        #endregion

        #region Read Funktioner
        // Funktion 1 - Visa behörighet och roll
        public List<BehörighetRollNamn> dmVisaBehörighetRollNamn()
        {
            using (var db = new DataModelContainer())
            {
                List<BehörighetRollNamn> res = (from x in db.RollSet
                                                select new BehörighetRollNamn
                                                {
                                                    behörighetsId = x.Behörighet.behörighetsId,
                                                    behörighetsTyp = x.Behörighet.behörighetsTyp,
                                                    rollNamn = x.rollNamn
                                                }).ToList();
                return res;
            }
        }

        //Funktion 2 - Visa Personal och Roll
        public List<PersonalRoll> dmVisaPersonalRoll()
        {
            using (var db = new DataModelContainer())
            {
                List<PersonalRoll> res = (from x in db.PersonalSet
                                          select new PersonalRoll
                                          {
                                              anställningsId = x.anställningsId,
                                              persNr = x.persNr,
                                              agenturNr = x.agenturNr,
                                              skattesats = x.skattesats,
                                              fNamn = x.fNamn,
                                              eNamn = x.eNamn,
                                              gatuAdress = x.gatuAdress,
                                              ort = x.ort,
                                              postNr = x.postNr,
                                              tel1 = x.tel1,
                                              tel2 = x.tel2,
                                              email = x.email,
                                              lösenord = x.lösenord,
                                              rollNamn = x.Roll.rollNamn
                                          }).ToList();
                return res;
            }
        }

        //Funktion 3 - Visa Försäkringtyp samt dess Grundbelopp
        public List<FörsäkringTypsGrundbelopp> VisaFörsäkringTypsGrundbelopp(string FörsäkringsTyp)
        {
            using (var db = new DataModelContainer())
            {
                List<FörsäkringTypsGrundbelopp> res = (from x in db.GrundbeloppSet
                                                       where x.FörsäkringsTyp.försäkringsTyp == FörsäkringsTyp
                                                       select new FörsäkringTypsGrundbelopp
                                                       {
                                                           grundbelopp = x.grundBelopp,
                                                           datum = x.datum,
                                                           ackVärde = x.ackVärde
                                                       }).ToList();
                return res;
            }
        }


        //Funktion 4 - Visa Tillval samt dess tillvalsbelopp
        public List<TillvalTillvalsbelopp> VisaTillvalTillvalsbelopp(string Tillval)
        {
            using (var db = new DataModelContainer())
            {
                List<TillvalTillvalsbelopp> res = (from x in db.TillvalGrundbeloppSet
                                                   where x.Tillval.tillvalsNamn == Tillval
                                                   select new TillvalTillvalsbelopp
                                                   {
                                                       grundbelopp = x.grundBelopp,
                                                       datum = x.Tillval.datum,
                                                       ackVärdeVariabel = x.Tillval.ackVärdeVariabel
                                                   }).ToList();
                return res;
            }
        }


        // Funktion 5 - Visa säljarens provision
        public List<Säljare> HämtaSäljare(string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<Säljare> res = (from x in db.PersonalSet
                                     where x.fNamn == fNamn

                                     select new Säljare
                                     {
                                         persNr = x.persNr,
                                         fNamn = x.fNamn,
                                         eNamn = x.eNamn,
                                         gatuAdress = x.gatuAdress,
                                         ort = x.ort,
                                         postNr = x.postNr,
                                         tel1 = x.tel1,
                                         tel2 = x.tel2,
                                         email = x.email
                                     }).ToList();
                return res.ToList();

            }
        }

        //Funktion 6 - Visa grundbelopp för vald försäkringstyp
        public List<Grundbelopp> VisaFörsäkringstyp(string FörsäkringsTyp)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.GrundbeloppSet
                            where x.FörsäkringsTyp.försäkringsTyp == FörsäkringsTyp
                            select x;

                return query.ToList();
            }
        }


        // Funktion 7 - Visa företagsansökan med försäkringstagare
        public List<FöretagsansökanFörsäkringstagare> VisaFöretagsansökanFörsäkringstagare()
        {
            using (var db = new DataModelContainer())
            {
                List<FöretagsansökanFörsäkringstagare> res = (from x in db.FöretagsansökanSet
                                                              select new FöretagsansökanFörsäkringstagare
                                                              {
                                                                  företagsnamn = x.FörsäkringstagareFöretag.företagsNamn,
                                                                  orgNr = x.FörsäkringstagareFöretag.orgNr,
                                                                  kFnamn = x.FörsäkringstagareFöretag.kFNamn,
                                                                  kEnamn = x.FörsäkringstagareFöretag.kENamn,
                                                                  gatuAdress = x.FörsäkringstagareFöretag.gatuAdress,
                                                                  ort = x.FörsäkringstagareFöretag.ort,
                                                                  postNr = x.FörsäkringstagareFöretag.postNr,
                                                                  tel1 = x.FörsäkringstagareFöretag.tel1,
                                                                  faxNr = x.FörsäkringstagareFöretag.faxNr,
                                                                  email1 = x.FörsäkringstagareFöretag.email1,
                                                                  företagsansökningsId = x.företagsAnsökningsId,
                                                                  försäkringsbolag = x.försäkringsbolag,
                                                                  begynnelsedatum = x.begynnelsedatum,
                                                                  förfallodatum = x.förfallodag,
                                                                  betalningsform = x.betalningsform,
                                                                  premie = x.premie,
                                                                  anteckning = x.Anteckning,
                                                                  försäkringstyp = x.försäkringsTyp,
                                                                  agenturNr = x.Personal.agenturNr
                                                              }).ToList();
                return res;
            }
        }


        // Funktion 8 - Verifiera inloggningsuppgifter
        public bool dmIsValid(int anställningsId, string lösenord)
        {
            var query = from p in db.PersonalSet
                        where p.anställningsId == anställningsId
                        && p.lösenord == lösenord
                        select p;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Funktion 8 - Verifiera behörighet
        public int dmAnvändarBehörighet(int AnställningsId)
        {
            DataModelContainer db = new DataModelContainer();

            var query = (from b in db.PersonalSet
                         where b.anställningsId == AnställningsId
                         select b.Roll.Behörighet.behörighetsTyp).FirstOrDefault();

            int behörighet = query;
            return behörighet;
        }

        // Funktion 8 - Verifierar användare vid inloggning
        public string dmAnvändarFnamn(int AnställningsId)
        {
            DataModelContainer db = new DataModelContainer();
            var query = (from a in db.PersonalSet
                         where a.anställningsId == AnställningsId
                         select a.fNamn + " " + a.eNamn).FirstOrDefault();
            string fnamn = query;
            return fnamn;

        }



        // Funktion 9 - Visa privatansökan och försäkringstagareprivat med dess försäkringstyper och grundbelopp samt tillval och dess grundbelopp
        public List<PrivatansökanFörsäkringstagareprivat> VisaPrivatansökanFörsäkringstagareprivat()
        {
            using (var db = new DataModelContainer())
            {
                List<PrivatansökanFörsäkringstagareprivat> res = (from x in db.PrivatansökanSet
                                                                  select new PrivatansökanFörsäkringstagareprivat
                                                                  {
                                                                      försäkringsbolag = x.försäkringsbolag,
                                                                      tvGrundbelopp = x.tvGrundbelopp,
                                                                      tillvalsNamn = x.tillvalsNamn,
                                                                      grundBelopp = x.grundBelopp,
                                                                      försäkringsTyp = x.FörsäkringsTyp.försäkringsTyp,
                                                                      agenturNr = x.Personal.agenturNr,
                                                                      persNr = x.FörsäkringstagarePrivat.persNr,
                                                                      fNamn = x.FörsäkringstagarePrivat.fNamn,
                                                                      eNamn = x.FörsäkringstagarePrivat.eNamn,
                                                                      gatuAdress = x.FörsäkringstagarePrivat.gatuAdress,
                                                                      ort = x.FörsäkringstagarePrivat.ort,
                                                                      postNr = x.FörsäkringstagarePrivat.postNr,
                                                                      tel1 = x.FörsäkringstagarePrivat.tel1,
                                                                      tel2 = x.FörsäkringstagarePrivat.tel2,
                                                                      email1 = x.FörsäkringstagarePrivat.email1,
                                                                      email2 = x.FörsäkringstagarePrivat.email2,
                                                                      privatAnsökningsId = x.privatAnsökningsId,
                                                                      privatFörsäkradPersNr = x.privatFörsäkradPersNr,
                                                                      privatFörsäkradFNamn = x.privatFörsäkradFNamn,
                                                                      privatFörsäkradENamn = x.privatFörsäkradENamn,
                                                                      ankomstdatum = x.ankomstdatum,
                                                                      betalningsform = x.betalningsform,
                                                                      vuxen = x.vuxen,
                                                                      premie = x.premie,
                                                                      paGatuadress = x.paGatuadress,
                                                                      paOrt = x.paOrt,
                                                                      paPostNr = x.paPostnr
                                                                  }).ToList();
                return res;
            };
        }

        //Funktion 10 - Visa tillsvalsgrundbelopp

        public List<TillvalGrundbelopp> VisaTillval(string Tillval)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.TillvalGrundbeloppSet
                            where x.Tillval.tillvalsNamn == Tillval
                            select x;

                return query.ToList();
            }
        }

        // Funktion 11 - Visa provisionsvärdetabell
        public List<Provisionstabell> VisaProvisionstabell()
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.ProvisionstabellSet
                            select x;

                return query.ToList();
            }
        }
        // Funktion 12 - Visa semesterersättning
        public List<Semesterersättning> VisaSemesterersättning()
        {
            var query = from x in db.SemesterersättningSet
                        select x;

            return query.ToList();
        }

        // Funktion 13 - Sök företagsanökan med försäkringstagare
        public List<SökFöretagsansökanFörsäkringstagare> SökaFöretagsansökanFörsäkringstagare(long orgNr, string FöretagsNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<SökFöretagsansökanFörsäkringstagare> res = (from x in db.FöretagsansökanSet
                                                                 where (x.FörsäkringstagareFöretag.orgNr == orgNr) || (x.FörsäkringstagareFöretag.företagsNamn == FöretagsNamn)
                                                                 select new SökFöretagsansökanFörsäkringstagare
                                                                 {
                                                                     företagsnamn = x.FörsäkringstagareFöretag.företagsNamn,
                                                                     orgNr = x.FörsäkringstagareFöretag.orgNr,
                                                                     kFnamn = x.FörsäkringstagareFöretag.kFNamn,
                                                                     kEnamn = x.FörsäkringstagareFöretag.kENamn,
                                                                     gatuAdress = x.FörsäkringstagareFöretag.gatuAdress,
                                                                     ort = x.FörsäkringstagareFöretag.ort,
                                                                     postNr = x.FörsäkringstagareFöretag.postNr,
                                                                     tel1 = x.FörsäkringstagareFöretag.tel1,
                                                                     faxNr = x.FörsäkringstagareFöretag.faxNr,
                                                                     email1 = x.FörsäkringstagareFöretag.email1,
                                                                     företagsansökningsId = x.företagsAnsökningsId,
                                                                     försäkringsbolag = x.försäkringsbolag,
                                                                     begynnelsedatum = x.begynnelsedatum,
                                                                     förfallodatum = x.förfallodag,
                                                                     betalningsform = x.betalningsform,
                                                                     premie = x.premie,
                                                                     anteckning = x.Anteckning,
                                                                     försäkringstyp = x.försäkringsTyp,
                                                                     agenturNr = x.Personal.agenturNr
                                                                 }).ToList();
                return res;
            }
        }




        // Funktion 14 - Visa Företagsförsäkring och dess Försäkringstagare
        public List<FörsäkringFöretagsansökanFörsäkringstagare> VisaFörsäkringFöretagsansökanFörsäkringstagare()
        {
            using (var db = new DataModelContainer())
            {
                List<FörsäkringFöretagsansökanFörsäkringstagare> res = (from x in db.FörsäkringFöretagSet
                                                                        select new FörsäkringFöretagsansökanFörsäkringstagare
                                                                        {
                                                                            företagsnamn = x.Företagsansökan.FörsäkringstagareFöretag.företagsNamn,
                                                                            orgNr = x.Företagsansökan.FörsäkringstagareFöretag.orgNr,
                                                                            kFnamn = x.Företagsansökan.FörsäkringstagareFöretag.kFNamn,
                                                                            kEnamn = x.Företagsansökan.FörsäkringstagareFöretag.kENamn,
                                                                            gatuAdress = x.Företagsansökan.FörsäkringstagareFöretag.gatuAdress,
                                                                            ort = x.Företagsansökan.FörsäkringstagareFöretag.ort,
                                                                            postNr = x.Företagsansökan.FörsäkringstagareFöretag.postNr,
                                                                            tel1 = x.Företagsansökan.FörsäkringstagareFöretag.tel1,
                                                                            faxNr = x.Företagsansökan.FörsäkringstagareFöretag.faxNr,
                                                                            email1 = x.Företagsansökan.FörsäkringstagareFöretag.email1,
                                                                            försäkringsbolag = x.Företagsansökan.försäkringsbolag,
                                                                            begynnelsedatum = x.Företagsansökan.begynnelsedatum,
                                                                            förfallodatum = x.Företagsansökan.förfallodag,
                                                                            betalningsform = x.Företagsansökan.betalningsform,
                                                                            premie = x.Företagsansökan.premie,
                                                                            anteckning = x.Företagsansökan.Anteckning,
                                                                            försäkringstyp = x.Företagsansökan.försäkringsTyp,
                                                                            agenturNr = x.Företagsansökan.Personal.agenturNr,
                                                                            företagsFörsäkringsID = x.FöretagsförsäkringsId,
                                                                            betald = x.betald,
                                                                            försäkringsNr = x.försäkringsNr,
                                                                            provisionsbelopp = x.provisionsbelopp
                                                                        }).ToList();
                return res;
            }
        }



        // Funktion 15 - Visa Privatförsäkring och försäkringstagareprivat med dess försäkringstyper och grundbelopp samt tillval och dess grundbelopp
        public List<FörsäkringPrivatansökanFörsäkringstagareprivat> VisaFörsäkringFörsäkringstagarePrivat()
        {
            using (var db = new DataModelContainer())
            {
                List<FörsäkringPrivatansökanFörsäkringstagareprivat> res = (from x in db.FörsäkringSet
                                                                            select new FörsäkringPrivatansökanFörsäkringstagareprivat
                                                                            {
                                                                                försäkringsbolag = x.Privatansökan.försäkringsbolag,
                                                                                tvGrundbelopp = x.Privatansökan.tvGrundbelopp,
                                                                                tillvalsNamn = x.Privatansökan.tillvalsNamn,
                                                                                grundBelopp = x.Privatansökan.grundBelopp,
                                                                                försäkringsTyp = x.Privatansökan.FörsäkringsTyp.försäkringsTyp,
                                                                                agenturNr = x.Privatansökan.Personal.agenturNr,
                                                                                persNr = x.Privatansökan.FörsäkringstagarePrivat.persNr,
                                                                                fNamn = x.Privatansökan.FörsäkringstagarePrivat.fNamn,
                                                                                eNamn = x.Privatansökan.FörsäkringstagarePrivat.eNamn,
                                                                                gatuAdress = x.Privatansökan.FörsäkringstagarePrivat.gatuAdress,
                                                                                ort = x.Privatansökan.FörsäkringstagarePrivat.ort,
                                                                                postNr = x.Privatansökan.FörsäkringstagarePrivat.postNr,
                                                                                tel1 = x.Privatansökan.FörsäkringstagarePrivat.tel1,
                                                                                tel2 = x.Privatansökan.FörsäkringstagarePrivat.tel2,
                                                                                email1 = x.Privatansökan.FörsäkringstagarePrivat.email1,
                                                                                email2 = x.Privatansökan.FörsäkringstagarePrivat.email2,
                                                                                privatFörsäkradPersNr = x.Privatansökan.privatFörsäkradPersNr,
                                                                                privatFörsäkradFNamn = x.Privatansökan.privatFörsäkradFNamn,
                                                                                privatFörsäkradENamn = x.Privatansökan.privatFörsäkradENamn,
                                                                                ankomstdatum = x.Privatansökan.ankomstdatum,
                                                                                betalningsform = x.Privatansökan.betalningsform,
                                                                                vuxen = x.Privatansökan.vuxen,
                                                                                premie = x.Privatansökan.premie,
                                                                                paGatuadress = x.Privatansökan.paGatuadress,
                                                                                paOrt = x.Privatansökan.paOrt,
                                                                                paPostNr = x.Privatansökan.paPostnr,
                                                                                försäkringsId = x.försäkringsId,
                                                                                försäkringsNr = x.försäkringsNr,
                                                                                betald = x.betald,
                                                                                provisionsbelopp = x.provisionsbelopp,
                                                                            }).ToList();
                return res;
            };
        }

        // Funktion 16 - Visa privatregister
        public List<Privatregister> VisaPrivatregister()
        {
            using (var db = new DataModelContainer())
            {
                List<Privatregister> res = (from x in db.PrivatansökanSet
                                            select new Privatregister
                                            {
                                                försäkringstagarPrivatID = x.FörsäkringstagarePrivat.försäkringstagarePrivatId,
                                                persNr = x.FörsäkringstagarePrivat.persNr,
                                                fNamn = x.FörsäkringstagarePrivat.fNamn,
                                                eNamn = x.FörsäkringstagarePrivat.eNamn,
                                                gatuAdress = x.FörsäkringstagarePrivat.gatuAdress,
                                                ort = x.FörsäkringstagarePrivat.ort,
                                                postNr = x.FörsäkringstagarePrivat.postNr,
                                                tel1 = x.FörsäkringstagarePrivat.tel1,
                                                tel2 = x.FörsäkringstagarePrivat.tel2,
                                                email1 = x.FörsäkringstagarePrivat.email1,
                                                email2 = x.FörsäkringstagarePrivat.email2,
                                                privatFörsäkradPersNr = x.privatFörsäkradPersNr,
                                                privatFörsäkradFNamn = x.privatFörsäkradFNamn,
                                                privatFörsäkradENamn = x.privatFörsäkradENamn,
                                                vuxen = x.vuxen,
                                                paGatuadress = x.paGatuadress,
                                                paOrt = x.paOrt,
                                                paPostNr = x.paPostnr,
                                            }).ToList();
                return res;
            };
        }




        //Funktion 17 - Visa Företagsregister
        public List<Företagsregister> VisaFöretagsregister()
        {
            using (var db = new DataModelContainer())
            {
                List<Företagsregister> res = (from x in db.FöretagsansökanSet
                                              select new Företagsregister
                                              {
                                                  ID = x.FörsäkringstagareFöretag.försäkringstagareFöretagId,
                                                  företagsnamn = x.FörsäkringstagareFöretag.företagsNamn,
                                                  orgNr = x.FörsäkringstagareFöretag.orgNr,
                                                  kFnamn = x.FörsäkringstagareFöretag.kFNamn,
                                                  kEnamn = x.FörsäkringstagareFöretag.kENamn,
                                                  gatuAdress = x.FörsäkringstagareFöretag.gatuAdress,
                                                  ort = x.FörsäkringstagareFöretag.ort,
                                                  postNr = x.FörsäkringstagareFöretag.postNr,
                                                  tel1 = x.FörsäkringstagareFöretag.tel1,
                                                  faxNr = x.FörsäkringstagareFöretag.faxNr,
                                                  email1 = x.FörsäkringstagareFöretag.email1,

                                              }).ToList();
                return res;
            };
        }

        //Funktion 18 - Visa användaren som är inloggad till Min profil
        public List<PersonalRoll> HämtaInloggadminprofil(string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<PersonalRoll> res = (from x in db.PersonalSet
                                          where x.fNamn + " " + x.eNamn == fNamn

                                          select new PersonalRoll
                                          {
                                              anställningsId = x.anställningsId,
                                              persNr = x.persNr,
                                              agenturNr = x.agenturNr,
                                              fNamn = x.fNamn,
                                              eNamn = x.eNamn,
                                              gatuAdress = x.gatuAdress,
                                              ort = x.ort,
                                              postNr = x.postNr,
                                              tel1 = x.tel1,
                                              tel2 = x.tel2,
                                              email = x.email,
                                              skattesats = x.skattesats,
                                              lösenord = x.lösenord,
                                              rollNamn = x.Roll.rollNamn
                                          }).ToList();
                return res.ToList();

            }
        }

        // Funktion 19 - Hämta Barn ackvärde beroende på valt år, månad, säljarens förnamn samt att det är en barnförsäkring
        public double HämtaBaAckvärde(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Barn"
                               select z.ackVärde).Sum();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }
        // Funktion 19 - Hämta vuxen ackvärde beroende på valt år, månad, säljarens förnamn samt att det är en vuxenförsäkring
        public double HämtaVuAckvärde(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                                && x.betald.Month == Month
                                && x.Privatansökan.Personal.fNamn == fNamn
                                && x.Privatansökan.vuxen == "Vuxen"
                                && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Livförsäkring för vuxen"
                                && x.Privatansökan.FörsäkringsTyp.försäkringsTyp == "Sjuk- och olycksfallsförsäkring för vuxen"
                                && z.FörsäkringsTyp.försäkringsTyp == x.Privatansökan.FörsäkringsTyp.försäkringsTyp


                               select z.ackVärde).Sum();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }


            }
        }

        //Funktion 19 - Hämta provisionsvariabler barn
        public double HämtaProvisionVariablerBarn(double sumAckvärde, string Year)
        {
            using (var db = new DataModelContainer())
            {
                var res = (from x in db.ProvisionstabellSet
                           where sumAckvärde > x.totaltMinAckVärde
                           && sumAckvärde < x.totaltMaxAckVärde
                           && x.period == Year
                           select x.provisionsAndelBarn).FirstOrDefault();

                return res;
            }
        }

        //Funktion 19 - Hämta provisionsvariabler vuxen
        public double HämtaProvisionVariablerVuxen(double sumAckvärde, string Year)
        {
            using (var db = new DataModelContainer())
            {
                var res = (from x in db.ProvisionstabellSet
                           where sumAckvärde > x.totaltMinAckVärde
                           && sumAckvärde < x.totaltMaxAckVärde
                           && x.period == Year
                           select x.provionsAndelVuxen).FirstOrDefault();

                return res;
            }
        }

        // Funktion 19 - Hämta semesterersättningsavdrag
        public double HämtaSemesterersättningAvdrag(string Year)
        {
            using (var db = new DataModelContainer())
            {
                var res = (from x in db.SemesterersättningSet
                           where x.år == Year
                           select x.avdrag).FirstOrDefault();
                return res;
            }
        }

        // Funktion 19 - Hämta semesterersättningssats
        public double HämtaSemesterersättningSats(string Year)
        {
            using (var db = new DataModelContainer())
            {
                var res = (from x in db.SemesterersättningSet
                           where x.år == Year
                           select x.procentsats).FirstOrDefault();
                return res;
            }
        }


        // Funktion 19 - Hämta livssumma ackvärde beroende på valt år, månad, säljarens förnamn samt att det är en vuxenförsäkring
        public double HämtaLivsSummaAckvärde(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Vuxen"
                               && z.FörsäkringsTyp.försäkringsTyp == "Livförsäkring för vuxen"
                               && z.datum.Year == Year
                               select z.ackVärde).FirstOrDefault();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }


            }
        }

        // Funktion 19 - Hämta livssumma grundbelopp beroende på valt år, månad, säljarens förnamn samt att det är en vuxenförsäkring
        public double HämtaLivsSummaGrundbelopp(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on y.försäkringsTypId equals z.grundbeloppsId
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Vuxen"
                               && y.försäkringsTyp == "Livförsäkring för vuxen"
                               select x.Privatansökan.grundBelopp).Sum();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }


            }
        }


        // Funktion 19 - Hämta prov övrigt summa provisionsbelopp privat beroende på valt år, månad, säljarens förnamn samt att det är en vuxenförsäkring
        public int HämtaProvÖvrigtSummaProvisionsbeloppPrivat(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on y.försäkringsTypId equals z.grundbeloppsId
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Vuxen"
                               && x.Privatansökan.FörsäkringsTyp.försäkringsTyp == "Övriga personförsäkringar för vuxen"
                               select (int?)x.provisionsbelopp).Sum() ?? 0;
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }


            }
        }

        // Funktion 19 - Hämta prov övrigt summa provisionsbelopp företag beroende på valt år, månad och säljarens förnamn
        public int HämtaProvÖvrigtSummaProvisionsbeloppFöretag(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringFöretagSet
                               join y in db.FöretagsansökanSet on x.FöretagsförsäkringsId equals y.företagsAnsökningsId
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Företagsansökan.Personal.fNamn == fNamn
                               select x.provisionsbelopp).Sum();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }


            }
        }

        // Funktion 19 - Hämta skattesats
        public double HämtaSkattesats(string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                var res = (from x in db.PersonalSet
                           where x.fNamn == fNamn
                           select x.skattesats).FirstOrDefault();

                return res;
            }
        }

        // Funktion 20 - Sök person i privatregister 
        public List<sökPersonPrivat> SökPersonPrivatregister(long persNr, string eNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<sökPersonPrivat> res = (from x in db.PrivatansökanSet
                                             where (x.FörsäkringstagarePrivat.persNr == persNr) || (x.FörsäkringstagarePrivat.eNamn == eNamn) || (x.privatFörsäkradPersNr == persNr) || (x.privatFörsäkradENamn == eNamn)
                                             select new sökPersonPrivat
                                             {
                                                 privatFörsäkradPersNr = x.privatFörsäkradPersNr,
                                                 privatFörsäkradENamn = x.privatFörsäkradENamn,
                                                 privatAnsökningsId = x.privatAnsökningsId,
                                                 privatFörsäkradFNamn = x.privatFörsäkradFNamn,
                                                 ankomstdatum = x.ankomstdatum,
                                                 betalningsform = x.betalningsform,
                                                 vuxen = x.vuxen,
                                                 premie = x.premie,
                                                 paGatuadress = x.paGatuadress,
                                                 paOrt = x.paOrt,
                                                 paPostnr = x.paPostnr,
                                                 tillvalsNamn = x.tillvalsNamn,
                                                 grundBelopp = x.grundBelopp,
                                                 tvGrundbelopp = x.tvGrundbelopp,
                                                 försäkringsbolag = x.försäkringsbolag,

                                                 försäkringstagarPrivatID = x.FörsäkringstagarePrivat.försäkringstagarePrivatId,
                                                 fNamn = x.FörsäkringstagarePrivat.fNamn,
                                                 eNamn = x.FörsäkringstagarePrivat.eNamn,
                                                 gatuAdress = x.FörsäkringstagarePrivat.gatuAdress,
                                                 persNr = x.FörsäkringstagarePrivat.persNr,
                                                 ort = x.FörsäkringstagarePrivat.ort,
                                                 postNr = x.FörsäkringstagarePrivat.postNr,
                                                 tel1 = x.FörsäkringstagarePrivat.tel1,
                                                 tel2 = x.FörsäkringstagarePrivat.tel2,
                                                 email1 = x.FörsäkringstagarePrivat.email1,
                                                 email2 = x.FörsäkringstagarePrivat.email2,
                                                 prospekt = x.FörsäkringstagarePrivat.prospekt,

                                             }).ToList();


                return res;
            }
        }



        //Funtion 21 - Söka i företagsregister 
        public List<sökPersonFöretag> sökpersonföretagsregister(long orgNr1, string företagsNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<sökPersonFöretag> res = (from x in db.FörsäkringstagareFöretagSet
                                              where (x.orgNr == orgNr1) || (x.företagsNamn == företagsNamn)
                                              select new sökPersonFöretag
                                              {
                                                  försäkringstagareFöretagId = x.försäkringstagareFöretagId,
                                                  företagsNamn = x.företagsNamn,
                                                  kFNamn = x.kFNamn,
                                                  kENamn = x.kENamn,
                                                  gatuAdress = x.gatuAdress,
                                                  ort = x.ort,
                                                  postNr = x.postNr,
                                                  tel1 = x.tel1,
                                                  faxNr = x.faxNr,
                                                  email1 = x.email1,
                                                  orgNr = x.orgNr
                                              }).ToList();


                return res;
            }
        }



        //Funtion 22 - Söka privatansökningar
        public List<KlassSökPrivatAnsökan> sökPrivatAnsökan(long persNr, string eNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<KlassSökPrivatAnsökan> res = (from x in db.PrivatansökanSet
                                                   where (x.FörsäkringstagarePrivat.persNr == persNr) || (x.FörsäkringstagarePrivat.eNamn == eNamn) || (x.privatFörsäkradPersNr == persNr) || (x.privatFörsäkradENamn == eNamn)
                                                   select new KlassSökPrivatAnsökan
                                                   {
                                                       privatFörsäkradPersNr = x.privatFörsäkradPersNr,
                                                       privatFörsäkradENamn = x.privatFörsäkradENamn,
                                                       privatAnsökningsId = x.privatAnsökningsId,
                                                       privatFörsäkradFNamn = x.privatFörsäkradFNamn,
                                                       ankomstdatum = x.ankomstdatum,
                                                       betalningsform = x.betalningsform,
                                                       vuxen = x.vuxen,
                                                       premie = x.premie,
                                                       paGatuadress = x.paGatuadress,
                                                       paOrt = x.paOrt,
                                                       paPostnr = x.paPostnr,
                                                       tillvalsNamn = x.tillvalsNamn,
                                                       grundBelopp = x.grundBelopp,
                                                       tvGrundbelopp = x.tvGrundbelopp,
                                                       försäkringsbolag = x.försäkringsbolag,

                                                       försäkringstagarePrivatId = x.FörsäkringstagarePrivat.försäkringstagarePrivatId,
                                                       fNamn = x.FörsäkringstagarePrivat.fNamn,
                                                       eNamn = x.FörsäkringstagarePrivat.eNamn,
                                                       gatuAdress = x.FörsäkringstagarePrivat.gatuAdress,
                                                       persNr = x.FörsäkringstagarePrivat.persNr,
                                                       ort = x.FörsäkringstagarePrivat.ort,
                                                       postNr = x.FörsäkringstagarePrivat.postNr,
                                                       tel1 = x.FörsäkringstagarePrivat.tel1,
                                                       tel2 = x.FörsäkringstagarePrivat.tel2,
                                                       email1 = x.FörsäkringstagarePrivat.email1,
                                                       email2 = x.FörsäkringstagarePrivat.email2,
                                                       prospekt = x.FörsäkringstagarePrivat.prospekt,

                                                       agenturNr = x.Personal.agenturNr,

                                                       försäkringsTyp = x.FörsäkringsTyp.försäkringsTyp



                                                   }).ToList();


                return res;
            }
        }



        //Funtion 23- Sök privatförsäkringar
        public List<KlassSökPrivatFörsäkringar> SökförsäkringPrivat(long persNr, string eNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<KlassSökPrivatFörsäkringar> res = (from x in db.FörsäkringSet

                                                        where (x.Privatansökan.FörsäkringstagarePrivat.persNr == persNr) || (x.Privatansökan.FörsäkringstagarePrivat.eNamn == eNamn) || (x.Privatansökan.privatFörsäkradPersNr == persNr) || (x.Privatansökan.privatFörsäkradENamn == eNamn)

                                                        select new KlassSökPrivatFörsäkringar
                                                        {
                                                            privatFörsäkradPersNr = x.Privatansökan.privatFörsäkradPersNr,
                                                            privatFörsäkradENamn = x.Privatansökan.privatFörsäkradENamn,
                                                            privatAnsökningsId = x.Privatansökan.privatAnsökningsId,
                                                            privatFörsäkradFNamn = x.Privatansökan.privatFörsäkradFNamn,
                                                            ankomstdatum = x.Privatansökan.ankomstdatum,
                                                            betalningsform = x.Privatansökan.betalningsform,
                                                            vuxen = x.Privatansökan.vuxen,
                                                            premie = x.Privatansökan.premie,
                                                            paGatuadress = x.Privatansökan.paGatuadress,
                                                            paOrt = x.Privatansökan.paOrt,
                                                            paPostnr = x.Privatansökan.paPostnr,
                                                            tillvalsNamn = x.Privatansökan.tillvalsNamn,
                                                            grundBelopp = x.Privatansökan.grundBelopp,
                                                            tvGrundbelopp = x.Privatansökan.tvGrundbelopp,
                                                            försäkringsbolag = x.Privatansökan.försäkringsbolag,
                                                            försäkringstagarePrivatId = x.Privatansökan.FörsäkringstagarePrivat.försäkringstagarePrivatId,
                                                            fNamn = x.Privatansökan.FörsäkringstagarePrivat.fNamn,
                                                            eNamn = x.Privatansökan.FörsäkringstagarePrivat.eNamn,
                                                            gatuAdress = x.Privatansökan.FörsäkringstagarePrivat.gatuAdress,
                                                            persNr = x.Privatansökan.FörsäkringstagarePrivat.persNr,
                                                            ort = x.Privatansökan.FörsäkringstagarePrivat.ort,
                                                            postNr = x.Privatansökan.FörsäkringstagarePrivat.postNr,
                                                            tel1 = x.Privatansökan.FörsäkringstagarePrivat.tel1,
                                                            tel2 = x.Privatansökan.FörsäkringstagarePrivat.tel2,
                                                            email1 = x.Privatansökan.FörsäkringstagarePrivat.email1,
                                                            email2 = x.Privatansökan.FörsäkringstagarePrivat.email2,
                                                            prospekt = x.Privatansökan.FörsäkringstagarePrivat.prospekt,
                                                            agenturNr = x.Privatansökan.Personal.agenturNr,
                                                            försäkringsTyp = x.Privatansökan.FörsäkringsTyp.försäkringsTyp,
                                                            försäkringsId = x.försäkringsId,
                                                            försäkringsNr = x.försäkringsNr,
                                                            provisionsbelopp = x.provisionsbelopp,
                                                            betald = x.betald
                                                        }).ToList();
                return res;
            }
        }




        // Funktion 24 - Sök företagsförsäkring
        public List<sökförsäkringföretag> Sökförsäkringföretag(long orgNr, string FöretagsNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<sökförsäkringföretag> res = (from x in db.FörsäkringFöretagSet
                                                  where (x.Företagsansökan.FörsäkringstagareFöretag.orgNr == orgNr) || (x.Företagsansökan.FörsäkringstagareFöretag.företagsNamn == FöretagsNamn)
                                                  select new sökförsäkringföretag
                                                  {
                                                      företagsFörsäkringsID = x.FöretagsförsäkringsId,
                                                      försäkringsNr = x.försäkringsNr,
                                                      betald = x.betald,
                                                      provisionsbelopp = x.provisionsbelopp,
                                                      företagsnamn = x.Företagsansökan.FörsäkringstagareFöretag.företagsNamn,
                                                      orgNr = x.Företagsansökan.FörsäkringstagareFöretag.orgNr,
                                                      kFnamn = x.Företagsansökan.FörsäkringstagareFöretag.kFNamn,
                                                      kEnamn = x.Företagsansökan.FörsäkringstagareFöretag.kENamn,
                                                      gatuAdress = x.Företagsansökan.FörsäkringstagareFöretag.gatuAdress,
                                                      ort = x.Företagsansökan.FörsäkringstagareFöretag.ort,
                                                      postNr = x.Företagsansökan.FörsäkringstagareFöretag.postNr,
                                                      tel1 = x.Företagsansökan.FörsäkringstagareFöretag.tel1,
                                                      faxNr = x.Företagsansökan.FörsäkringstagareFöretag.faxNr,
                                                      email1 = x.Företagsansökan.FörsäkringstagareFöretag.email1,
                                                      företagsansökningsId = x.Företagsansökan.företagsAnsökningsId,
                                                      försäkringsbolag = x.Företagsansökan.försäkringsbolag,
                                                      begynnelsedatum = x.Företagsansökan.begynnelsedatum,
                                                      förfallodatum = x.Företagsansökan.förfallodag,
                                                      betalningsform = x.Företagsansökan.betalningsform,
                                                      premie = x.Företagsansökan.premie,
                                                      anteckning = x.Företagsansökan.Anteckning,
                                                      försäkringstyp = x.Företagsansökan.försäkringsTyp,
                                                      agenturNr = x.Företagsansökan.Personal.agenturNr
                                                  }).ToList();
                return res;
            }
        }

        //Funktion 25 - Sök befintlig försäkringstagare i skapa ansökan
        public List<KlassSökPrivatAnsökan> sökPersonNummer(long persNr)
        {
            using (var db = new DataModelContainer())
            {
                List<KlassSökPrivatAnsökan> res = (from x in db.PrivatansökanSet
                                                   where x.FörsäkringstagarePrivat.persNr == persNr
                                                   select new KlassSökPrivatAnsökan
                                                   {
                                                       privatFörsäkradPersNr = x.privatFörsäkradPersNr,
                                                       privatFörsäkradENamn = x.privatFörsäkradENamn,
                                                       privatAnsökningsId = x.privatAnsökningsId,
                                                       privatFörsäkradFNamn = x.privatFörsäkradFNamn,
                                                       ankomstdatum = x.ankomstdatum,
                                                       betalningsform = x.betalningsform,
                                                       vuxen = x.vuxen,
                                                       premie = x.premie,
                                                       paGatuadress = x.paGatuadress,
                                                       paOrt = x.paOrt,
                                                       paPostnr = x.paPostnr,
                                                       tillvalsNamn = x.tillvalsNamn,
                                                       grundBelopp = x.grundBelopp,
                                                       tvGrundbelopp = x.tvGrundbelopp,
                                                       försäkringsbolag = x.försäkringsbolag,
                                                       försäkringstagarePrivatId = x.FörsäkringstagarePrivat.försäkringstagarePrivatId,
                                                       fNamn = x.FörsäkringstagarePrivat.fNamn,
                                                       eNamn = x.FörsäkringstagarePrivat.eNamn,
                                                       gatuAdress = x.FörsäkringstagarePrivat.gatuAdress,
                                                       persNr = x.FörsäkringstagarePrivat.persNr,
                                                       ort = x.FörsäkringstagarePrivat.ort,
                                                       postNr = x.FörsäkringstagarePrivat.postNr,
                                                       tel1 = x.FörsäkringstagarePrivat.tel1,
                                                       tel2 = x.FörsäkringstagarePrivat.tel2,
                                                       email1 = x.FörsäkringstagarePrivat.email1,
                                                       email2 = x.FörsäkringstagarePrivat.email2,
                                                       prospekt = x.FörsäkringstagarePrivat.prospekt,
                                                       agenturNr = x.Personal.agenturNr,
                                                       försäkringsTyp = x.FörsäkringsTyp.försäkringsTyp
                                                   }).ToList();
                return res;
            }
        }

        //Funktion 26 - Sök försäkrad i skapa ny ansökan
        public List<KlassSökPrivatAnsökan> sökpersnrförsäkrad(long persNr)
        {
            using (var db = new DataModelContainer())
            {
                List<KlassSökPrivatAnsökan> res = (from x in db.PrivatansökanSet
                                                   where (x.privatFörsäkradPersNr == persNr) || (x.FörsäkringstagarePrivat.persNr == persNr)
                                                   select new KlassSökPrivatAnsökan
                                                   {
                                                       privatFörsäkradPersNr = x.privatFörsäkradPersNr,
                                                       privatFörsäkradENamn = x.privatFörsäkradENamn,
                                                       privatAnsökningsId = x.privatAnsökningsId,
                                                       privatFörsäkradFNamn = x.privatFörsäkradFNamn,
                                                       ankomstdatum = x.ankomstdatum,
                                                       betalningsform = x.betalningsform,
                                                       vuxen = x.vuxen,
                                                       premie = x.premie,
                                                       paGatuadress = x.paGatuadress,
                                                       paOrt = x.paOrt,
                                                       paPostnr = x.paPostnr,
                                                       tillvalsNamn = x.tillvalsNamn,
                                                       grundBelopp = x.grundBelopp,
                                                       tvGrundbelopp = x.tvGrundbelopp,
                                                       försäkringsbolag = x.försäkringsbolag,
                                                       försäkringstagarePrivatId = x.FörsäkringstagarePrivat.försäkringstagarePrivatId,
                                                       fNamn = x.FörsäkringstagarePrivat.fNamn,
                                                       eNamn = x.FörsäkringstagarePrivat.eNamn,
                                                       gatuAdress = x.FörsäkringstagarePrivat.gatuAdress,
                                                       persNr = x.FörsäkringstagarePrivat.persNr,
                                                       ort = x.FörsäkringstagarePrivat.ort,
                                                       postNr = x.FörsäkringstagarePrivat.postNr,
                                                       tel1 = x.FörsäkringstagarePrivat.tel1,
                                                       tel2 = x.FörsäkringstagarePrivat.tel2,
                                                       email1 = x.FörsäkringstagarePrivat.email1,
                                                       email2 = x.FörsäkringstagarePrivat.email2,
                                                       prospekt = x.FörsäkringstagarePrivat.prospekt,
                                                       agenturNr = x.Personal.agenturNr,
                                                       försäkringsTyp = x.FörsäkringsTyp.försäkringsTyp
                                                   }).ToList();
                return res;
            }
        }



        //Funktion 27 - Sök företag i skapa ny företagsansökan 
        public List<sökPersonFöretag> sökoOrganisationsNamn(string företagsNamn)
        {
            using (var db = new DataModelContainer())
            {
                List<sökPersonFöretag> res = (from x in db.FörsäkringstagareFöretagSet
                                              where x.företagsNamn == företagsNamn
                                              select new sökPersonFöretag
                                              {
                                                  försäkringstagareFöretagId = x.försäkringstagareFöretagId,
                                                  företagsNamn = x.företagsNamn,
                                                  kFNamn = x.kFNamn,
                                                  kENamn = x.kENamn,
                                                  gatuAdress = x.gatuAdress,
                                                  ort = x.ort,
                                                  postNr = x.postNr,
                                                  tel1 = x.tel1,
                                                  faxNr = x.faxNr,
                                                  email1 = x.email1,
                                                  orgNr = x.orgNr
                                              }).ToList();
                return res;
            }
        }



        // Funktion 28 - Hämta försäkringsprospekt 
        public List<FörsäkringtagareProspekt> HämtaFörsäkringsProspekt()
        {
            using (var db = new DataModelContainer())
            {
                List<FörsäkringtagareProspekt> res = (from x in db.FörsäkringSet
                                                      where x.Privatansökan.FörsäkringsTyp.försäkringsTyp == "Sjuk- och olycksfallsförsäkring för barn(t.o.m. 17 års ålder)"
                                                      && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Sjuk- och olycksfallsförsäkring för vuxen"
                                                      && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Livförsäkring för vuxen"
                                                      && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Övriga personförsäkringar för vuxen"
                                                      select new FörsäkringtagareProspekt
                                                      {
                                                          fNamn = x.Privatansökan.FörsäkringstagarePrivat.fNamn,
                                                          eNamn = x.Privatansökan.FörsäkringstagarePrivat.eNamn,
                                                          persNr = x.Privatansökan.FörsäkringstagarePrivat.persNr,
                                                          gatuAdress = x.Privatansökan.FörsäkringstagarePrivat.gatuAdress,
                                                          postNr = x.Privatansökan.FörsäkringstagarePrivat.postNr,
                                                          ort = x.Privatansökan.FörsäkringstagarePrivat.ort,
                                                          telNrMobil = x.Privatansökan.FörsäkringstagarePrivat.tel1,
                                                          telNrBostad = x.Privatansökan.FörsäkringstagarePrivat.tel2,
                                                          email1 = x.Privatansökan.FörsäkringstagarePrivat.email1,
                                                          email2 = x.Privatansökan.FörsäkringstagarePrivat.email2,
                                                          agenturNr = x.Privatansökan.Personal.agenturNr,
                                                      }).ToList();

                return res;
            }
        }



        // Funktion 29 - Hämta AckVärdenBarn för trend (Funktionen funkar men inte i förhållande till vad vill att den ska funka som helhet)
        public List<AckVärdenBarn> HämtaAckvärdenBarn(int Year)
        {
            using (var db = new DataModelContainer())
            {
                List<AckVärdenBarn> ackVärden = (from x in db.FörsäkringSet
                                                 join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                                                 join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                                                 where x.betald.Year == Year
                                                 && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Livförsäkring för vuxen"
                                                 && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Övriga personförsäkringar för vuxen"
                                                 && z.FörsäkringsTyp.försäkringsTyp == x.Privatansökan.FörsäkringsTyp.försäkringsTyp
                                                 group z.ackVärde by new { x.Privatansökan.Personal.anställningsId, x.Privatansökan.Personal.fNamn, x.Privatansökan.Personal.eNamn, x.Privatansökan.vuxen, x.betald.Month } into g
                                                 select new AckVärdenBarn { anstId = g.Key.anställningsId, fNamn = g.Key.fNamn, eNamn = g.Key.eNamn, typ = g.Key.vuxen, månad = g.Key.Month, ackVärdeSumma = g.Sum() }).ToList();

                return ackVärden;
            }
        }

        // Funktion 29 - Hämta AckVärdenTotalt för trend (Funktionen funkar men inte i förhållande till vad vill att den ska funka som helhet)
        public List<AckVärdenTotalt> HämtaAckvärdenTotalt(int Year)
        {
            using (var db = new DataModelContainer())
            {
                List<AckVärdenTotalt> ackVärden = (from x in db.FörsäkringSet
                                                   join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                                                   join z in db.GrundbeloppSet on y.försäkringsTypId equals z.grundbeloppsId
                                                   where x.betald.Year == Year
                                                   && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Livförsäkring för vuxen"
                                                   && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Övriga personförsäkringar för vuxen"
                                                   group z.ackVärde by new { x.Privatansökan.Personal.fNamn, x.Privatansökan.Personal.eNamn, } into g
                                                   select new AckVärdenTotalt { fNamn = g.Key.fNamn, eNamn = g.Key.eNamn, ackVärdeSumma = g.Sum() }).ToList();


                return ackVärden;
            }
        }


        // Funktion 30 - Spara anställningsID vid inloggning för vidare användning 
        public int KollaAnställningsId(int anställningsId)
        {
            var anId = (from x in db.PersonalSet
                        where x.anställningsId == anställningsId
                        select x.anställningsId).FirstOrDefault();
            int inloggad = anId;
            return inloggad;
        }

        // Funktion 31 - Hämta AckvärdenSummaBarnSOOFB för statistik 
        public double HämtaAckVärdenSummaBarnSOOFB(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Barn"
                               select z.ackVärde).Sum();
                    return res;

                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        // Funktion 31 - Hämta AckvärdenSummaVuxenSOOFV för statistik 
        public double HämtaAckVärdenSummaVuxenSOOFV(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                                && x.betald.Month == Month
                                && x.Privatansökan.Personal.fNamn == fNamn
                                && x.Privatansökan.vuxen == "Vuxen"
                                && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Livförsäkring för vuxen"
                                && x.Privatansökan.FörsäkringsTyp.försäkringsTyp == "Sjuk- och olycksfallsförsäkring för vuxen"
                                && z.FörsäkringsTyp.försäkringsTyp == x.Privatansökan.FörsäkringsTyp.försäkringsTyp
                               select z.ackVärde).Sum();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }

        // Funktion 31 - Hämta AckVärdenSummaVuxenLFFV för statistik 
        public double HämtaAckVärdenSummaVuxenLFFV(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Vuxen"
                               && z.FörsäkringsTyp.försäkringsTyp == "Livförsäkring för vuxen"
                               && z.datum.Year == Year
                               select z.ackVärde).Sum();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }

        // Funktion 31 - Hämta Antal SOOFB för statistik 
        public double HämtaAntalSOOFB(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Barn"
                               select z.ackVärde).Count();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }

        // Funktion 31 - Hämta antal SOOFV för statistik 
        public double HämtaAntalSOOFV(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on x.Privatansökan.grundBelopp equals z.grundBelopp
                               where x.betald.Year == Year
                                && x.betald.Month == Month
                                && x.Privatansökan.Personal.fNamn == fNamn
                                && x.Privatansökan.vuxen == "Vuxen"
                                && x.Privatansökan.FörsäkringsTyp.försäkringsTyp != "Livförsäkring för vuxen"
                                && x.Privatansökan.FörsäkringsTyp.försäkringsTyp == "Sjuk- och olycksfallsförsäkring för vuxen"
                                && z.FörsäkringsTyp.försäkringsTyp == x.Privatansökan.FörsäkringsTyp.försäkringsTyp
                               select z.ackVärde).Count();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }

        // Funktion 31 - Hämta antal LFFV för statistik 
        public double HämtaAntalLFFV(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on y.försäkringsTypId equals z.grundbeloppsId
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Vuxen"
                               && y.försäkringsTyp == "Livförsäkring för vuxen"
                               select x.Privatansökan.grundBelopp).Count();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }

        // Funktion 31 - Hämta antal ÖPF för statistik 
        public double HämtaAntalÖPF(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringSet
                               join y in db.FörsäkringsTypSet on x.Privatansökan.FörsäkringsTyp.försäkringsTyp equals y.försäkringsTyp
                               join z in db.GrundbeloppSet on y.försäkringsTypId equals z.grundbeloppsId
                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Privatansökan.Personal.fNamn == fNamn
                               && x.Privatansökan.vuxen == "Vuxen"
                               && y.försäkringsTyp == "Övriga personförsäkringar för vuxen"
                               select x.försäkringsId).Count();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }

        // Funktion 31 - Hämta antal företagsförsäkringar
        public double HämtaAntalFöretagsFörsäkringar(int Year, int Month, string fNamn)
        {
            using (var db = new DataModelContainer())
            {
                try
                {
                    var res = (from x in db.FörsäkringFöretagSet

                               where x.betald.Year == Year
                               && x.betald.Month == Month
                               && x.Företagsansökan.Personal.fNamn == fNamn
                               select x.FöretagsförsäkringsId).Count();
                    return res;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }

        #endregion

        #region Update funktioner
        //Funktion 1 - Uppdatera personal med nya valda värden
        public void UppdateraPersonal(int ID, Personal nyPersonal, string RollNamn)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.PersonalSet
                            where x.anställningsId == ID
                            select x;

                var query1 = from x in db.RollSet
                             where x.rollNamn == RollNamn
                             select x;

                Personal y = query.FirstOrDefault();
                y.agenturNr = nyPersonal.agenturNr;
                y.persNr = nyPersonal.persNr;
                y.eNamn = nyPersonal.eNamn;
                y.fNamn = nyPersonal.fNamn;
                y.gatuAdress = nyPersonal.gatuAdress;
                y.ort = nyPersonal.ort;
                y.postNr = nyPersonal.postNr;
                y.tel1 = nyPersonal.tel1;
                y.tel2 = nyPersonal.tel2;
                y.email = nyPersonal.email;
                y.lösenord = nyPersonal.lösenord;
                y.skattesats = nyPersonal.skattesats;
                y.Roll = query1.FirstOrDefault();

                db.SaveChanges();
            }
        }


        //Funktion 2 - Uppdatera behörighet med nya valda värden
        public void UppdateraBehörighet(int ID, int BehörighetsTyp, string RollNamn)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.BehörighetSet
                            where x.behörighetsId == ID
                            join y in db.RollSet on x.behörighetsId equals y.rollId
                            select new { x, y };
                foreach (var Result in query)
                {
                    Result.x.behörighetsTyp = BehörighetsTyp;
                    Result.y.rollNamn = RollNamn;
                }
                db.SaveChanges();
            }
        }

        // Funktion 3 - Uppdatera företagsansökan med nya valda värden
        public void UppdateraFöretagsansökan(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.FöretagsansökanSet
                            where x.företagsAnsökningsId == ID
                            join y in db.FörsäkringstagareFöretagSet on x.företagsAnsökningsId equals y.försäkringstagareFöretagId
                            select new { x, y };

                foreach (var Result in query)
                {
                    Result.x.försäkringsbolag = nyFöretagsansökan.försäkringsbolag;
                    Result.x.begynnelsedatum = nyFöretagsansökan.begynnelsedatum;
                    Result.x.förfallodag = nyFöretagsansökan.förfallodag;
                    Result.x.betalningsform = nyFöretagsansökan.betalningsform;
                    Result.x.premie = nyFöretagsansökan.premie;
                    Result.x.Anteckning = nyFöretagsansökan.Anteckning;
                    Result.x.försäkringsTyp = nyFöretagsansökan.försäkringsTyp;

                    Result.y.företagsNamn = nyFörsäkringstagareFöretag.företagsNamn;
                    Result.y.orgNr = nyFörsäkringstagareFöretag.orgNr;
                    Result.y.kFNamn = nyFörsäkringstagareFöretag.kFNamn;
                    Result.y.kENamn = nyFörsäkringstagareFöretag.kENamn;
                    Result.y.gatuAdress = nyFörsäkringstagareFöretag.gatuAdress;
                    Result.y.ort = nyFörsäkringstagareFöretag.ort;
                    Result.y.postNr = nyFörsäkringstagareFöretag.postNr;
                    Result.y.tel1 = nyFörsäkringstagareFöretag.tel1;
                    Result.y.faxNr = nyFörsäkringstagareFöretag.faxNr;
                    Result.y.email1 = nyFörsäkringstagareFöretag.email1;
                }
                db.SaveChanges();
            }
        }

        // Funktion 4 - Uppdatera privatansökan med nya valda värden
        public void UppdateraPrivatansökan(int ID, string Försäkringstyp, int AgentturNr, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {
            using (var db = new DataModelContainer())
            {

                var query = from x in db.PrivatansökanSet
                            where x.FörsäkringstagarePrivat.försäkringstagarePrivatId == ID
                            select x;

                FörsäkringsTyp query1 = (from x in db.FörsäkringsTypSet
                                         where x.försäkringsTyp == Försäkringstyp
                                         select x).FirstOrDefault();

                Personal query2 = (from x in db.PersonalSet
                                   where x.agenturNr == AgentturNr
                                   select x).FirstOrDefault();

                Privatansökan a = query.FirstOrDefault();
                a.privatFörsäkradPersNr = nyPrivatansökan.privatFörsäkradPersNr;
                a.privatFörsäkradFNamn = nyPrivatansökan.privatFörsäkradFNamn;
                a.privatFörsäkradENamn = nyPrivatansökan.privatFörsäkradENamn;
                a.privatFörsäkradPersNr = nyPrivatansökan.privatFörsäkradPersNr;
                a.vuxen = nyPrivatansökan.vuxen;
                a.paGatuadress = nyPrivatansökan.paGatuadress;
                a.paOrt = nyPrivatansökan.paOrt;
                a.paPostnr = nyPrivatansökan.paPostnr;
                a.ankomstdatum = nyPrivatansökan.ankomstdatum;
                a.betalningsform = nyPrivatansökan.betalningsform;
                a.vuxen = nyPrivatansökan.vuxen;
                a.premie = nyPrivatansökan.premie;
                a.tillvalsNamn = nyPrivatansökan.tillvalsNamn;
                a.grundBelopp = nyPrivatansökan.grundBelopp;
                a.tvGrundbelopp = nyPrivatansökan.tvGrundbelopp;

                a.FörsäkringstagarePrivat.persNr = nyFörsäkringstagarePrivat.persNr;
                a.FörsäkringstagarePrivat.fNamn = nyFörsäkringstagarePrivat.fNamn;
                a.FörsäkringstagarePrivat.eNamn = nyFörsäkringstagarePrivat.eNamn;
                a.FörsäkringstagarePrivat.gatuAdress = nyFörsäkringstagarePrivat.gatuAdress;
                a.FörsäkringstagarePrivat.ort = nyFörsäkringstagarePrivat.ort;
                a.FörsäkringstagarePrivat.postNr = nyFörsäkringstagarePrivat.postNr;
                a.FörsäkringstagarePrivat.tel1 = nyFörsäkringstagarePrivat.tel1;
                a.FörsäkringstagarePrivat.tel2 = nyFörsäkringstagarePrivat.tel2;
                a.FörsäkringstagarePrivat.email1 = nyFörsäkringstagarePrivat.email1;
                a.FörsäkringstagarePrivat.email2 = nyFörsäkringstagarePrivat.email2;

                query1.Privatansökan.Add(a);
                query2.Privatansökan.Add(a);

                db.SaveChanges();

            }
        }


        // Funktion 5 - Uppdatera företagsförsäkring med nya valda värden
        public void UppdateraFöretagsförsäkring(int ID, Företagsansökan nyFöretagsansökan, FörsäkringstagareFöretag nyFörsäkringstagareFöretag, FörsäkringFöretag nyFörsäkringFöretag)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.FörsäkringFöretagSet
                            where x.FöretagsförsäkringsId == ID
                            join y in db.FörsäkringstagareFöretagSet on x.FöretagsförsäkringsId equals y.försäkringstagareFöretagId
                            join z in db.FöretagsansökanSet on x.FöretagsförsäkringsId equals z.företagsAnsökningsId
                            select new { x, y, z };

                foreach (var Result in query)
                {
                    Result.z.försäkringsbolag = nyFöretagsansökan.försäkringsbolag;
                    Result.z.begynnelsedatum = nyFöretagsansökan.begynnelsedatum;
                    Result.z.förfallodag = nyFöretagsansökan.förfallodag;
                    Result.z.betalningsform = nyFöretagsansökan.betalningsform;
                    Result.z.premie = nyFöretagsansökan.premie;
                    Result.z.Anteckning = nyFöretagsansökan.Anteckning;
                    Result.z.försäkringsTyp = nyFöretagsansökan.försäkringsTyp;

                    Result.y.företagsNamn = nyFörsäkringstagareFöretag.företagsNamn;
                    Result.y.orgNr = nyFörsäkringstagareFöretag.orgNr;
                    Result.y.kFNamn = nyFörsäkringstagareFöretag.kFNamn;
                    Result.y.kENamn = nyFörsäkringstagareFöretag.kENamn;
                    Result.y.gatuAdress = nyFörsäkringstagareFöretag.gatuAdress;
                    Result.y.ort = nyFörsäkringstagareFöretag.ort;
                    Result.y.postNr = nyFörsäkringstagareFöretag.postNr;
                    Result.y.tel1 = nyFörsäkringstagareFöretag.tel1;
                    Result.y.faxNr = nyFörsäkringstagareFöretag.faxNr;
                    Result.y.email1 = nyFörsäkringstagareFöretag.email1;

                    Result.x.betald = nyFörsäkringFöretag.betald;
                    Result.x.försäkringsNr = nyFörsäkringFöretag.försäkringsNr;
                    Result.x.provisionsbelopp = nyFörsäkringFöretag.provisionsbelopp;
                }
                db.SaveChanges();
            }
        }

        // Funktion 6 - Uppdatera privatförsäkring med nya valda värden
        public void UppdateraPrivatFörsäkring(int ID, string FörsäkringsTyp, int AgentturNr, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat, Försäkring nyFörsäkring)
        {
            using (var db = new DataModelContainer())
            {

                var query = from x in db.FörsäkringSet
                            where x.försäkringsId == ID
                            select x;

                FörsäkringsTyp query1 = (from x in db.FörsäkringsTypSet
                                         where x.försäkringsTyp == FörsäkringsTyp
                                         select x).FirstOrDefault();

                Personal query2 = (from x in db.PersonalSet
                                   where x.agenturNr == AgentturNr
                                   select x).FirstOrDefault();

                Försäkring a = query.FirstOrDefault();
                a.Privatansökan.privatFörsäkradFNamn = nyPrivatansökan.privatFörsäkradFNamn;
                a.Privatansökan.privatFörsäkradENamn = nyPrivatansökan.privatFörsäkradENamn;
                a.Privatansökan.privatFörsäkradPersNr = nyPrivatansökan.privatFörsäkradPersNr;
                a.Privatansökan.ankomstdatum = nyPrivatansökan.ankomstdatum;
                a.Privatansökan.betalningsform = nyPrivatansökan.betalningsform;
                a.Privatansökan.vuxen = nyPrivatansökan.vuxen;
                a.Privatansökan.premie = nyPrivatansökan.premie;
                a.Privatansökan.paGatuadress = nyPrivatansökan.paGatuadress;
                a.Privatansökan.paOrt = nyPrivatansökan.paOrt;
                a.Privatansökan.paPostnr = nyPrivatansökan.paPostnr;
                a.Privatansökan.tillvalsNamn = nyPrivatansökan.tillvalsNamn;
                a.Privatansökan.grundBelopp = nyPrivatansökan.grundBelopp;
                a.Privatansökan.tvGrundbelopp = nyPrivatansökan.tvGrundbelopp;
                a.Privatansökan.försäkringsbolag = nyPrivatansökan.försäkringsbolag;

                a.Privatansökan.FörsäkringstagarePrivat.fNamn = nyFörsäkringstagarePrivat.fNamn;
                a.Privatansökan.FörsäkringstagarePrivat.eNamn = nyFörsäkringstagarePrivat.eNamn;
                a.Privatansökan.FörsäkringstagarePrivat.gatuAdress = nyFörsäkringstagarePrivat.gatuAdress;
                a.Privatansökan.FörsäkringstagarePrivat.ort = nyFörsäkringstagarePrivat.ort;
                a.Privatansökan.FörsäkringstagarePrivat.postNr = nyFörsäkringstagarePrivat.postNr;
                a.Privatansökan.FörsäkringstagarePrivat.tel1 = nyFörsäkringstagarePrivat.tel1;
                a.Privatansökan.FörsäkringstagarePrivat.tel2 = nyFörsäkringstagarePrivat.tel2;
                a.Privatansökan.FörsäkringstagarePrivat.email1 = nyFörsäkringstagarePrivat.email1;
                a.Privatansökan.FörsäkringstagarePrivat.email2 = nyFörsäkringstagarePrivat.email2;
                a.Privatansökan.FörsäkringstagarePrivat.prospekt = nyFörsäkringstagarePrivat.prospekt;

                a.försäkringsNr = nyFörsäkring.försäkringsNr;
                a.betald = nyFörsäkring.betald;
                a.provisionsbelopp = nyFörsäkring.provisionsbelopp;

                query1.Privatansökan.Add(a.Privatansökan);
                query2.Privatansökan.Add(a.Privatansökan);

                db.SaveChanges();
            }
        }


        //Funktion 7 - Uppdatera privatprofil med nya valda värden
        public void UppdateraPrivatprofil(long ID, Privatansökan nyPrivatansökan, FörsäkringstagarePrivat nyFörsäkringstagarePrivat)
        {
            using (var db = new DataModelContainer())
            {

                var query = from x in db.PrivatansökanSet
                            where x.FörsäkringstagarePrivat.försäkringstagarePrivatId == ID
                            select x;


                Privatansökan a = query.FirstOrDefault();
                a.privatFörsäkradPersNr = nyPrivatansökan.privatFörsäkradPersNr;
                a.privatFörsäkradFNamn = nyPrivatansökan.privatFörsäkradFNamn;
                a.privatFörsäkradENamn = nyPrivatansökan.privatFörsäkradENamn;
                a.privatFörsäkradPersNr = nyPrivatansökan.privatFörsäkradPersNr;
                a.vuxen = nyPrivatansökan.vuxen;
                a.paGatuadress = nyPrivatansökan.paGatuadress;
                a.paOrt = nyPrivatansökan.paOrt;
                a.paPostnr = nyPrivatansökan.paPostnr;

                a.FörsäkringstagarePrivat.persNr = nyFörsäkringstagarePrivat.persNr;
                a.FörsäkringstagarePrivat.fNamn = nyFörsäkringstagarePrivat.fNamn;
                a.FörsäkringstagarePrivat.eNamn = nyFörsäkringstagarePrivat.eNamn;
                a.FörsäkringstagarePrivat.gatuAdress = nyFörsäkringstagarePrivat.gatuAdress;
                a.FörsäkringstagarePrivat.ort = nyFörsäkringstagarePrivat.ort;
                a.FörsäkringstagarePrivat.postNr = nyFörsäkringstagarePrivat.postNr;
                a.FörsäkringstagarePrivat.tel1 = nyFörsäkringstagarePrivat.tel1;
                a.FörsäkringstagarePrivat.tel2 = nyFörsäkringstagarePrivat.tel2;
                a.FörsäkringstagarePrivat.email1 = nyFörsäkringstagarePrivat.email1;
                a.FörsäkringstagarePrivat.email2 = nyFörsäkringstagarePrivat.email2;

                db.SaveChanges();
            }
        }

        // Funktion 8 - Uppdatera grundbelopp vid skapande av försäkring 
        public void UpdateGrundbeloppFörsäkring(int ID, int Grundbelopp)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.PrivatansökanSet
                            where x.privatAnsökningsId == ID
                            select x;
                foreach (var Result in query)
                {
                    Result.grundBelopp = Grundbelopp;
                }
                db.SaveChanges();
            }
        }

        //   Funktion 9 - Uppdatera min profil med nya valda värden
        public void UppdateraMinProfil(int ID, Personal nyPersonal)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.PersonalSet
                            where x.anställningsId == ID
                            select x;


                Personal y = query.FirstOrDefault();
                y.anställningsId = nyPersonal.anställningsId;
                y.skattesats = nyPersonal.skattesats;
                y.agenturNr = nyPersonal.agenturNr;
                y.persNr = nyPersonal.persNr;
                y.eNamn = nyPersonal.eNamn;
                y.fNamn = nyPersonal.fNamn;
                y.gatuAdress = nyPersonal.gatuAdress;
                y.ort = nyPersonal.ort;
                y.postNr = nyPersonal.postNr;
                y.tel1 = nyPersonal.tel1;
                y.tel2 = nyPersonal.tel2;
                y.email = nyPersonal.email;
                y.lösenord = nyPersonal.lösenord;



                db.SaveChanges();
            }
        }

        // Funktion 10 - Uppdatera företagsprofil med nya valda värden
        public void UppdateraFöretagsprofil(int ID, FörsäkringstagareFöretag nyFörsäkringstagareFöretag)
        {
            using (var db = new DataModelContainer())
            {
                var query = from x in db.FörsäkringstagareFöretagSet
                            where x.försäkringstagareFöretagId == ID
                            select x;

                FörsäkringstagareFöretag y = query.FirstOrDefault();
                y.företagsNamn = nyFörsäkringstagareFöretag.företagsNamn;
                y.orgNr = nyFörsäkringstagareFöretag.orgNr;
                y.kFNamn = nyFörsäkringstagareFöretag.kFNamn;
                y.kENamn = nyFörsäkringstagareFöretag.kENamn;
                y.gatuAdress = nyFörsäkringstagareFöretag.gatuAdress;
                y.ort = nyFörsäkringstagareFöretag.ort;
                y.postNr = nyFörsäkringstagareFöretag.postNr;
                y.tel1 = nyFörsäkringstagareFöretag.tel1;
                y.faxNr = nyFörsäkringstagareFöretag.faxNr;
                y.email1 = nyFörsäkringstagareFöretag.email1;

                db.SaveChanges();
            }
        }




        #endregion
    }
}



