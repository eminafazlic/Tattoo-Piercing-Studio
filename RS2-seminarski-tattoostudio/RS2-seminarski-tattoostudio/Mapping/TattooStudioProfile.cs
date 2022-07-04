using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;

namespace RS2_seminarski_tattoostudio.Mapping
{
    public class TattooStudioProfile : Profile
    {
        public TattooStudioProfile()
        {
            CreateMap<Database.Klijent, TattooStudio.Model.Klijent>().ReverseMap();
            CreateMap<Database.Klijent, KlijentInsertRequest>().ReverseMap();
            CreateMap<Database.Uposlenik, TattooStudio.Model.Uposlenik>().ReverseMap();
            CreateMap<Database.Uposlenik, UposlenikInsertRequest>().ReverseMap();
            CreateMap<Database.Spol, TattooStudio.Model.Spol>().ReverseMap();
            CreateMap<Database.Zanimanje, TattooStudio.Model.Zanimanje>().ReverseMap();
            CreateMap<Database.TipProizvodum, TattooStudio.Model.TipProizvodum>().ReverseMap();
            CreateMap<Database.Proizvod, TattooStudio.Model.Proizvod>().ReverseMap();
            CreateMap<Database.Proizvod, ProizvodInsertRequest>().ReverseMap();
            CreateMap<Database.Izvjestaj, TattooStudio.Model.Izvjestaj>().ReverseMap();
            CreateMap<Database.Izvjestaj, IzvjestajInsertRequest>().ReverseMap();
            CreateMap<Database.Obavijest, TattooStudio.Model.Obavijest>().ReverseMap();
            CreateMap<Database.Obavijest, ObavijestInsertRequest>().ReverseMap();
            CreateMap<Database.Obavijest, ObavijestUpdateRequest>().ReverseMap();
            CreateMap<Database.TipTermina, TattooStudio.Model.TipTermina>().ReverseMap();
            CreateMap<Database.StavkePortfolium, TattooStudio.Model.StavkePortfolium>().ReverseMap();
            CreateMap<Database.StavkePortfolium, StavkePortfoliumInsertRequest>().ReverseMap();
            CreateMap<Database.Termin, TattooStudio.Model.Termin>().ReverseMap();
            CreateMap<Database.Termin, TerminInsertRequest>().ReverseMap();
            CreateMap<Database.Termin, TerminUpdateRequest>().ReverseMap();
            CreateMap<Database.Portfolio, TattooStudio.Model.Portfolio>().ReverseMap();
            CreateMap<Database.Portfolio, PortfolioInsertRequest>().ReverseMap();
            CreateMap<Database.StavkeNarudzbe, TattooStudio.Model.StavkeNarudzbe>().ReverseMap();
            CreateMap<Database.StavkeNarudzbe, StavkeNarudzbeInsertRequest>().ReverseMap();
            CreateMap<Database.StavkeNarudzbe, StavkeNarudzbeUpdateRequest>().ReverseMap();
            CreateMap<Database.Narudzba, TattooStudio.Model.Narudzba>().ReverseMap();
            CreateMap<Database.Narudzba, NarudzbaInsertRequest>().ReverseMap();
        }
    }
}
