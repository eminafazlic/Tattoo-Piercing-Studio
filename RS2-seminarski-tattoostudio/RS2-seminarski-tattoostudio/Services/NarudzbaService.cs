﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RS2_seminarski_tattoostudio.Database;
using RS2_seminarski_tattoostudio.Filters;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public class NarudzbaService : BaseCRUDService<TattooStudio.Model.Narudzba, Narudzba, NarudzbaSearchObject, NarudzbaInsertRequest, NarudzbaInsertRequest>, INarudzbaService
    {
        public NarudzbaService(TattooStudioRSIIContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        public override IList<TattooStudio.Model.Narudzba> Get(NarudzbaSearchObject search = null)
        {
            var entity = _context.Set<Narudzba>().AsQueryable();//.Include(x => x.Klijent).Include(x => x.StavkeNarudzbes).ToList();
            if (search?.IsIsporucena == true)
            {
                entity = entity.Where(x => x.IsIsporucena == search.IsIsporucena);
            }
            if (search?.IsPlacena == true)
            {
                entity = entity.Where(x => x.IsPlacena == search.IsPlacena);
            }
            var result = entity.ToList();//.Include(x => x.Klijent).Include(x => x.StavkeNarudzbes).ToList();
            return _mapper.Map<IList<TattooStudio.Model.Narudzba>>(result);
        }

        public override TattooStudio.Model.Narudzba GetById(int id)
        {
            var entity = _context.Narudzbas/*.Include(x => x.StavkeNarudzbes)
                .Include(x => x.Klijent)
                .Where(x => x.NarudzbaId == id)
                .FirstOrDefaultAsync();*/
                .Find(id);
            return _mapper.Map<TattooStudio.Model.Narudzba>(entity);
        }

        public override TattooStudio.Model.Narudzba Insert(NarudzbaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Narudzba>(request);
            entity.IsIsporucena = false;
            entity.IsPlacena = false;
            _context.Set<Database.Narudzba>().Add(entity);
            _context.SaveChanges();
            /*if(request.Proizvodi.Count() == request.Kolicine.Count())
            {
                for(int i=0; i<request.Proizvodi.Count(); i++)
                {
                    var stavkeNarudzbe = new Database.StavkeNarudzbe();
                    stavkeNarudzbe.ProizvodId = request.Proizvodi[i];
                    stavkeNarudzbe.NarudzbaId = entity.NarudzbaId;
                    stavkeNarudzbe.Kolicina = request.Kolicine[i];
                    _context.Set<Database.StavkeNarudzbe>().Add(stavkeNarudzbe);
                }
                _context.SaveChanges();
            }*/
            foreach(var x in entity.StavkeNarudzbes)
            {
                entity.UkupniIznos += x.Proizvod.Cijena * x.Kolicina;
            }
            _context.SaveChanges();
            return _mapper.Map<TattooStudio.Model.Narudzba>(entity);
        }

        public override TattooStudio.Model.Narudzba Update(int id, NarudzbaInsertRequest request)
        {
            var entity = _context.Narudzbas.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();

            /*if (request.Proizvodi.Count() == request.Kolicine.Count())
            {
                for (int i = 0; i < request.Proizvodi.Count(); i++)
                {
                    var stavka = _context.StavkeNarudzbes.Find(id);
                    stavka.ProizvodId = request.Proizvodi[i];
                    stavka.NarudzbaId = entity.NarudzbaId;
                    stavka.Kolicina = request.Kolicine[i];
                    _context.SaveChanges();
                }
            }
            foreach (var x in entity.StavkeNarudzbes)
            {
                entity.UkupniIznos += x.Proizvod.Cijena * x.Kolicina;
            }
            _context.SaveChanges();*/
            return _mapper.Map<TattooStudio.Model.Narudzba>(entity);
        }

        public override bool Delete(int id)
        {
            if (id != 0)
            {
                var stavkeNarudzbe = _context.StavkeNarudzbes.Where(x => x.NarudzbaId == id).ToList();
                foreach(var x in stavkeNarudzbe)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();
                var narudzba = _context.Narudzbas.Find(id);
                _context.Remove(narudzba);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SetPaid(int id)
        {
            var entity = _context.Narudzbas.Find(id);
            entity.IsPlacena = true;
            _context.SaveChanges();
            return true;
        }

        public int AktivnaNarudzba(int id)
        {
            var entity = _context.Narudzbas.Where(x => x.KlijentId == id && x.IsPlacena == false && x.IsIsporucena == false).FirstOrDefault();
            if (entity != null)
                return entity.NarudzbaId;
            else
            {
                Narudzba nova = new Narudzba
                {
                    Datum = DateTime.Now,
                    IsIsporucena = false,
                    IsPlacena = false,
                    KlijentId = id,
                    UkupniIznos = 0
                };
                _context.Set<Database.Narudzba>().Add(nova);
                _context.SaveChanges();
                return nova.NarudzbaId;
            }
        }
    }
}
